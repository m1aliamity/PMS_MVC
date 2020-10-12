using Models.ModelClasses;
using PMS.Keys;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private readonly IUserRepository _userRepository = null;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            model.Action = "I";
            _userRepository.GetLoginDetails(model);
            if(model.MessageId==0)
            {
                Session["UserId"] = model.UserId;
                Session["UserName"] = model.UserName;
                Session["UserType"] = model.UserType;
                Session["CID"] = model.CID;
                //if (model.Rememberme==true)
                //{
                //    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(1);
                //    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(1);
                //    Response.Cookies["Rememberme"].Expires = DateTime.Now.AddDays(1);
                //}
                //else
                //{
                //    Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
                //    Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                //    Response.Cookies["Rememberme"].Expires = DateTime.Now.AddDays(-1);
                //}
               return RedirectToAction("MainScreen", "MainScreen");
            }
            ViewBag.AlertType = Convert.ToString(AlertType.WARNING);
            ViewBag.AlertMessage = model.MessageText;
            return View();
        }
        public ActionResult Logout(UserModel model)
        {
            //ViewBag.VersionNo = ConfigSettings.ApplicationVersion;
           // ViewBag.MyHclUrl = ConfigSettings.MyHCLPath;
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            return RedirectToAction("Login", "User");
        }
    }
}