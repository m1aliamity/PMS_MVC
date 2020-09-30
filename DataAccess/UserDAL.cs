using DataAccess.Interface;
using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DBAccessClass;

namespace DataAccess
{
    public class UserDAL:IUserDAL
    {
        public DataSet GetLoginDetails(UserModel model)
        {
            object[] _parameterValues = {model.UserName,model.Password, model.Action };
            return PMSDBContaxt.ExecuteQuery("SP_GetUser", _parameterValues);
        }
    }
}
