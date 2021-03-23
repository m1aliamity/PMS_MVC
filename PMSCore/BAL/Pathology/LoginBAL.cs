using BAL.Pathology.Interface;
using DAL.Pathology.Interface;
using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Pathology
{
    public class LoginBAL : ILoginBAL
    {
        private readonly ILoginDAL _loginDAL;
        public LoginBAL(ILoginDAL loginDAL)
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
                    model.UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    model.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                    model.CID = Convert.ToInt32(dt.Rows[0]["CID"]);
                }
                //model.GenderList = (from DataRow row in dt.Rows
                //                    select new DropDownModel
                //                    {
                //                        Value = Convert.ToString(row["Id"]),
                //                        Text = Convert.ToString(row["Name"]),
                //                    }).ToList();
            }
        }
        public async Task UserOperations(UserModel model)
        {
            if (Isvalidate(model))
            {
                DataSet ds = await _loginDAL.UserOperations(model);
            }
        }
        public bool Isvalidate(UserModel model)
        {
            return true;
        }

    }
}
