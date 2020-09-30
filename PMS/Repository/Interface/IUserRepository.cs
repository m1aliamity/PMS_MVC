using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repository.Interface
{
    public interface IUserRepository
    {
        void GetLoginDetails(UserModel model);
    }
}
