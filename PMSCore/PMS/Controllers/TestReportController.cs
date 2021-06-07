using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class TestReportController : Controller
    {
        public IActionResult TestReport()
        {
            return View();
        }
    }
}
