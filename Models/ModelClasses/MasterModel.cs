using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class MasterModel:BaseModel
    {
        public long MID { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public string PrintName { get; set; }
        public List<DropdownModel> MasterList { get; set; }
        public List<MasterModel> MasterDetails { get; set; }

    }
}
