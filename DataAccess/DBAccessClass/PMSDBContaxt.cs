using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DBAccessClass
{
    public static class PMSDBContaxt
    {
        static Database _constring;
        private static DataSet _ds;
        static PMSDBContaxt()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            _constring = factory.Create("ConnString");
        }
        public static DataSet ExecuteQuery(string spName, object[] paramvalue)
        {
           return _ds = _constring.ExecuteDataSet(spName, paramvalue);
        }
    }
}