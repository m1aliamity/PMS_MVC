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
    }
}
