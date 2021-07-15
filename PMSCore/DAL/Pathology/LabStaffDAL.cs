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
    public class LabStaffDAL : ILabStaffDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public LabStaffDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> GetDeleteLabStaff(LabStaffModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_GetDeleteLabStaff", cmdParams);
        }
        public async Task<DataSet> AddUpdateLabStaff(LabStaffModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_FirstName", model.FirstName),
                new MySqlParameter("@P_LastName", model.LastName),
                new MySqlParameter("@P_Gender", model.Gender),
                new MySqlParameter("@P_DOB", model.DOB),
                new MySqlParameter("@P_MobileNo", model.MobileNo),
                new MySqlParameter("@P_EmailId", model.EmailId),
                new MySqlParameter("@P_MeritalStatus", model.MeritalStatus),
                new MySqlParameter("@P_EmployeeType", model.EmployeeTypeId),
                new MySqlParameter("@P_Address", model.Address),
                new MySqlParameter("@P_Status", model.Status),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_AddUpdateLabStaff", cmdParams);
        }
    }
}
