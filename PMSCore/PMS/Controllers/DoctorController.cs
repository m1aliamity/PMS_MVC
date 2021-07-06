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
        public async Task<IActionResult> Doctor(DoctorModel model)
        {
            await _doctorRepository.GetMasterData(model);
            await _doctorRepository.GetDoctorList(model);
            return View(model);
        }
        public async Task<IActionResult> AddDoctor(DoctorModel model)
        {
            await _doctorRepository.GetMasterData(model);
            //return View(model);
            return PartialView("AddDoctor", model);
        }
        [HttpPost]
        public async Task<IActionResult> DoctorOperations(DoctorModel model)
        {
            await _doctorRepository.DoctorOperations(model);
            return Json(model);
        }
    }
}
