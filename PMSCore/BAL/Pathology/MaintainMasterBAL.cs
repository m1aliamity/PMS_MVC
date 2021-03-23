using BAL.Pathology.Interface;
using DAL.Pathology.Interface;
using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Pathology
{
    public class MaintainMasterBAL : IMaintainMasterBAL
    {
        private readonly IMaintainMasterDAL _maintainMasterDAL;
        public MaintainMasterBAL(IMaintainMasterDAL maintainMasterDAL)
        {
            _maintainMasterDAL = maintainMasterDAL;
        }
        public async Task GetMaster(MaintainMasterModel model)
        {
            DataTable dt = await _maintainMasterDAL.GetMaster(model);
            if (dt.Rows.Count > 0)
            {
                model.MasterList = (from DataRow row in dt.Rows
                                    select new DropDownModel
                                    {
                                        Value = Convert.ToString(row["Id"]),
                                        Text = Convert.ToString(row["Name"]),
                                    }).ToList();
            }
        }
        public async Task MasterDetailOperations(MaintainMasterModel model)
        {
            if (model.Action == "I" || model.Action == "U")
            {
                validate(model);
            }
            if (model.MessageId == 0)
            {
                DataSet ds = await _maintainMasterDAL.MasterDetailOperations(model);
                if (ds.Tables[0].Rows.Count >= 0)
                {
                    if (model.Action!="E")
                    {
                        model.MasterDetailsList = (from DataRow row in ds.Tables[0].Rows
                                                   select new MaintainMasterModel
                                                   {
                                                       RowId = Convert.ToInt32(row["Id"]),
                                                       Name = Convert.ToString(row["Name"]),
                                                       PrintName = Convert.ToString(row["PrintName"]),
                                                       Rate = Convert.ToDecimal(row["Rate"]),
                                                       StatusName = Convert.ToString(row["Status"]),
                                                       Remarks = Convert.ToString(row["Remarks"]),
                                                   }).ToList();
                    }
                    else 
                    {
                        model.RowId = Convert.ToInt64(ds.Tables[0].Rows[0]["Id"]);
                        model.MID = Convert.ToInt32(ds.Tables[0].Rows[0]["MID"]);
                        model.Name = Convert.ToString(ds.Tables[0].Rows[0]["Name"]);
                        model.Rate = Convert.ToDecimal(ds.Tables[0].Rows[0]["Rate"]);
                        model.PrintName = Convert.ToString(ds.Tables[0].Rows[0]["PrintName"]);
                        model.Status = Convert.ToInt32(ds.Tables[0].Rows[0]["Status"]);
                        model.Remarks = Convert.ToString(ds.Tables[0].Rows[0]["Remarks"]);
                        model.MasterDetailsList = (from DataRow row in ds.Tables[1].Rows
                                                   select new MaintainMasterModel
                                                   {
                                                       RowId = Convert.ToInt32(row["Id"]),
                                                       Name = Convert.ToString(row["Name"]),
                                                       PrintName = Convert.ToString(row["PrintName"]),
                                                       Rate = Convert.ToDecimal(row["Rate"]),
                                                       StatusName = Convert.ToString(row["Status"]),
                                                       Remarks = Convert.ToString(row["Remarks"]),
                                                   }).ToList();
                    }
                }
            }
        }
    }
}
