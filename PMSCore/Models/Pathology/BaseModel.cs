using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class BaseModel
    {
        public int UserId { get; set; }
        public long RowId { get; set; }
        public string MID { get; set; }
        public string Action { get; set; }
        public int CID { get; set; }
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public long Status { get; set; }
        public string StatusName { get; set; }
        public List<DropDownModel> StatusList { get; set; }

    }
}
