using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Pathology.Interface
{
    public interface IMaintainMasterBAL
    {
        Task GetMaster(MaintainMasterModel model);
        Task MasterDetailOperations(MaintainMasterModel model);
    }
}
