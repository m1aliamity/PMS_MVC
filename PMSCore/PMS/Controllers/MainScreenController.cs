using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class MainScreenController : Controller
    {
        public IActionResult MainScreen()
        {
            return View();
        }
    }
}
