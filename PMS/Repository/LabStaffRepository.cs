using DataAccess.Interface;
using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PMS.Repository
{
    public class LabStaffRepository
    {
        private readonly ILabStaffDAL _labStaffDAL;
        DataSet _ds;
        public LabStaffRepository(ILabStaffDAL labStaffDAL)
        {
            _labStaffDAL = labStaffDAL;
        }
        public void LabStaff(LabStaffModel model)
        {
            _labStaffDAL.LabStaff(model);
        }
    }
}