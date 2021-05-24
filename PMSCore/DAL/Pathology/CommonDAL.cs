using DAL.Connection;
using DAL.Pathology.Interface;
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
        public async Task<DataSet> GetMasterData(string MID)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_MID", MID),};
            return await _objMySqlHelper.SP_DataSet("USP_GetMaster");
        }
    }
}
