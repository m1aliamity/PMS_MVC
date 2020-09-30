using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ModelClasses
{
    public class BaseModel: DropdownModel
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public int MessageId { get; set; }
        public string AlertType { get; set; }
        public string AlertMessage { get; set; }
        public string MessageText { get; set; }
        public long UserId { get; set; }
        public long UserType { get; set; }
        public long StafId { get; set; }
        public long CID { get; set; }
        public string Action { get; set; }
    }
}
