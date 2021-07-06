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
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly IDoctorDAL _doctorDAL;
        public DoctorRepository(IDoctorDAL doctorDAL, ICommonRepository commonRepository)
        {
            _doctorDAL = doctorDAL;
            _commonRepository = commonRepository;
        }
        public async Task GetMasterData(DoctorModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.MID = (int)Keys.MasterData.Gender + "," + (int)Keys.MasterData.Specialization + ",";
            await _commonRepository.GetMasterData(commonModel);
            model.GenderList = commonModel.GenderList;
            model.SpecializationList = commonModel.SpecializationList;
        }
        public async Task GetDoctorList(DoctorModel model)
        {
            model.Action = "S";
            DataSet ds = await _doctorDAL.DoctorOperations(model);
            model.DoctorList = (from DataRow row in ds.Tables[0].Rows
                                select new DoctorModel
                                {
                                    RowId = Convert.ToInt64(row["Id"]),
                                    DoctorName = Convert.ToString(row["DoctorName"]),
                                    GenderText = Convert.ToString(row["Gender"]),
                                    MobileNo = Convert.ToString(row["MobileNo"]),
                                    SpecializationText = Convert.ToString(row["Specialization"]),
                                    Address = Convert.ToString(row["Address"]),
                                    EmailId = Convert.ToString(row["EmailId"]),
                                }).ToList();
        }
        public async Task DoctorOperations(DoctorModel model)
        {
            if (model.Action == "I" || model.Action == "U")
            {
                Validate(model);
            }
            if (model.MessageId == 0)
            {
                DataSet ds = await _doctorDAL.DoctorOperations(model); if (model.Action == "I")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Save;
                }
                else if (model.Action == "U")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Update;
                }
                else if (model.Action == "D")
                {
                    model.MessageId = 2;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }

                if (model.Action != "E")
                {
                    model.DoctorList = (from DataRow row in ds.Tables[0].Rows
                                        select new DoctorModel
                                        {   RowId = Convert.ToInt64(row["Id"]),
                                            DoctorName = Convert.ToString(row["DoctorName"]),
                                            GenderText = Convert.ToString(row["Gender"]),
                                            MobileNo = Convert.ToString(row["MobileNo"]),
                                            SpecializationText = Convert.ToString(row["Specialization"]),
                                            Address = Convert.ToString(row["Address"]),
                                            EmailId = Convert.ToString(row["EmailId"]),
                                        }).ToList();
                }
                else
                {
                    model.RowId = Convert.ToInt64(ds.Tables[0].Rows[0]["Id"]);
                    model.DoctorName = Convert.ToString(ds.Tables[0].Rows[0]["DoctorName"]);
                    model.Gender = Convert.ToInt64(ds.Tables[0].Rows[0]["Gender"]);
                    model.MobileNo = Convert.ToString(ds.Tables[0].Rows[0]["MobileNo"]);
                    model.Specialization = Convert.ToInt64(ds.Tables[0].Rows[0]["Specialization"]);
                    model.Address = Convert.ToString(ds.Tables[0].Rows[0]["Address"]);
                    model.EmailId = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
                    model.DoctorList = (from DataRow row in ds.Tables[0].Rows
                                        select new DoctorModel
                                        {
                                            DoctorName = Convert.ToString(row["DoctorName"]),
                                            GenderText = Convert.ToString(row["Gender"]),
                                            MobileNo = Convert.ToString(row["MobileNo"]),
                                            SpecializationText = Convert.ToString(row["Specialization"]),
                                            Address = Convert.ToString(row["Address"]),
                                            EmailId = Convert.ToString(row["EmailId"]),
                                        }).ToList();
                }
            }
        }
        private void Validate(DoctorModel model)
        {
          if (string.IsNullOrEmpty(model.DoctorName) || string.IsNullOrWhiteSpace(model.DoctorName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Name;
            }
            else if (model.Gender==0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Gender;
            }
            else if (string.IsNullOrEmpty(model.MobileNo) || string.IsNullOrWhiteSpace(model.MobileNo))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.MobileNo;
            }
        }
    }
}
