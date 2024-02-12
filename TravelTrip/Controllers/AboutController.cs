using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;

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


    }
}