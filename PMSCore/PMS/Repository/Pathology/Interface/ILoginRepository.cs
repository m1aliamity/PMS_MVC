using Models.Pathology;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ILoginRepository
    {
        Task ValidateUser(UserModel model);
        Task UserOperations(UserModel model);
    }
}
