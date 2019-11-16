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
            if(name == "Trumpet")
            {
                ViewBag.Image = "BT2S_0512-min_1024x1024.jpg";
            }
            else if (name == "Trombone")
            {
                ViewBag.Image = "Trombone.jpg";
            }
            else if (name == "Flute")
            {
                ViewBag.Image = "Flute.jpg";
            }
            else if (name == "Saxaphone")
            {
                ViewBag.Image = "Sax.jpg";
            }
            else if (name == "Clarinet")
            {
                ViewBag.Image = "calrinet.jpg";
            }
            else if (name == "Tuba")
            {
                ViewBag.Image = "Tuba.jpg";
            }

            ViewBag.Instrument = name;
            ViewBag.Used = usedPrice;
            ViewBag.New = newPrice;
            return View();
        }
    }
}