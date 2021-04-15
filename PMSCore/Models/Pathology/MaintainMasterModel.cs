using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class MaintainMasterModel :BaseModel 
    {
        public int MID { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public decimal Rate { get; set; }
        public string Remarks { get; set; }
        public List<DropDownModel> MasterList { get; set; }
        public List<MaintainMasterModel> MasterDetailsList { get; set; }

    }
}
