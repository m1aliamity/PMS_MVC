using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ITestMasterRepository
    {
        Task TestMasterOperations(TestMasterModel model);
        Task GetMasterData(TestMasterModel model);
    }
}
