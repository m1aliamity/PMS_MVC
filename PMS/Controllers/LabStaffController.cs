using Models.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LabStaffController : Controller
    {
        // GET: LabStaff
        public ActionResult LabStaff(LabStaffModel model)
        {
            return View();
        }
    }
}