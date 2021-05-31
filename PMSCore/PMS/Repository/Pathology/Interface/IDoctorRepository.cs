using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface IDoctorRepository
    {
        Task GetMasterData(DoctorModel model);
        Task GetDoctorList(DoctorModel model);
        Task DoctorOperations(DoctorModel model);
    }
}
