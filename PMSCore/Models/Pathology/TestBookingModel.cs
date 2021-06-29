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
        public DateTime BookingDate { get; set; }
        public DateTime ReportDate { get; set; }
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
