using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class PatientModel:BaseModel
    {
        public long PatientType { get; set; }
        public long TitleId { get; set; }
        public string TitleName { get; set; }
        public string PatientName { get; set; }
        public string PatientAge { get; set; }
        public long MobileNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long ReligionId { get; set; }
        public string ReligionName { get; set; }
        public long RelationId { get; set; }
        public string RelationName { get; set; }
        public long GenderId { get; set; }
        public string GenderName { get; set; }
        public long MaritalStatusId { get; set; }
        public string MaritalStatusName { get; set; }
        public List<DropDownModel> TitleList { get; set; }
        public List<DropDownModel> GenderList { get; set; }
        public List<DropDownModel> ReligionList { get; set; }
        public List<DropDownModel> MritalStatusList { get; set; }
        public List<DropDownModel> RelationList { get; set; }

    }
}
