using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Pathology.Interface
{
    public interface IMaintainMasterDAL
    {
        Task<DataSet> MasterDetailOperations(MaintainMasterModel model);
        Task<DataSet> TestHeadOperations(MaintainMasterModel model);
    }
}
