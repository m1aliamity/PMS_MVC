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
    public class CommonRepository: ICommonRepository
    {
        private readonly ICommonDAL _commonDAL;
        public CommonRepository(ICommonDAL commonDAL)
        {
            _commonDAL = commonDAL;
        }
        public async Task GetMaster(CommonModel model)
        {
            model.Action = 1;
            DataSet ds = await _commonDAL.GetCommonData(model);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.MasterList = (from DataRow row in ds.Tables[0].Rows
                                    select new DropDownModel
                                    {
                                        Value = Convert.ToString(row["Id"]),
                                        Text = Convert.ToString(row["Name"]),
                                    }).ToList();
            }
        }
        public async Task GetTestHeadMaster(CommonModel model)
        {
            model.Action = 3;
            DataSet ds = await _commonDAL.GetCommonData(model);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.TestHeadMasterList = (from DataRow row in ds.Tables[0].Rows
                                    select new DropDownModel
                                    {
                                        Value = Convert.ToString(row["Id"]),
                                        Text = Convert.ToString(row["Name"]),
                                    }).ToList();
            }
        }
        public async Task GetTestHeadMasterData(CommonModel model)
        {
            model.Action = 3;
            DataSet ds = await _commonDAL.GetCommonData(model);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.MasterList = (from DataRow row in ds.Tables[0].Rows
                                    select new DropDownModel
                                    {
                                        Value = Convert.ToString(row["Id"]),
                                        Text = Convert.ToString(row["Name"]),
                                    }).ToList();
            }
        }
        public async Task GetMasterData(CommonModel model)
        {
            model.Action = 2;
            DataSet ds = await _commonDAL.GetCommonData(model);
            string expression = "";
            string[] ModelId = model.MID.Split(',');
            foreach (var value in ModelId)
            {

                if (value == Convert.ToString((int)Keys.MasterData.Gender))
                {
                    expression = "MID=" + (int)Keys.MasterData.Gender;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.GenderList = (from DataRow row in foundRows
                                        select new DropDownModel
                                        {
                                            Value = Convert.ToString(row["Id"]),
                                            Text = Convert.ToString(row["Name"]),
                                        }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.Relation))
                {
                    expression = "MID=" + (int)Keys.MasterData.Relation;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.ReligionList = (from DataRow row in foundRows
                                          select new DropDownModel
                                          {
                                              Value = Convert.ToString(row["Id"]),
                                              Text = Convert.ToString(row["Name"]),
                                          }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.Religion))
                {
                    expression = "MID=" + (int)Keys.MasterData.Religion;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.ReligionList = (from DataRow row in foundRows
                                          select new DropDownModel
                                          {
                                              Value = Convert.ToString(row["Id"]),
                                              Text = Convert.ToString(row["Name"]),
                                          }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.EmployeeType))
                {
                    expression = "MID=" + (int)Keys.MasterData.EmployeeType;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.StaffTypeList = (from DataRow row in foundRows
                                              select new DropDownModel
                                              {
                                                  Value = Convert.ToString(row["Id"]),
                                                  Text = Convert.ToString(row["Name"]),
                                              }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.NamePrefix))
                {
                    expression = "MID=" + (int)Keys.MasterData.NamePrefix;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.MritalStatusList = (from DataRow row in foundRows
                                            select new DropDownModel
                                            {
                                                Value = Convert.ToString(row["Id"]),
                                                Text = Convert.ToString(row["Name"]),
                                            }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.MritalStatus))
                {
                    expression = "MID=" + (int)Keys.MasterData.MritalStatus;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.MritalStatusList = (from DataRow row in foundRows
                                              select new DropDownModel
                                              {
                                                  Value = Convert.ToString(row["Id"]),
                                                  Text = Convert.ToString(row["Name"]),
                                              }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.PathologyDepartment))
                {
                    expression = "MID=" + (int)Keys.MasterData.PathologyDepartment;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.PathologyDepartmentList = (from DataRow row in foundRows
                                              select new DropDownModel
                                              {
                                                  Value = Convert.ToString(row["Id"]),
                                                  Text = Convert.ToString(row["Name"]),
                                              }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.TestType))
                {
                    expression = "MID=" + (int)Keys.MasterData.TestType;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.TestTypeList = (from DataRow row in foundRows
                                                     select new DropDownModel
                                                     {
                                                         Value = Convert.ToString(row["Id"]),
                                                         Text = Convert.ToString(row["Name"]),
                                                     }).ToList();
                }
                else if (value == Convert.ToString((int)Keys.MasterData.Specialization))
                {
                    expression = "MID=" + (int)Keys.MasterData.Specialization;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.SpecializationList = (from DataRow row in foundRows
                                          select new DropDownModel
                                          {
                                              Value = Convert.ToString(row["Id"]),
                                              Text = Convert.ToString(row["Name"]),
                                          }).ToList();
                }
            }
        }
    }
}
