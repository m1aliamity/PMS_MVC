using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class CommonModel
    {
        public string MID { get; set; }
        public long Id { get; set; }
        public int Action { get; set; }
        public List<DropDownModel> MasterList { get; set; }
        public List<DropDownModel> GenderList { get; set; }
        public List<DropDownModel> SpecializationList { get; set; }
        public List<DropDownModel> ReligionList { get; set; }
        public List<DropDownModel> MritalStatusList { get; set; }
        public List<DropDownModel> StaffTypeList { get; set; }
        public List<DropDownModel> PathologyDepartmentList { get; set; }
        public List<DropDownModel> TestHeadMasterList { get; set; }
        public List<DropDownModel> TestTypeList { get; set; }
    }
}
