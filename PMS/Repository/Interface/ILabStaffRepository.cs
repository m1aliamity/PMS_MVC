using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Repository.Interface
{
    public interface ILabStaffRepository
    {
        void LabStaff(LabStaffModel model);
        void BindMasterData(LabStaffModel model);
    }
}
