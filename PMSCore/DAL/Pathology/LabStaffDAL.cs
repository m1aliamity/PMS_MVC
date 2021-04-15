using DAL.Connection;
using DAL.Pathology.Interface;
using Models.Pathology;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Pathology
{
    public class LabStaffDAL: ILabStaffDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public LabStaffDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> LabStaffOperations(LabStaffModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                //new MySqlParameter("@P_MID", model.MID),
                //new MySqlParameter("@P_Name", model.Name),
                //new MySqlParameter("@P_PtintName", model.PrintName),
                //new MySqlParameter("@P_Status", model.Status),
                //new MySqlParameter("@P_Rate", model.Rate),
                //new MySqlParameter("@P_Remarks", model.Remarks),
                //new MySqlParameter("@P_CID", model.CID),
                //new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_MaintainMasterOperation", cmdParams);
        }
    }
}
