using System;
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
            _labStaffRepository.GetDeleteLabStaff(model);
            return View(model);
        }
        public async Task<IActionResult> DisplayStaffForm(long Id, LabStaffModel model)
        {
            if (Id == 0)
            {
                await _labStaffRepository.GetMasterData(model);
            }
            else
            {
                await _labStaffRepository.GetMasterData(model);
                model.Action = "E";
                model.RowId = Id;
                await _labStaffRepository.GetDeleteLabStaff(model);
            }
            return PartialView("AddStaff", model);
        }
        public async Task<IActionResult> DeleteStaffData(LabStaffModel model)
        {
            if (model.RowId != 0)
            {
                await _labStaffRepository.GetDeleteLabStaff(model);
                return Json(new { MessageId = model.MessageId, MessageText = model.MessageText, Result = "D", Url = Url.Action("Staff", "LabStaff") });
            }
            else
            {
                return Json(new { MessageId = 1, MessageText = "Data Not Found Please Try Again.", Result = "Error" });
            }

        }
        [HttpPost]
        public async Task<IActionResult> AddUpdateLabStaff(LabStaffModel model)
        {
            if (model.RowId!= 0)
            {
                model.Action = "U";
                await _labStaffRepository.AddUpdate(model);
                return Json(new { MessageId = model.MessageId, MessageText = model.MessageText, Result = "U", Url = Url.Action("Staff", "LabStaff") });
            }
            else
            {
                model.Action = "I";
                await _labStaffRepository.AddUpdate(model);
                return Json(new { MessageId = model.MessageId, MessageText = model.MessageText, Result = "I" });
            }
        }
    }
}
