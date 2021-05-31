using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ICommonRepository
    {
        Task  GetMaster(CommonModel model);
        Task GetMasterData(CommonModel model);
        Task GetTestHeadMaster(CommonModel model);
        Task GetTestHeadMasterData(CommonModel model);

    }
}
