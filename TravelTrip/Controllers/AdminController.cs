using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;
using TravelTrip.Models.Siniflar;

namespace TravelTrip.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        TravelContext db = new TravelContext();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public PartialViewResult partialBlog()
        {
            var values = db.Blogs.ToList();
            return PartialView(values);
        }
        [Authorize]
        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult CreateBlog(Blog p)
        {
            var values = db.Blogs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult DeleteBlog(int id)
        {
            var values = db.Blogs.Find(id);
            db.Blogs.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult UpdateBlog(int id)
        {
            var values = db.Blogs.Find(id);
            return View("UpdateBlog", values);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog p)
        {
            var values = db.Blogs.Find(p.ID);
            values.Header = p.Header;
            values.Year = p.Year;
            values.Description = p.Description;
            values.ImageUrl = p.ImageUrl;
            values.Explanation = p.Explanation;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public PartialViewResult partialCommentList()
        {
            var values = db.Yorumlars.ToList();
            return PartialView(values);
        }
        [Authorize]
        public ActionResult DeleteComment(int id)
        {
            var values = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BringComment(int id)
        {
            var values = db.Yorumlars.Find(id);
            return View("BringComment", values);
        }
        [Authorize]
        public ActionResult UpdateComment(Yorumlar p)
        {
            var values = db.Yorumlars.Find(p.ID);
            values.UserName = p.UserName;
            values.Mail = p.Mail;
            values.Comment = p.Comment;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

   
    }
}