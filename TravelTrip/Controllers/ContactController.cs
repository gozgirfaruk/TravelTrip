using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;
using TravelTrip.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace TravelTrip.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        TravelContext db = new TravelContext();
        [HttpGet]
        public ActionResult PageContact()
        {
            return View();
        }
     
      
        [HttpPost]
        public ActionResult SendMessage(Iletisim p)
        {
            var values = db.Iletisims.Add(p);
            db.SaveChanges();
            return RedirectToAction("PageContact");
        }


        public ActionResult AdminIletisim(int sayfa=1)
        {
            //var values = db.Iletisims.ToList();
            var values = db.Iletisims.ToList().ToPagedList(sayfa, 5);
            return View(values);
        }

        public ActionResult DeleteContact(int id)
        {
            var values = db.Iletisims.Find(id);
            db.Iletisims.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

     
    }
}