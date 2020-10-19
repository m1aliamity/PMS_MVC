using Models.ModelClasses;
using PMS.Repository.Interface;
using System.Web.Mvc;
namespace PMS.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository = null;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        // GET: Company/Create
        public ActionResult Company()
        {
            return View();
        }
        // POST: Company/Create
        [HttpPost]
        public JsonResult CompanyOperations(CompanyModel model)
        {
            model.CID = 1;
            _companyRepository.Company(model);
            if (model.MessageId != 1)
            {
                if (model.Action == "I")
                {
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.SavedMessage;
                }
                else if (model.Action == "U")
                {
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.UpdateMessage;
                }
                else if (model.Action == "D")
                {
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.DeleteMessage;
                }
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}
