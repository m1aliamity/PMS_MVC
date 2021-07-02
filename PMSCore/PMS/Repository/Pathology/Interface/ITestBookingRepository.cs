using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ITestBookingRepository
    {
        Task GetMasterData(TestBookingModel model);
        Task GetTestHeadMaster(TestBookingModel model);
        Task GetTest(TestBookingModel model);
        Task AddData(TestBookingModel model);
        Task TestBookingOperations(TestBookingModel model);
        Task SearchBookingData(TestBookingModel model);
        Task SaveTestResult(TestBookingModel model);
    }
}
