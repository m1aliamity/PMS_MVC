using DataAccess.DBAccessClass;
using DataAccess.Interface;
using Models.ModelClasses;
using System.Data;

namespace DataAccess
{
    public class MasterDAL: IMasterDAL
    {
        public DataSet GetMaster(MasterModel model)
        {
            object[] _parameterValues = { };
            return PMSDBContaxt.ExecuteQuery("SP_GetMaster", _parameterValues);
        }
        public DataSet MasterData(MasterModel model)
        {
            object[] _parameterValues = { model.Id, model.MID, model.Name, model.Rate, model.PrintName, model.IsActive, model.CID, model.UserId, model.Action };
            return PMSDBContaxt.ExecuteQuery("SP_MasterDetails", _parameterValues);
        }
    }
}
