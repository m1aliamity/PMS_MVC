using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class MaintainMasterController : Controller
    {
        private readonly IMaintainMasterRepository _maintainMasterRepository;

        private readonly ICommonRepository _commonRepository;
        public MaintainMasterController(ICommonRepository commonRepository, IMaintainMasterRepository maintainMasterRepository)
        {
            _maintainMasterRepository = maintainMasterRepository;
            _commonRepository = commonRepository;
        }
        public async Task<IActionResult> MaintainMaster(MaintainMasterModel model)
        {
            await _maintainMasterRepository.GetMaster(model);
            return View(model);
        }
        [HttpPost]
        public async Task<JsonResult> MaintainMasterOperation(MaintainMasterModel model)
        {
            await _maintainMasterRepository.MasterDetailOperations(model);
            return Json(model);
        }
        public async Task<IActionResult> MaintainTestHead(MaintainMasterModel model)
        {
            await _maintainMasterRepository.GetPathologyDepartment(model);
            return View(model);
        }
        [HttpPost]
        public async Task<JsonResult> TestHeadOperation(MaintainMasterModel model)
        {
            await _maintainMasterRepository.TestHeadOperations(model);
            return Json(model);
        }
    }
}
