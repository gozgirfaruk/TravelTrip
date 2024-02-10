using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelContext db = new TravelContext();
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }

        public ActionResult BlogDetail(int id)
        {
            return View();
        }

    }
}