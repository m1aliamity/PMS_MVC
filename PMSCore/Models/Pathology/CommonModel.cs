using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class CommonModel
    {
        public List<DropDownModel> GanderList { get; set; }
        public List<DropDownModel> ReligionList { get; set; }
        public List<DropDownModel> MritalStatusList { get; set; }
        public List<DropDownModel> StaffTypeList { get; set; }
    }
}
