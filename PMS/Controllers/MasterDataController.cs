using Models.ModelClasses;
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
        public JsonResult MasterTypeData(MasterModel model)
        {
            //model.Action = "G";
            model.CID = 1;
            _masterRepository.MasterData(model);
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SaveMaster(MasterModel model)
        {
            model.Action = "I";
            model.CID = 1;
            _masterRepository.MasterData(model);
            return View();
        }
    }
}