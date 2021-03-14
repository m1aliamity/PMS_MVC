using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class BaseModel : DropdownModel
    {
        public long Id { get; set; }
        public long Title { get; set; }
        public bool IsActive { get; set; }
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public long UserId { get; set; }
        public long UserType { get; set; }
        public long CID { get; set; }
        public string MobileNo { get; set; }
        public long Religion { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AnniversaryDate { get; set; }
        public long Gender { get; set; }
        public long MritalStatus { get; set; }
        public string SpauseName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Action { get; set; }
    }
}
