using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class UserController : Controller
    {

        private readonly ILoginRepository _loginRepository;
        public UserController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(UserModel model)
        {
            _loginRepository.ValidateUser(model);
            if (model.MessageId == 0)
            {
                HttpContext.Session.SetInt32("UserId", model.UserId);
                HttpContext.Session.SetString("UserName", model.UserName);
                HttpContext.Session.SetInt32("CID", model.CID);
                ViewBag.Id = HttpContext.Session.GetInt32("UserId");
                ViewBag.Name = HttpContext.Session.GetString("UserName");
                ViewBag.Age = HttpContext.Session.GetInt32("CID");
                return RedirectToRoute(new { action = "MainScreen", controller = "MainScreen", area = "" });
            }
            return View("UserLogin");
        }
        public IActionResult Users()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUser(UserModel model)
        {
            return View();
        }
    }
}
