using DAL.Pathology.Interface;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology
{
    public class MaintainMasterRepository : IMaintainMasterRepository
    {
        private readonly IMaintainMasterDAL _maintainMasterDAL;
        public MaintainMasterRepository(IMaintainMasterDAL maintainMasterDAL)
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
                else if(model.Action == "D")
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }
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
        private void validate(MaintainMasterModel model)
        {
            if (model.MID == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Master;
            }
            else if (string.IsNullOrEmpty(model.Name) || string.IsNullOrWhiteSpace(model.Name))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Name;
            }
            else if (string.IsNullOrEmpty(model.PrintName) || string.IsNullOrWhiteSpace(model.PrintName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.PrintName;
            }
            else if (model.MID == 7)
            {
                if (model.Rate == 0)
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.Rate;
                }
            }
            else if (model.Status == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Status;
            }
        }
    }
}
