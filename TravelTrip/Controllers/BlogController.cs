using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        TravelContext db = new TravelContext();
        BlogYorum blogYorum = new BlogYorum();
        [Authorize]
        public ActionResult Index()
        {
            //var values = db.Blogs.ToList();
            blogYorum.deger1 = db.Blogs.ToList();
            blogYorum.deger3 = db.Blogs.OrderByDescending(x => x.Year).Take(3).ToList();
            return View(blogYorum);
        }
        [Authorize]
        public ActionResult BlogDetail(int id)
        {

            // var blogbul = db.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.deger1 = db.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.deger2 = db.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }
        [Authorize]
        public PartialViewResult partialComment()
        {
            var cmment = db.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(cmment);
        }

        [Authorize]
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [Authorize]
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar yorum)
        {
            db.Yorumlars.Add(yorum);
            db.SaveChanges();
            return PartialView();

        }
        [Authorize]
        public ActionResult YorumYap(Blog b)
        {
            db.Blogs.Add(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}