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
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ICompanyDAL _companyDAL;
        public CompanyRepository(ICompanyDAL companyDAL)
        {
            _companyDAL = companyDAL;
        }
        public async Task GetCompany(CompanyModel model)
        {
           DataTable dt= await _companyDAL.GetCompany(model);
        }
        public async Task CompanyOperations(CompanyModel model)
        {
            if (model.Action == "I" || model.Action == "U")
            {
                validate(model);
            }
            if (model.MessageId == 0)
            {
                DataSet ds = await _companyDAL.CompanyOperations(model);
                if (model.Action == "I")
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.Save;
                }
                else if (model.Action == "U")
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.Update;
                }
                else if (model.Action == "D")
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }
                if (ds.Tables[0].Rows.Count >= 0)
                {
                    if (model.Action != "E")
                    {
                        model.CompanyList = (from DataRow row in ds.Tables[0].Rows
                                                   select new CompanyModel
                                                   {
                                                       RowId = Convert.ToInt32(row["Id"]),
                                                       CompanyName = Convert.ToString(row["CompanyName"]),
                                                       SloganName = Convert.ToString(row["SloganName"]),
                                                       PhoneNo = Convert.ToString(row["PhoneNo"]),
                                                       EmailId = Convert.ToString(row["EmailId"]),
                                                       WebSite= Convert.ToString(row["WebSite"]),
                                                       StatusName = Convert.ToString(row["Status"]),
                                                   }).ToList();
                    }
                    else
                    {
                        model.RowId = Convert.ToInt64(ds.Tables[0].Rows[0]["Id"]);
                        model.CompanyName = Convert.ToString(ds.Tables[0].Rows[0]["CompanyName"]);
                        model.SloganName = Convert.ToString(ds.Tables[0].Rows[0]["SloganName"]);
                        model.PhoneNo = Convert.ToString(ds.Tables[0].Rows[0]["PhoneNo"]);
                        model.EmailId = Convert.ToString(ds.Tables[0].Rows[0]["EmailId"]);
                        model.WebSite = Convert.ToString(ds.Tables[0].Rows[0]["WebSite"]);
                        model.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        model.CompanyList = (from DataRow row in ds.Tables[1].Rows
                                             select new CompanyModel
                                             {
                                                 RowId = Convert.ToInt32(row["Id"]),
                                                 CompanyName = Convert.ToString(row["CompanyName"]),
                                                 SloganName = Convert.ToString(row["SloganName"]),
                                                 PhoneNo = Convert.ToString(row["PhoneNo"]),
                                                 EmailId = Convert.ToString(row["EmailId"]),
                                                 WebSite = Convert.ToString(row["WebSite"]),
                                                 StatusName = Convert.ToString(row["Status"]),
                                             }).ToList();
                    }
                }
            }
        }
        private void validate(CompanyModel model)
        {
            
            if (string.IsNullOrEmpty(model.CompanyName) || string.IsNullOrWhiteSpace(model.CompanyName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.CompanyName;
            }
            if (string.IsNullOrEmpty(model.SloganName) || string.IsNullOrWhiteSpace(model.SloganName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.SloganName;
            }
            else if (string.IsNullOrEmpty(model.PhoneNo) || string.IsNullOrWhiteSpace(model.PhoneNo))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.CompanyPhoneNo;
            }
            else if (string.IsNullOrEmpty(model.Address) || string.IsNullOrWhiteSpace(model.Address))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.CompanyAddress;
            }
            else if (model.Status == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Status;
            }
        }

    }
}
