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
    public class TestMasterDAL:ITestMasterDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public TestMasterDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> TestMasterOperations(TestMasterModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_DepartmentId", model.DepartmentId),
                new MySqlParameter("@P_Department_Id", model.Department_Id),
                new MySqlParameter("@P_HeadId", model.TestHeadId),
                new MySqlParameter("@P_Head_Id", model.TestHead_Id),
                new MySqlParameter("@P_Name", model.TestName),
                new MySqlParameter("@P_Rate", model.TestRate),
                new MySqlParameter("@P_DefaultValue", model.DefaultRange),
                new MySqlParameter("@P_RangeFrom", model.FromRange),
                new MySqlParameter("@P_RangeTo", model.ToRange),
                new MySqlParameter("@P_Unit", model.Unit),
                new MySqlParameter("@P_Formula", model.Formula),
                new MySqlParameter("@P_Method", model.Method),
                new MySqlParameter("@P_Interpretations", model.Interpretation),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_TestOperations", cmdParams);
        }
        public async Task<DataSet> TestProfileOperations(TestMasterModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_ProfileId", model.ProfileId),
                new MySqlParameter("@P_TestId", model.TestId),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),};
            return await _objMySqlHelper.SP_DataSet("USP_GetProfileDetails", cmdParams);
        }
        
    }
}
