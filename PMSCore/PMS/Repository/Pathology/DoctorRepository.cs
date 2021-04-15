using DAL.Pathology.Interface;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology
{
    public class DoctorRepository: IDoctorRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly IDoctorDAL _doctorDAL;
        public DoctorRepository(IDoctorDAL doctorDAL, ICommonRepository commonRepository)
        {
            _doctorDAL = doctorDAL;
            _commonRepository = commonRepository;
        }
        public async Task DoctorOperations(DoctorModel model)
        {
            DataSet ds = await _doctorDAL.DoctorOperations(model);
        }

    }
}
