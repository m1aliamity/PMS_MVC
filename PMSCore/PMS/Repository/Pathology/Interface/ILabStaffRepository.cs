using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
   public interface ILabStaffRepository
    {
        Task GetMasterData(LabStaffModel model);
        Task GetDeleteLabStaff(LabStaffModel model);
        Task AddUpdate(LabStaffModel model);
    }
}
