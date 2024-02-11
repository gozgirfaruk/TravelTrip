using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;

namespace TravelTrip.Controllers
{
    public class HomeController : Controller
    {
        TravelContext db = new TravelContext();
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            
            return View(values);
        }

        public PartialViewResult PartialThisWeek()
        {
            var values = db.Blogs.ToList();
            return PartialView(values);
        }


    }
}