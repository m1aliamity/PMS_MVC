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
    public class CommonDAL : ICommonDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public CommonDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> GetCommonData(CommonModel model)
        {
            MySqlParameter[] cmdParams = {
            new MySqlParameter("@P_MID", model.MID),
            new MySqlParameter("@P_Id", model.Id),
            new MySqlParameter("@P_IsTestBooking", model.IsTestBooking),
            new MySqlParameter("@P_CID", model.CID),
            new MySqlParameter("@P_UserId", model.UserId),
            new MySqlParameter("@P_Action", model.Action),
            };
            return await _objMySqlHelper.SP_DataSet("USP_GetCommonData", cmdParams);
        }
    }
}
