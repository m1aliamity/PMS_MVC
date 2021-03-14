using Models.ModelClasses;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LabStaffController : Controller
    {
        // GET: LabStaff
        private readonly ILabStaffRepository _labStaffRepository = null;
        public LabStaffController(ILabStaffRepository labStaffRepository)
        {
            _labStaffRepository = labStaffRepository;
        }
        public ActionResult LabStaff(LabStaffModel model)
        {
            _labStaffRepository.BindMasterData(model);
            return View(model);
        }
        [HttpPost]
        public JsonResult LabStaffOperations(LabStaffModel model)
        {
            model.CID = 1;
            _labStaffRepository.LabStaff(model);
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