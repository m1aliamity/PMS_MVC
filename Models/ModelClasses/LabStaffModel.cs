using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class LabStaffModel:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long StaffType { get; set; }
        public string Address { get; set; }
        public List<LabStaffModel> LabStaffList { get; set; }
    }
}
