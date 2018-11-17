using Lamb_Ji_DAL;
using Lamb_Ji_ViewModel;
using Newtonsoft.Json;
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
            List<Club> LutList = db.Clubs.ToList();
            ViewBag.ListOfLutteur = new SelectList(LutList, "ClubID", "ClubName");

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

        public JsonResult GetLutteurById(int LutteurID)
        {
            Lutteur model = db.Lutteurs.Where(x => x.LutteurID == LutteurID).FirstOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveDataInDatabase(LutteurViewModel model)
        {
            var result = false;
            try
            {
                if (model.LutteurID > 0)
                {
                    Lutteur Lut = db.Lutteurs.SingleOrDefault(x => x.LutteurID == model.LutteurID);
                    Lut.LutteurName = model.LutteurName;
                    Lut.LutteurEmail = model.LutteurEmail;
                    Lut.LutteurDateNaissance = model.LutteurDateNaissance;
                    Lut.LutteurDescription = model.LutteurDescription;
                    Lut.LutteurPoids = model.LutteurPoids;
                    Lut.LutteurTelephone = model.LutteurTelephone;
                    Lut.LutteurAddresse = model.LutteurAddresse;
                    Lut.imageUrl = model.imageUrl;
                    Lut.LutteurClubID = model.LutteurClubID;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    Lutteur Lut = new Lutteur();
                    Lut.LutteurName = model.LutteurName;
                    Lut.LutteurEmail = model.LutteurEmail;
                    Lut.LutteurDateNaissance = model.LutteurDateNaissance;
                    Lut.LutteurDescription = model.LutteurDescription;
                    Lut.LutteurPoids = model.LutteurPoids;
                    Lut.LutteurTelephone = model.LutteurTelephone;
                    Lut.LutteurAddresse = model.LutteurAddresse;
                    Lut.imageUrl = model.imageUrl;
                    Lut.LutteurClubID = model.LutteurClubID;
                    db.Lutteurs.Add(Lut);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Json(result, JsonRequestBehavior.AllowGet);

        }

        public JsonResult DeleteLutteurRecord(int LutteurID)
        {
            bool result = false;
            Licence lic = db.Licences.SingleOrDefault(a => a.LutteurID == LutteurID);
            Lutteur Lut = db.Lutteurs.SingleOrDefault(x => x.LutteurID == LutteurID);
            if (Lut != null)
            {
                if (lic != null)
                {
                    db.Licences.Remove(lic);
                    db.Lutteurs.Remove(Lut);
                    db.SaveChanges();
                    result = true;
                }
               
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}