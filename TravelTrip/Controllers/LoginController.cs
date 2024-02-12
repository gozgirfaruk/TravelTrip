using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Context;
using TravelTrip.Models.Siniflar;
using System.Web.Security;

namespace TravelTrip.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        TravelContext db = new TravelContext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin p)
        {
            var value = db.Admins.FirstOrDefault(x => x.Users == p.Users && x.Password == p.Password);

            if(value !=null)
            {
                FormsAuthentication.SetAuthCookie(value.Users, false);
                Session["Users"] = value.Users.ToString();
                return RedirectToAction("Index","Admin");
            }

            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}