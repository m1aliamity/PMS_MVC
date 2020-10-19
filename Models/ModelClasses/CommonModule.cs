using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class CommonModule:DropdownModel
    {
        public List<DropdownModel> GanderList { get; set; }
        public List<DropdownModel> ReligionList { get; set; }
        public List<DropdownModel> MritalStatusList { get; set; }
        public List<DropdownModel> StaffTypeList { get; set; }

    }
}
