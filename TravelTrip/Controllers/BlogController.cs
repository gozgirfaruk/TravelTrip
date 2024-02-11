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
        public ActionResult Index()
        {
            //var values = db.Blogs.ToList();
            blogYorum.deger1 = db.Blogs.ToList();
            blogYorum.deger3 = db.Blogs.Take(2).ToList();
            return View(blogYorum);
        }
       
        public ActionResult BlogDetail(int id)
        {

            // var blogbul = db.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.deger1 = db.Blogs.Where(x => x.ID == id).ToList();
            blogYorum.deger2 = db.Yorumlars.Where(x => x.BlogId == id).ToList();
            return View(blogYorum);
        }

    }
}