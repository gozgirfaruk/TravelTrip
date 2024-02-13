using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        TravelContext db = new TravelContext();
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Hakkimizdas.ToList();

            return View(values);
        }

        public ActionResult AboutList()
        {
            var values = db.Hakkimizdas.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult BringAbout(int id)
        {
            var values = db.Hakkimizdas.Find(id);
            return View("BringAbout",values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(Hakkimizda p)
        {
            var values = db.Hakkimizdas.Find(p.ID);
            values.ImageUrl = p.ImageUrl;
            values.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}