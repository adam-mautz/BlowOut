using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Contact = "Please call Support at <b><u>801-555-1212</b></u>. Thank you!";
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            ViewBag.Email = "Thank you " + name + ". We will send an email to " + email;

            return View();
        }
    }
}