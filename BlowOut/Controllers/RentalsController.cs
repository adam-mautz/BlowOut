using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Rental(string name, int newPrice, int usedPrice)
        {
            ViewBag.Instrument = name;
            ViewBag.Used = usedPrice;
            ViewBag.New = newPrice;
            return View();
        }
    }
}