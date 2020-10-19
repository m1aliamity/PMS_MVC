using DataAccess.Interface;
using Models.ModelClasses;
using PMS.Keys;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ICompanyDAL _companyDAL;
        DataSet _ds;
        public CompanyRepository(ICompanyDAL companyDAL)
        {
            _companyDAL = companyDAL;
        }
        public void Company(CompanyModel model)
        {
            if (model.Action == "I" || model.Action == "U")
            {
                ConmpanyValidation(model);
            }
            if (model.MessageId == 0)
            {
                _ds = _companyDAL.Company(model);
                if (@model.Action == "E")
                {
                    model.Id = Convert.ToInt64(_ds.Tables[0].Rows[0]["Id"]);
                    model.CompanyName = Convert.ToString(_ds.Tables[0].Rows[0]["CompanyName"]);
                    model.StreetAddress = Convert.ToString(_ds.Tables[0].Rows[0]["StreetAddress"]);
                    model.SloganName = Convert.ToString(_ds.Tables[0].Rows[0]["SloganName"]);
                    model.PhoneNo = Convert.ToString(_ds.Tables[0].Rows[0]["PhoneNo"]);
                    model.EmailId = Convert.ToString(_ds.Tables[0].Rows[0]["WebSite"]);
                    model.WebSite = Convert.ToString(_ds.Tables[0].Rows[0]["WebSite"]);
                    model.ShowDetail = Convert.ToBoolean(_ds.Tables[0].Rows[0]["ShowDetail"]);
                    model.IsActive = Convert.ToBoolean(_ds.Tables[0].Rows[0]["IsActive"]);
                    model.Logo = Convert.ToString(_ds.Tables[0].Rows[0]["Logo"]);
                    model.CompanyList = (from DataRow row in _ds.Tables[1].Rows
                                         select new CompanyModel
                                         {
                                             Id = Convert.ToInt64(row["Id"]),
                                             CompanyName = Convert.ToString(row["CompanyName"]),
                                             StreetAddress = Convert.ToString(row["StreetAddress"]),
                                             SloganName = Convert.ToString(row["SloganName"]),
                                             PhoneNo = Convert.ToString(row["PhoneNo"]),
                                             EmailId = Convert.ToString(row["WebSite"]),
                                             WebSite = Convert.ToString(row["WebSite"]),
                                             ShowDetail = Convert.ToBoolean(row["ShowDetail"]),
                                             IsActive = Convert.ToBoolean(row["IsActive"]),
                                             Logo = Convert.ToString(row["Logo"]),
                                         }).ToList();
                }
                else
                {
                    model.CompanyList = (from DataRow row in _ds.Tables[0].Rows
                                         select new CompanyModel
                                         {
                                             Id = Convert.ToInt64(row["Id"]),
                                             CompanyName = Convert.ToString(row["CompanyName"]),
                                             StreetAddress = Convert.ToString(row["StreetAddress"]),
                                             SloganName = Convert.ToString(row["SloganName"]),
                                             PhoneNo = Convert.ToString(row["PhoneNo"]),
                                             EmailId = Convert.ToString(row["WebSite"]),
                                             WebSite = Convert.ToString(row["WebSite"]),
                                             ShowDetail = Convert.ToBoolean(row["ShowDetail"]),
                                             IsActive = Convert.ToBoolean(row["IsActive"]),
                                             Logo = Convert.ToString(row["Logo"]),
                                         }).ToList();
                }
            }
                  
        }
        private void ConmpanyValidation(CompanyModel model)
        {
            if (string.IsNullOrEmpty(model.CompanyName) || string.IsNullOrWhiteSpace(model.CompanyName))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.CompanyName;
            }
            if (string.IsNullOrEmpty(model.PhoneNo) || string.IsNullOrWhiteSpace(model.PhoneNo))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.PhoneNo;
            }
            if (!string.IsNullOrEmpty(model.PhoneNo) && model.PhoneNo.Count()!=10)
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.ValidPhoneNo;
            }
            if (!string.IsNullOrEmpty(model.EmailId))
            {
                if (!Validation.Emailvalidation(model.EmailId))
                {
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.VaidEmailId;
                }
            }
            else if (string.IsNullOrEmpty(model.StreetAddress) || string.IsNullOrWhiteSpace(model.StreetAddress))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.CompanyAddress;
            }
        }
    }
}
