using DataAccess.Interface;
using Models.ModelClasses;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PMS.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly IUserDAL _userDAL = null;
        DataSet _ds;
        public UserRepository(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void GetLoginDetails(UserModel model)
        {
            if (string.IsNullOrEmpty(model.UserName) && string.IsNullOrWhiteSpace(model.UserName))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.UserName;
            }
            else if (string.IsNullOrEmpty(model.Password) && string.IsNullOrWhiteSpace(model.Password))
            {
                model.MessageId = 1;
                model.MessageText = Resource.ErrorMessage.Password;
            }
            if (model.MessageId == 0)
            {
                _ds = _userDAL.GetLoginDetails(model);
                if (_ds.Tables[0].Rows.Count > 0)
                {
                    model.UserId = Convert.ToInt64(_ds.Tables[0].Rows[0]["Id"]);
                    model.UserName = Convert.ToString(_ds.Tables[0].Rows[0]["UserName"]);
                    model.UserType = Convert.ToInt64(_ds.Tables[0].Rows[0]["UserType"]);
                    model.CID = Convert.ToInt64(_ds.Tables[0].Rows[0]["CID"]);
                }
                else
                {
                    model.MessageId = 1;
                    model.MessageText = model.MessageText = Resource.ErrorMessage.ValidUserNamePassword;
                }
                //model.UserList= (from DataRow row in _ds.Tables[0].Rows
                //                                                select new UserModel
                //                                                {
                //                                                    UserName = Convert.ToString(row["UserName"]),
                //                                                    UserId = Convert.ToInt64(row["Id"]),
                //                                                    CID = Convert.ToInt64(row["CID"]),
                //                                                }MasterModel
            }
            else
            {
                model.MessageId = 1;
                model.MessageText = "Something went wrong";
            }
        }
    }
}