using DAL.Pathology.Interface;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology
{
    public class LabStaffRepository:ILabStaffRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly ILabStaffDAL _labStafDAL;
        public LabStaffRepository(ILabStaffDAL labStafDAL, ICommonRepository commonRepository)
        {
            _labStafDAL = labStafDAL;
            _commonRepository = commonRepository;
        }
        public async Task GetMasterData(LabStaffModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.MID = (int)Keys.MasterData.Gender + "," + (int)Keys.MasterData.MritalStatus + "," + (int)Keys.MasterData.EmployeeType + "," + (int)Keys.MasterData.RecordStatus + ",";
            await _commonRepository.GetMasterData(commonModel);
            model.GenderList = commonModel.GenderList;
            model.MeritalStatusList = commonModel.MritalStatusList;
            model.EmployeeTypeList = commonModel.EmployeeTypeList;
            model.StatusList = commonModel.StatusList;
        }
        public async Task GetDeleteLabStaff(LabStaffModel model)
        {
                DataSet ds = await _labStafDAL.GetDeleteLabStaff(model);
                if (model.Action == "D")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }
                if (model.Action != "E")
                {
                    model.LabStaffList = (from DataRow row in ds.Tables[0].Rows
                                          select new LabStaffModel
                                          {
                                              RowId = Convert.ToInt64(row["Id"]),
                                              FirstName = Convert.ToString(row["FirstName"]),
                                              LastName = Convert.ToString(row["LastName"]),
                                              MobileNo = Convert.ToString(row["MobileNo"]),
                                              EmailId = Convert.ToString(row["EmailId"]),
                                              GenderText = Convert.ToString(row["Gender"]),
                                              MeritalStatusText = Convert.ToString(row["MritalStatus"]),
                                              DOB = Convert.ToDateTime(row["DateOfBirth"]),
                                              EmployeeTypeText = Convert.ToString(row["EmployeeType"]),
                                              Address = Convert.ToString(row["Address"]),
                                              StatusName = Convert.ToString(row["IsActive"]),
                                          }).ToList();
                }
                else
                {
                    model.RowId = Convert.ToInt64(ds.Tables[0].Rows[0]["Id"]);
                    model.FirstName = Convert.ToString(ds.Tables[0].Rows[0]["FirstName"]);
                    model.LastName = Convert.ToString(ds.Tables[0].Rows[0]["LastName"]);
                    model.MobileNo = Convert.ToString(ds.Tables[0].Rows[0]["MobileNo"]);
                    model.EmailId = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
                    model.Gender = Convert.ToInt64(ds.Tables[0].Rows[0]["Gender"]);
                    model.DOB = Convert.ToDateTime(ds.Tables[0].Rows[0]["DateOfBirth"]);
                    model.MeritalStatus = Convert.ToInt64(ds.Tables[0].Rows[0]["MritalStatus"]);
                    model.EmployeeTypeId = Convert.ToInt64(ds.Tables[0].Rows[0]["EmployeeType"]);
                    model.Address = Convert.ToString(ds.Tables[0].Rows[0]["Address"]);
                    model.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["IsActive"]);
                }
        }
        public async Task AddUpdate(LabStaffModel model)
        {
             Validate(model);
            if (model.MessageId == 0)
            {
                DataSet ds = await _labStafDAL.AddUpdateLabStaff(model);
                if (model.Action == "I")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Save;
                }
                else if (model.Action == "U")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Update;
                }
            }
        }
        private void Validate(LabStaffModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName) || string.IsNullOrWhiteSpace(model.FirstName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.FName;
            }
            else if (string.IsNullOrEmpty(model.LastName) || string.IsNullOrWhiteSpace(model.LastName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.LName;
            }
            else if (model.Gender == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Gender;
            }
            //else if (string.IsNullOrEmpty(model.DOB) || string.IsNullOrWhiteSpace(model.DOB))
            //{
            //    model.MessageId = 1;
            //    model.MessageText = Resources.ValidationMessage.DOB;
            //}
            else if (string.IsNullOrEmpty(model.MobileNo) || string.IsNullOrWhiteSpace(model.MobileNo))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.MobileNo;
            }
            else if (model.MeritalStatus == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.MeritalStatus;
            }
            else if (model.EmployeeTypeId == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.EmployeeType;
            }
            else if (string.IsNullOrEmpty(model.Address) || string.IsNullOrWhiteSpace(model.Address))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Address;
            }
            else if (model.Status == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Status;
            }
        }
    }
}
