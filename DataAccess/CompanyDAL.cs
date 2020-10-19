using DataAccess.DBAccessClass;
using DataAccess.Interface;
using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CompanyDAL:ICompanyDAL
    {
        public DataSet Company(CompanyModel model)
        {
            object[] _parameterValues = { model.Id,model.CompanyName,model.StreetAddress,model.SloganName,model.PhoneNo,model.EmailId, model.WebSite,model.ShowDetail,model.IsActive,model.Logo, model.Action };
            return PMSDBContaxt.ExecuteQuery("SP_Company", _parameterValues);
        }
    }
}
