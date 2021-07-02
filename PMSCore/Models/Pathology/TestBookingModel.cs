using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class TestBookingModel : PatientModel
    {
        
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public long HeadId { get; set; }
        public string HeadName { get; set; }
        public long ReferredById { get; set; }
        public string ReferredByName { get; set; }
        public long SampleById { get; set; }
        public string SampleByName { get; set; }
        public long SampleTypeId { get; set; }
        public string SampleTypeName { get; set; }
        public long TestId { get; set; }
        public string TestName { get; set; }
        public long ProfileId { get; set; }
        public string ProfileName { get; set; }
        public Decimal Rate { get; set; }
        public Decimal GSTAmount { get; set; }
        public Decimal TotalAmount { get; set; }
        public Decimal PaidAmount { get; set; }
        public Decimal BalanceAmount { get; set; }
        public Decimal DiscountAmount { get; set; }
        public long PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string BookingDate { get; set; }
        public int SrNo { get; set; }
        public string TestResult { get; set; }
        public string FromRange { get; set; }
        public string ToRange { get; set; }
        public string Unit { get; set; }
        public string Interpretation { get; set; }
        public string Note { get; set; }
        public bool ResultStatus { get; set; }
        public bool PrintResult { get; set; }
        public bool PrintInterpretation { get; set; }
        public List<TestBookingModel> TestList { get; set; }
        public List<TestBookingModel> ProfileMasterList { get; set; }
        public List<DropDownModel> TestHeadMasterList { get; set; }
        public List<DropDownModel> DepartmentList { get; set; }
        public List<DropDownModel> SampleByList { get; set; }
        public List<DropDownModel> SampleTypeList { get; set; }
        public List<DropDownModel> PaymentTypeList { get; set; }
        public List<DropDownModel> ReferredByList { get; set; }


    }
}
