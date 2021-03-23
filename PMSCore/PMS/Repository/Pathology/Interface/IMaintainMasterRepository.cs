using Models.Pathology;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface IMaintainMasterRepository
    {
        Task GetMaster(MaintainMasterModel model);
        Task MasterDetailOperations(MaintainMasterModel model);
    }
}
