using DataAccess.DBAccessClass;
using DataAccess.Interface;
using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LabStaffDAL:ILabStaffDAL
    {
        public DataSet LabStaff(LabStaffModel model)
        {
            object[] _parameterValues = { model.Id,model.Title, model.FirstName, model.LastName, model.MobileNo, model.EmailId, model.Gender, model.Religion, model.MritalStatus, model.SpauseName, model.DateOfBirth, model.AnniversaryDate, model.StaffType, model.Address, model.CID, model.UserId, model.Action };
            return PMSDBContaxt.ExecuteQuery("SP_LabStaff", _parameterValues);
        }
    }
}
