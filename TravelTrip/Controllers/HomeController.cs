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
        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();

            return View(values);
        }
        [Authorize]
        public PartialViewResult PartialThisWeek()
        {
            var values = db.Blogs.Take(8).ToList();
            return PartialView(values);
        }
        [Authorize]
        public PartialViewResult PartialOurBest()
        {
            var values = db.Blogs.Take(2).ToList();
            return PartialView(values);

        }
        [Authorize]
        public PartialViewResult PartialOurBestTwo()
        {
            var value = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(value);
        }
    }
}