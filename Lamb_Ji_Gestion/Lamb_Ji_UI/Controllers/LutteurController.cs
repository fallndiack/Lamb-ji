using Lamb_Ji_DAL;
using Lamb_Ji_ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lamb_Ji_UI.Controllers
{
    public class LutteurController : Controller
    {
        CNGLUTTEDBEntities db = new CNGLUTTEDBEntities();

        public ActionResult Index()
        {

            return View();
        }

        public JsonResult GetLutteurList()
        {

            List<LutteurViewModel> LutList = db.Lutteurs.Select(x => new LutteurViewModel
            {

                LutteurID = x.LutteurID,
                LutteurName = x.LutteurName,
                LutteurAddresse = x.LutteurAddresse,
                LutteurEmail = x.LutteurEmail,
                LutteurDateNaissance = x.LutteurDateNaissance,
                LutteurDescription = x.LutteurDescription,
                LutteurPoids = x.LutteurPoids,
                LutteurTelephone = x.LutteurTelephone,
                ClubName = x.Club.ClubName,
                imageUrl = x.imageUrl
            }).ToList();

            return Json(LutList, JsonRequestBehavior.AllowGet);

        }

    }
}