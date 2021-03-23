using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Pathology
{
    public class UserModel : BaseModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int StaffId { get; set; }
        public int UserType { get; set; }
    }
}
