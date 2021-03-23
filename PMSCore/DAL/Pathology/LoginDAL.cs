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
    public class LoginDAL : ILoginDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public LoginDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataTable> ValidateUser(UserModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_UserName", model.UserName),
                new MySqlParameter("@P_Password", model.Password), };
            return await _objMySqlHelper.SP_DataTable("USP_ValidateUser", cmdParams);
        }
        public async Task<DataSet> UserOperations(UserModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_UserName", model.UserName),
                new MySqlParameter("@P_Password", model.Password),
                new MySqlParameter("@P_StaffId", model.StaffId),
                new MySqlParameter("@P_UserType", model.UserType),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_ACTION", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_UserOperations", cmdParams);
        }
    }
}
