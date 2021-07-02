using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Controllers
{
    public class FillTestResultsController : Controller
    {
        private readonly ITestBookingRepository _testBookingRepository;
        public FillTestResultsController(ITestBookingRepository testBookingRepository)
        {
            _testBookingRepository = testBookingRepository;
        }
        public IActionResult BookingDetails(TestBookingModel model)
        {
            return View(model);
        }
        [HttpPost]
        public async Task<JsonResult> SearchBookingData(TestBookingModel model)
        {
            await _testBookingRepository.SearchBookingData(model);
            return Json(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetTestDetails(TestBookingModel model)
        {
            await _testBookingRepository.SearchBookingData(model);
            if (model.Action == "3")
            {  
            return PartialView("AdvanceFillResults", model);
            }
            else
            {
              return PartialView("FillResults", model);
            }
        }
        [HttpPost]
        public async Task<JsonResult> SaveTestResult(TestBookingModel model)
        {
            await _testBookingRepository.SaveTestResult(model);
            return Json(model);
        }
    }
}
