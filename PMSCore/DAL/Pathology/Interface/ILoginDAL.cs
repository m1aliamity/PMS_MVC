using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Models.Pathology;

namespace DAL.Pathology.Interface
{
    public interface ILoginDAL
    {
        Task<DataTable> ValidateUser(UserModel model);
        Task<DataSet> UserOperations(UserModel model);
    }
}
