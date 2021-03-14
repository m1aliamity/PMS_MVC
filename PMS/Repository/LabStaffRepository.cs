using DataAccess.Interface;
using Models.ModelClasses;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PMS.Repository
{
    public class LabStaffRepository: ILabStaffRepository
    {
        private readonly ILabStaffDAL _labStaffDAL;
        private readonly ICommonRepository _commonRepository;
        DataSet _ds;
        public LabStaffRepository(ILabStaffDAL labStaffDAL, ICommonRepository commonRepository)
        {
            _labStaffDAL = labStaffDAL;
            _commonRepository = commonRepository;
        }
        public void BindMasterData(LabStaffModel model)
        {
            MasterModel MasterModel = new MasterModel();
            string masterId = (int)Keys.MasterData.Gender + "|" + (int)Keys.MasterData.MritalStatus + "|" + (int)Keys.MasterData.NamePrefix + "|" + (int)Keys.MasterData.Relation + "|" + (int)Keys.MasterData.Religion + "|" + (int)Keys.MasterData.EmployeeType + "|";
            _commonRepository.GetMasterData(MasterModel, masterId);
            model.GenderList = MasterModel.GenderList;
            model.MritalStatusList = MasterModel.MritalStatusList;
            model.NamePrefixList = MasterModel.NamePrefixList;
            model.ReligionList = MasterModel.ReligionList;
            model.RelationList = MasterModel.RelationList;
            model.EmployeeTypeList = MasterModel.EmployeeTypeList;
        }
       
       public void LabStaff(LabStaffModel model)
        {

            if (model.Action == "I" || model.Action == "U")
            {
                LabStaffValidation(model);
            }
            if (model.MessageId == 0)
            {
                _ds = _labStaffDAL.LabStaff(model);
                if (@model.Action == "E")
                {
                    model.Id = Convert.ToInt64(_ds.Tables[0].Rows[0]["Id"]);
                    model.FirstName = Convert.ToString(_ds.Tables[0].Rows[0]["FirstName"]);
                    model.LastName = Convert.ToString(_ds.Tables[0].Rows[0]["LastName"]);
                    model.MobileNo = Convert.ToString(_ds.Tables[0].Rows[0]["MobileNo"]);
                    model.EmailId = Convert.ToString(_ds.Tables[0].Rows[0]["EmailId"]);
                    model.Gender = Convert.ToInt64(_ds.Tables[0].Rows[0]["Gander"]);
                    model.Religion = Convert.ToInt64(_ds.Tables[0].Rows[0]["Religion"]);
                    model.MritalStatus = Convert.ToInt64(_ds.Tables[0].Rows[0]["MritalStatus"]);
                    model.SpauseName = Convert.ToString(_ds.Tables[0].Rows[0]["SpauseName"]);
                    model.DateOfBirth = Convert.ToDateTime(_ds.Tables[0].Rows[0]["DateOfBirth"]);
                    model.AnniversaryDate = Convert.ToDateTime(_ds.Tables[0].Rows[0]["AnniversaryDate"]);
                    model.StaffType = Convert.ToInt64(_ds.Tables[0].Rows[0]["StaffType"]);
                    model.Address = Convert.ToString(_ds.Tables[0].Rows[0]["Address"]);
                    //model.LabStaffList = (from DataRow row in _ds.Tables[1].Rows
                    //                     select new CompanyModel
                    //                     {
                    //                         Id = Convert.ToInt64(row["Id"]),
                    //                         CompanyName = Convert.ToString(row["CompanyName"]),
                    //                         StreetAddress = Convert.ToString(row["StreetAddress"]),
                    //                         SloganName = Convert.ToString(row["SloganName"]),
                    //                         PhoneNo = Convert.ToString(row["PhoneNo"]),
                    //                         EmailId = Convert.ToString(row["WebSite"]),
                    //                         WebSite = Convert.ToString(row["WebSite"]),
                    //                         ShowDetail = Convert.ToBoolean(row["ShowDetail"]),
                    //                         IsActive = Convert.ToBoolean(row["IsActive"]),
                    //                         Logo = Convert.ToString(row["Logo"]),
                    //                     }).ToList();
                }
                else
                {
                    //model.CompanyList = (from DataRow row in _ds.Tables[0].Rows
                    //                     select new CompanyModel
                    //                     {
                    //                         Id = Convert.ToInt64(row["Id"]),
                    //                         CompanyName = Convert.ToString(row["CompanyName"]),
                    //                         StreetAddress = Convert.ToString(row["StreetAddress"]),
                    //                         SloganName = Convert.ToString(row["SloganName"]),
                    //                         PhoneNo = Convert.ToString(row["PhoneNo"]),
                    //                         EmailId = Convert.ToString(row["WebSite"]),
                    //                         WebSite = Convert.ToString(row["WebSite"]),
                    //                         ShowDetail = Convert.ToBoolean(row["ShowDetail"]),
                    //                         IsActive = Convert.ToBoolean(row["IsActive"]),
                    //                         Logo = Convert.ToString(row["Logo"]),
                    //                     }).ToList();
                }
            }
        }
        private void LabStaffValidation(LabStaffModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName) || string.IsNullOrWhiteSpace(model.FirstName))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.CompanyName;
            }
            //if (string.IsNullOrEmpty(model.PhoneNo) || string.IsNullOrWhiteSpace(model.PhoneNo))
            //{
            //    model.MessageId = 1;
            //    model.MessageText = Resource.ErrorMessage.PhoneNo;
            //}
            //if (!string.IsNullOrEmpty(model.PhoneNo) && model.PhoneNo.Count() != 10)
            //{
            //    model.MessageId = 1;
            //    model.MessageText = Resource.ErrorMessage.ValidPhoneNo;
            //}
            //if (!string.IsNullOrEmpty(model.EmailId))
            //{
            //    if (!Validation.Emailvalidation(model.EmailId))
            //    {
            //        model.MessageId = 1;
            //        model.MessageText = Resource.ErrorMessage.VaidEmailId;
            //    }
            //}
            //else if (string.IsNullOrEmpty(model.StreetAddress) || string.IsNullOrWhiteSpace(model.StreetAddress))
            //{
            //    model.MessageId = 1;
            //    model.MessageText = Resource.ErrorMessage.CompanyAddress;
            //}
        }
    }
}