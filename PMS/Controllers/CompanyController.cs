using Models.ModelClasses;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Keys;
namespace PMS.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository = null;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        // GET: Company
        public ActionResult CompanyList(CompanyModel model)
        {
            model.Action = "S";
            _companyRepository.Company(model);
            return View(model.CompanyList);
        }
        // GET: Company/Create
        public ActionResult Company()
        {
            return View();
        }
        // POST: Company/Create
        [HttpPost]
        public ActionResult Company(CompanyModel model)
        {
            model.IsActive = true;
            model.Action = "I";
            _companyRepository.Company(model);
            if (model.MessageId == 1)
            {
                ViewBag.AlertType = Convert.ToString(AlertType.WARNING);
                ViewBag.AlertMessage = model.MessageText;
            }
            else
            {
                ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                ViewBag.AlertMessage = Resource.ErrorMessage.SavedMessage;
                ModelState.Clear();
            }
            return View();
        }
        // GET: Company/Edit/
        public ActionResult UpdateCompany(CompanyModel model,int id)
        {
            model.Action = "G";
            model.Id = id;
            _companyRepository.Company(model);
            return View("Company",model);
        }
        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult UpdateCompany(int id, CompanyModel model)
        {
            model.Action = "U";
            model.Id = id;
            _companyRepository.Company(model);
            if (model.MessageId == 1)
            {
                ViewBag.AlertType = Convert.ToString(AlertType.WARNING);
                ViewBag.AlertMessage = model.MessageText;
                return View();
            }
            else
            {
                model.Action = "S";
                _companyRepository.Company(model);
                ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                ViewBag.AlertMessage = Resource.ErrorMessage.UpdateMessage;
            }
            return View("CompanyList", model.CompanyList);
        }
        public ActionResult DeactivateCompany(int id, CompanyModel model)
        {
            model.Action = "D";
            model.Id = id;
            _companyRepository.Company(model);
            if (model.MessageId == 1)
            {
                ViewBag.AlertType = Convert.ToString(AlertType.WARNING);
                ViewBag.AlertMessage = model.MessageText;
            }
            else
            {
                model.Action = "S";
                _companyRepository.Company(model);
                ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                ViewBag.AlertMessage = Resource.ErrorMessage.DeleteMessage;
            }
            return View("CompanyList", model.CompanyList);
        }
    }
}
