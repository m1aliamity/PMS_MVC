﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class LabStaffController : Controller
    {
        private readonly ILabStaffRepository _labStaffRepository;
        public LabStaffController(ILabStaffRepository labStaffRepository)
        {
            _labStaffRepository = labStaffRepository;
        }
        public IActionResult Staff(LabStaffModel model)
        {
            model.Action = "S";
            model.DOB = DateTime.Now;
            _labStaffRepository.LabStaffOperations(model);
            return View(model);
        }
        public async Task<IActionResult> AddStaff(LabStaffModel model)
        {
            await _labStaffRepository.GetMasterData(model);
            return PartialView("AddStaff", model);
        }
        [HttpPost]
        public async Task<JsonResult> CompanyOperatons(LabStaffModel model)
        {
            await _labStaffRepository.LabStaffOperations(model);
            return Json(model);
            //return View("Hello");
        }
    }
}
