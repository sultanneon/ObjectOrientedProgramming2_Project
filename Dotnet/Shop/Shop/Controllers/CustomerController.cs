using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class CustomerController : Controller
    {
       
      
        public ActionResult Profiles(int id)
        {
            var db = new ShoppEntities();
            var customer = (from s in db.Users
                            where s.UserID == id
                            select s).FirstOrDefault();
            return View(customer);
        }
        public ActionResult Edit(int Id)
        {
            var db = new ShoppEntities();
            var student = (from s in db.Users
                           where s.UserID == Id
                           select s).FirstOrDefault();

            return View(student);
        }
        [HttpPost]
        public ActionResult Edited(User st)
        {
            var db = new ShoppEntities();
            var student = (from s in db.Users
                           where s.UserID == st.UserID
                           select s).FirstOrDefault();
            db.Entry(student).CurrentValues.SetValues(st);
            db.SaveChanges();
            return RedirectToAction("Index","Customer",st);
        }

    }
}