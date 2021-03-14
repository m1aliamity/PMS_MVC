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
    public class CommonRepository : ICommonRepository
    {
        private readonly ICommonDAL _commonDAL;
        DataSet _ds;
        public CommonRepository(ICommonDAL commonDAL)
        {
            _commonDAL = commonDAL;
        }
        public void GetMasterData(MasterModel model, string masterId)
        {
            _ds=_commonDAL.GetMasterData(masterId);
            string expression ="";
            string[] ModelId = masterId.Split('|');
            foreach (var value in ModelId)
            {

                if (value == Convert.ToString((int)Keys.MasterData.Gender))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.Gender;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.GenderList = (from DataRow row in foundRows
                                        select new DropdownModel
                                        {
                                            Value = Convert.ToString(row["Id"]),
                                            Text = Convert.ToString(row["Name"]),
                                        }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.Relation))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.Relation;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.RelationList = (from DataRow row in foundRows
                                          select new DropdownModel
                                          {
                                              Value = Convert.ToString(row["Id"]),
                                              Text = Convert.ToString(row["Name"]),
                                          }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.Religion))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.Religion;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.ReligionList = (from DataRow row in foundRows
                                          select new DropdownModel
                                          {
                                              Value = Convert.ToString(row["Id"]),
                                              Text = Convert.ToString(row["Name"]),
                                          }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.EmployeeType))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.EmployeeType;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.EmployeeTypeList = (from DataRow row in foundRows
                                              select new DropdownModel
                                              {
                                                  Value = Convert.ToString(row["Id"]),
                                                  Text = Convert.ToString(row["Name"]),
                                              }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.NamePrefix))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.NamePrefix;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.NamePrefixList = (from DataRow row in foundRows
                                       select new DropdownModel
                                       {
                                           Value = Convert.ToString(row["Id"]),
                                           Text = Convert.ToString(row["Name"]),
                                       }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.MritalStatus))
                {
                    expression = "MasterId=" + (int)Keys.MasterData.MritalStatus;
                    DataRow[] foundRows = _ds.Tables[0].Select(expression);
                    model.MritalStatusList = (from DataRow row in foundRows
                                              select new DropdownModel
                                              {
                                                  Value = Convert.ToString(row["Id"]),
                                                  Text = Convert.ToString(row["Name"]),
                                              }).ToList();
                }
            }
        }
    }
}