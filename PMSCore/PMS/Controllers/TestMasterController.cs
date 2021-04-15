using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PMS.Controllers
{
    public class TestMasterController : Controller
    {
        public IActionResult TestMaster()
        {
            return View();
        }
    }
}
