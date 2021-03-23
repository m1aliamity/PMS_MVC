using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Pathology.Interface
{
    public interface ILoginBAL
    {
        Task ValidateUser(UserModel model);
        Task UserOperations(UserModel model);
    }
}
