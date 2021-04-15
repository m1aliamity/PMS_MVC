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
        public async Task GetMasterData(CommonModel model,string MID)
        {
            DataSet ds = await _commonDAL.GetMasterData(MID);
            string expression = "";
            string[] ModelId = MID.Split('|');
            foreach (var value in ModelId)
            {

                if (value == Convert.ToString((int)Keys.MasterData.Gender))
                {
                    expression = "MID=" + (int)Keys.MasterData.Gender;
                    DataRow[] foundRows = ds.Tables[0].Select(expression);
                    model.GanderList = (from DataRow row in foundRows
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
            }
        }
    }
}
