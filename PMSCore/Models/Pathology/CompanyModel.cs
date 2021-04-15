using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Models.Pathology
{
    public class CompanyModel : BaseModel
    {
        public string CompanyName { get; set; }
        public string SloganName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string LabLogoPath { get; set; }
        public IFormFile LabLogo { get; set; }
        public List<CompanyModel> CompanyList { get; set; }
    }
}
