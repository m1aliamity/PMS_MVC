using DAL.Pathology.Interface;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Data;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ILoginDAL _loginDAL;
        public LoginRepository(ILoginDAL loginDAL)
        {
            _loginDAL = loginDAL;
        }
        public async Task ValidateUser(UserModel model)
        {
            if (Isvalidate(model))
            {
                DataTable dt = await _loginDAL.ValidateUser(model);
                if (dt.Rows.Count == 1)
                {
                    model.UserId = Convert.ToInt32(dt.Rows[0]["Id"]);
                    model.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                    model.CID = Convert.ToInt32(dt.Rows[0]["CID"]);
                }
                else 
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.InvalidUserPassword;
                }
            }
        }
        public async Task UserOperations(UserModel model)
        {
            DataSet ds = await _loginDAL.UserOperations(model);
        }
        public bool Isvalidate(UserModel model)
        {
            bool status = true;
            if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrWhiteSpace(model.UserName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.UserName;
                status = false;
            }
            else if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrWhiteSpace(model.UserName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.UserName;
                status = false;
            }
            return status;
        }

    }
}
