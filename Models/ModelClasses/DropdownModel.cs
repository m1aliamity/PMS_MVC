using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class DropdownModel
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public List<DropdownModel> GenderList { get; set; }
        public List<DropdownModel> ReligionList { get; set; }
        public List<DropdownModel> RelationList { get; set; }
        public List<DropdownModel> MritalStatusList { get; set; }
        public List<DropdownModel> EmployeeTypeList { get; set; }
        public List<DropdownModel> NamePrefixList { get; set; }
    }
}
