using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class TestMasterModel:TestRangeModel
    {
        public long ProfileId { get; set; }
        public long TestId { get; set; }
        public string ProfileName { get; set; }
        public string ProfileRate { get; set; }
        public long DepartmentId { get; set; }
        public long Department_Id { get; set; }
        public long TestHead_Id { get; set; }
        public long TestHeadId { get; set; }
        public string DepartmentName { get; set; }
        public string TestHeadName { get; set; }
        public string TestName { get; set; }
        public string TestRate { get; set; }
        public string Unit { get; set; }
        public string TestType { get; set; }
        public string TestUnder { get; set; }
        public string Formula { get; set; }
        public string Method { get; set; }
        public string Interpretation { get; set; }
        public List<DropDownModel> PathologyDepartmentList { get; set; }
        public List<DropDownModel> TestHeadMasterList { get; set; }
        public List<DropDownModel> ProfileList { get; set; }
        public List<DropDownModel> TestTypeMasterList { get; set; }
        public List<TestMasterModel> TestList { get; set; }
        public List<TestRangeModel> TestRangeList { get; set; }

    }
}
