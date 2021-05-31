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
    public class DoctorDAL:IDoctorDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public DoctorDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> DoctorOperations(DoctorModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_Name", model.DoctorName),
                new MySqlParameter("@P_Gender", model.Gender),
                new MySqlParameter("@P_MobileNo", model.MobileNo),
                new MySqlParameter("@P_EmailId", model.EmailId),
                new MySqlParameter("@P_Address", model.Address),
                new MySqlParameter("@P_Specialization", model.Specialization),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_DoctoreOperations", cmdParams);
        }
    }
}
