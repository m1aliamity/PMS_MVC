using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class TestMasterController : Controller
    {
        private readonly ITestMasterRepository _testMasterRepository;
        public TestMasterController(ITestMasterRepository testMasterRepository)
        {
            _testMasterRepository = testMasterRepository;
        }
        public IActionResult TestMaster(TestMasterModel model)
        {
            _testMasterRepository.GetMasterData(model);
            return View(model);
        }
        public async Task<JsonResult> GetTestHeadMaster(TestMasterModel model)
        {
            await _testMasterRepository.GetTestHeadMaster(model);
            return Json(model);
        }
        //public async Task<JsonResult> MaintainMasterOperation(TestMasterModel model)
        //{
        //    await _testMasterRepository.GetTestHeadMaster(model);
        //    return Json(model);
        //}
        public IActionResult AddTest(TestMasterModel model)
        {
            _testMasterRepository.GetMasterData(model);
            return PartialView("AddTest", model);
        }
        [HttpPost]
        public async Task<JsonResult> TestOperations(TestMasterModel model)
        {
            await _testMasterRepository.TestMasterOperations(model);
            return Json(model);
        }
    }
}
