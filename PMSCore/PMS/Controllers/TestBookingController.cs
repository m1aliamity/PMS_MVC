using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Keys;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class TestBookingController : Controller
    {
        private readonly ITestBookingRepository _testBookingRepository;
        public TestBookingController(ITestBookingRepository testBookingRepository)
        {
            _testBookingRepository = testBookingRepository;
        }
        public IActionResult TestBooking(TestBookingModel model)
        {
            _testBookingRepository.GetMasterData(model);
            return View(model);
        }
        public async Task<JsonResult> GetTestHeadMaster(TestBookingModel model)
        {
            await _testBookingRepository.GetTestHeadMaster(model);
            return Json(model);
        }
        public async Task<JsonResult> GetTest(TestBookingModel model)
        {
            await _testBookingRepository.GetTest(model);
            return Json(model);
        }
        [HttpPost]
        public async Task<JsonResult> AddData(TestBookingModel model)
        {
            await _testBookingRepository.AddData(model);
            return Json(model);
        }
        public async Task<JsonResult> TestBookingOperations(TestBookingModel model)
        {
            await _testBookingRepository.TestBookingOperations(model);
            return Json(model);
        }
    }
}
