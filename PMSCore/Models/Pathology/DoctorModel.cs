using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class DoctorModel:BaseModel
    {
        public string DoctorName { get; set; }
        public long Gender { get; set; }
        public long Specialization { get; set; }
        public string GenderText { get; set; }
        public string SpecializationText { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public List<DropDownModel> GenderList { get; set; }
        public List<DropDownModel> SpecializationList { get; set; }
        public List<DoctorModel> DoctorList { get; set; }
    }
}
