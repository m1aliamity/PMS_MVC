using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Pathology.Interface
{
    public interface ITestBookingDAL
    {
        Task<DataSet> AddData(TestBookingModel model);
        Task<DataSet> TestBookingOperations(TestBookingModel model);
        Task<DataSet> SearchBookingData(TestBookingModel model);
        Task<DataSet> SaveTestResult(TestBookingModel model);
    }
}
