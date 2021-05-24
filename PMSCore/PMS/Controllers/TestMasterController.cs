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
            return View();
        }
        public IActionResult AddNewTest(TestMasterModel model)
        {
            return PartialView("AddNewTest", model);
        }
    }
}
