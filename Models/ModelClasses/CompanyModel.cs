using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class CompanyModel :BaseModel
    {
        public string CompanyName { get; set; }
        public string StreetAddress { get; set; }
        public string SloganName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public bool ShowDetail { get; set; }
        public string Logo { get; set; }
        public List<CompanyModel> CompanyList { get; set; }
    }
}
