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
    public class TestBookingDAL : ITestBookingDAL
    {
        private readonly MySqlHelperClass _objMySqlHelper;
        public TestBookingDAL()
        {
            _objMySqlHelper = new MySqlHelperClass();
        }
        public async Task<DataSet> AddData(TestBookingModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_TestId", model.TestId),
                new MySqlParameter("@P_HeadId", model.HeadId),
                new MySqlParameter("@P_ProfileId", model.ProfileId),
                new MySqlParameter("@P_Rate", model.Rate),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),
                };
            return await _objMySqlHelper.SP_DataSet("USP_TestBookingDraft", cmdParams);
        }
        public async Task<DataSet> TestBookingOperations(TestBookingModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_PatientType", model.PatientType),
                new MySqlParameter("@P_TitleId", model.TitleId),
                new MySqlParameter("@P_PatientName", model.PatientName),
                new MySqlParameter("@P_GendarId", model.GenderId),
                new MySqlParameter("@P_PatientAge", model.PatientAge),
                new MySqlParameter("@P_MobileNo", model.MobileNo),
                new MySqlParameter("@P_Email", model.Email),
                new MySqlParameter("@P_Address", model.Address),
                new MySqlParameter("@P_ReferredById", model.ReferredById),
                new MySqlParameter("@P_SampleById", model.SampleById),
                new MySqlParameter("@P_SampleTypeId", model.SampleTypeId),
                new MySqlParameter("@P_TotalAmount", model.TotalAmount),
                new MySqlParameter("@P_DiscountAmount", model.DiscountAmount),
                new MySqlParameter("@P_PaidAmount", model.PaidAmount),
                new MySqlParameter("@P_BalanceAmount", model.BalanceAmount),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),
                };
            return await _objMySqlHelper.SP_DataSet("USP_TestBookingOperations", cmdParams);
        }
        public async Task<DataSet> SearchBookingData(TestBookingModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_FromDate", model.FromDate),
                new MySqlParameter("@P_ToDate", model.ToDate),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),
                };
            return await _objMySqlHelper.SP_DataSet("USP_SearchBookingData", cmdParams);
        }
        public async Task<DataSet> SaveTestResult(TestBookingModel model)
        {
            MySqlParameter[] cmdParams = {
                new MySqlParameter("@P_Id", model.RowId),
                new MySqlParameter("@P_FromRange", model.FromRange),
                new MySqlParameter("@P_ToRange", model.ToRange),
                new MySqlParameter("@P_TestResult", model.TestResult),
                new MySqlParameter("@P_Note", model.Note),
                new MySqlParameter("@P_Interpretation", model.Interpretation),
                new MySqlParameter("@P_Status", model.ResultStatus),
                new MySqlParameter("@P_PrintTest", model.PrintResult),
                new MySqlParameter("@P_PrintInterpretation", model.PrintInterpretation),
                new MySqlParameter("@P_CID", model.CID),
                new MySqlParameter("@P_UserId", model.UserId),
                new MySqlParameter("@P_Action", model.Action),
                };
            return await _objMySqlHelper.SP_DataSet("USP_SaveTestResult", cmdParams);
        }
    }
}
