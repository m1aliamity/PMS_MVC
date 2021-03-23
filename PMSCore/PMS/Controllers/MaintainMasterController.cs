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
        public MaintainMasterController(IMaintainMasterRepository maintainMasterRepository)
        {
            _maintainMasterRepository = maintainMasterRepository;
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
    }
}
