using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class CommonModel
    {
        public string MID { get; set; }
        public long Id { get; set; }
        public long CID { get; set; }
        public long UserId { get; set; }
        public int Action { get; set; }
        public bool IsTestBooking { get; set; }
        public List<DropDownModel> MasterList { get; set; }
        public List<DropDownModel> GenderList { get; set; }
        public List<DropDownModel> SpecializationList { get; set; }
        public List<DropDownModel> RelationList { get; set; }
        public List<DropDownModel> ReligionList { get; set; }
        public List<DropDownModel> MritalStatusList { get; set; }
        public List<DropDownModel> StaffTypeList { get; set; }
        public List<DropDownModel> PathologyDepartmentList { get; set; }
        public List<DropDownModel> TestHeadMasterList { get; set; }
        public List<DropDownModel> TestTypeList { get; set; }
        public List<DropDownModel> ProfileList { get; set; }
        public List<DropDownModel> SampleByList { get; set; }
        public List<DropDownModel> SampleTypeList { get; set; }
        public List<DropDownModel> PaymentTypeList { get; set; }
        public List<DropDownModel> EmployeeTypeList { get; set; }
        public List<DropDownModel> NamePrefixList { get; set; }
        public List<DropDownModel> ReferredByList { get; set; }
        public List<TestBookingModel> ProfileMasterList { get; set; }
        public List<TestBookingModel> TestList { get; set; }

    }
}
