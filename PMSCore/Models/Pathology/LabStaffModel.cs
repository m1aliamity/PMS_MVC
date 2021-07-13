using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class LabStaffModel:BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Gender { get; set; }
        public long EmployeeTypeId { get; set; }
        public string EmployeeTypeText { get; set; }
        public string GenderText { get; set; }
        public DateTime DOB { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public long MeritalStatus { get; set; }
        public string MeritalStatusText { get; set; }
        public string Address { get; set; }
        public string SpauseName { get; set; }
        public DateTime AnniversaryDate { get; set; }
        public List<DropDownModel> GenderList { get; set; }
        public List<DropDownModel> MeritalStatusList { get; set; }
        public List<DropDownModel> EmployeeTypeList { get; set; }
        public List<LabStaffModel> LabStaffList { get; set; }
    }
}
