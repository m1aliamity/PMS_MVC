using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ITestMasterRepository
    {
        Task GetMasterData(TestMasterModel model);
        Task GetTestHeadMaster(TestMasterModel model);
        Task TestMasterOperations(TestMasterModel model);

    }
}
