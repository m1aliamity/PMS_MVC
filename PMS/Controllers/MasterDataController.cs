using Models.ModelClasses;
using PMS.Keys;
using PMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MasterDataController : Controller
    {
        private readonly IMasterRepository _masterRepository = null;
        public MasterDataController(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        // GET: MasterData
        public ActionResult Master(MasterModel model)
        {
            _masterRepository.GetMaster(model);
            return View(model);
        }
        [HttpPost]
        public JsonResult MasterDataList(MasterModel model)
        {
            model.CID = 1;
            _masterRepository.MasterData(model);
            if (model.MessageId == 1)
            {
                ViewBag.AlertType = Convert.ToString(AlertType.WARNING);
                ViewBag.AlertMessage = model.MessageText;
            }
            else
            { if (model.Action == "I")
                {
                    ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.SavedMessage;
                }
                else if (model.Action == "U")
                {
                    ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.UpdateMessage;
                }
                else if (model.Action == "D")
                {
                    ViewBag.AlertType = Convert.ToString(AlertType.SUCCESS);
                    model.MessageId = 1;
                    model.MessageText = Resource.ErrorMessage.DeleteMessage;
                }

            }
            return Json(model,JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //public ActionResult MasterDataList(MasterModel model)
        //{
        //     model.CID = 1;
        //    _masterRepository.MasterData(model);
        //    if (model.Action == "E")
        //    {
        //        return View("Master",model);
        //    }
        //    return PartialView("MasterDataList", model);
        //}
    }
}