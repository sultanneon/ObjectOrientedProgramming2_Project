using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
     
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var db = new ShoppEntities();
            var t = (from s in db.Users
                            where s.Username == Username && s.Password == Password
                            select s).FirstOrDefault();
      
            if (t != null)
            {
                FormsAuthentication.SetAuthCookie(t.Username, true);
                return RedirectToAction("Index", "Customer",t);
            }
            return View();
        }

    }
}