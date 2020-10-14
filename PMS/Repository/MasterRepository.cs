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
    public class MasterRepository : IMasterRepository
    {
        DataSet _ds;
        private readonly IMasterDAL _masterDAL;
        public MasterRepository(IMasterDAL masterDAL)
        {
            _masterDAL = masterDAL;
        }
        public void GetMaster(MasterModel model)
        {
            _ds = _masterDAL.GetMaster(model);
            if (_ds.Tables[0].Rows.Count > 0)
            {
                model.MasterList = (from DataRow row in _ds.Tables[0].Rows
                                    select new DropdownModel
                                    {
                                        Value = Convert.ToString(row["Id"]),
                                        Text = Convert.ToString(row["MasterName"]),
                                    }).ToList();
            }

        }

        public void MasterData(MasterModel model)
        {
            if (model.Action == "I" || model.Action == "U")
            {
                validate(model);
            }
            if (model.MessageId == 0)
            {
                _ds = _masterDAL.MasterData(model);
                if (@model.Action == "E")
                {
                    model.Id = Convert.ToInt64(_ds.Tables[0].Rows[0]["Id"]);
                    model.MID = Convert.ToInt64(_ds.Tables[0].Rows[0]["Master_id"]);
                    model.Name = Convert.ToString(_ds.Tables[0].Rows[0]["Name"]);
                    model.Rate = Convert.ToDecimal(_ds.Tables[0].Rows[0]["Rate"]);
                    model.PrintName = Convert.ToString(_ds.Tables[0].Rows[0]["PrintName"]);
                    model.MasterDetails = (from DataRow row in _ds.Tables[1].Rows
                                           select new MasterModel
                                           {
                                               Id = Convert.ToInt64(row["Id"]),
                                               MID = Convert.ToInt64(row["Master_id"]),
                                               Name = Convert.ToString(row["Name"]),
                                               Rate = Convert.ToDecimal(row["Rate"]),
                                               PrintName = Convert.ToString(row["PrintName"]),
                                           }).ToList();
                }
                else
                {
                    model.MasterDetails = (from DataRow row in _ds.Tables[0].Rows
                                           select new MasterModel
                                           {
                                               Id = Convert.ToInt64(row["Id"]),
                                               MID = Convert.ToInt64(row["Master_id"]),
                                               Name = Convert.ToString(row["Name"]),
                                               Rate = Convert.ToDecimal(row["Rate"]),
                                               PrintName = Convert.ToString(row["PrintName"]),
                                           }).ToList();
                }
            }
        }
        private void validate(MasterModel model)
        {
            if (model.MID==0)
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.SelectMaster;
            }
            else if (string.IsNullOrEmpty(model.Name) || string.IsNullOrWhiteSpace(model.Name))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.MasterName;
            }
        }
    }
}