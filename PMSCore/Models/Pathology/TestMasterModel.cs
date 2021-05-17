using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class TestMasterModel:TestRangeModel
    {
        public long Department { get; set; }
        public long TestHead { get; set; }
        public string TestName { get; set; }
        public string TestRate { get; set; }
        public string Unit { get; set; }
        public string TestType { get; set; }
        public string TestUnder { get; set; }
        public string Formula { get; set; }
        public string Condition { get; set; }
        public string Interpretation { get; set; }
        public List<DropDownModel> PathologyDepartmentList { get; set; }
        public List<DropDownModel> TestHeadList { get; set; }
        public List<DropDownModel> TestTypeList { get; set; }
        public List<TestMasterModel> TestList { get; set; }
        public List<TestRangeModel> TestRangeList { get; set; }

    }
}
