using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repository.Interface
{
    public interface IMasterRepository
    {
        void GetMaster(MasterModel model);
        void MasterData(MasterModel model);
    }
}
