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
    public class LabStaffRepository:ILabStaffRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly ILabStaffDAL _labStafDAL;
        public LabStaffRepository(ILabStaffDAL labStafDAL, ICommonRepository commonRepository)
        {
            _labStafDAL = labStafDAL;
            _commonRepository = commonRepository;
        }
        public async Task LabStaffOperations(LabStaffModel model)
        {
            DataSet ds = await _labStafDAL.LabStaffOperations(model);
        }
    }
}
