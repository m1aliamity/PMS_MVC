using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;

namespace PMS.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository, IWebHostEnvironment hostEnvironment)
        {
            _companyRepository = companyRepository;
            _WebHostEnvironment = hostEnvironment;
        }
        public IActionResult Company(CompanyModel model)
        {
            model.Action = "S";
            _companyRepository.CompanyOperations(model);
            return View(model);
        }
        public IActionResult AddCompany(CompanyModel model)
        {
            return PartialView("AddCompany", model);
        }
        [HttpPost]
        public async Task<JsonResult> CompanyOperatons(CompanyModel model)
        {
            await _companyRepository.CompanyOperations(model);
            return Json(model);
        }
        private string UploadedFile(CompanyModel model)
        {
            string uniqueFileName = null;

            if (model.LabLogo != null)
            {
                string uploadsFolder = Path.Combine(_WebHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.LabLogo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.LabLogo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
