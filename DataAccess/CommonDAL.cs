using DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Models.ModelClasses;
using DataAccess.DBAccessClass;

namespace DataAccess
{
    public class CommonDAL: ICommonDAL
    {
        public DataSet GetMasterData(string masterId)
        {
            object[] _parameterValues = { masterId };
            return PMSDBContaxt.ExecuteQuery("SP_GetMasterdata", _parameterValues);
        }
    }
}
