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
        public JsonResult MasterDetailsOperations(MasterModel model)
        {
            model.CID = 1;
            _masterRepository.MasterData(model);
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