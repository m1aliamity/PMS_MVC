using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class ProfileMasterController : Controller
    {
        private readonly ITestMasterRepository _testMasterRepository;
        public ProfileMasterController(ITestMasterRepository testMasterRepository)
        {
            _testMasterRepository = testMasterRepository;
        }
        public IActionResult ProfileMaster(TestMasterModel model)
        {
            model.ProfileId = -1;
            _testMasterRepository.GetMasterData(model);
            return View(model);
        }
        public async Task<JsonResult> GetTestHeadMaster(TestMasterModel model)
        {
            await _testMasterRepository.GetTestHeadMaster(model);
            return Json(model);
        }
        [HttpPost]
        public async Task<JsonResult> GetTest(TestMasterModel model)
        {
            await _testMasterRepository.TestMasterOperations(model);
            return Json(model);
        }
        [HttpPost]
        public async Task<JsonResult> ProfileOperations(TestMasterModel model)
        {
            await _testMasterRepository.TestProfileOperations(model);
            return Json(model);
        }
    }
}
