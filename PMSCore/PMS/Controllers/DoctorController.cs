using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public IActionResult Doctor(DoctorModel model)
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> DoctorOperatons(DoctorModel model)
        {
            await _doctorRepository.DoctorOperations(model);
            return Json(model);
            //return View("Hello");
        }
    }
}
