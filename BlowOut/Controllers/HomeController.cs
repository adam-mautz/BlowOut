//ADAM MAUTZ, AMBER HEWITT, MATTHEW BROWN, MCKAY BRYSON --- NOV 21 2019
//ADDED ENTITY FRAMEFORK FUNCTIONALITY TO CHECKPOINT 3
//USER CAN NOW SELECT AND INSTRUMENT LINKED TO A RELATED TABLE, ADD CLIENT INFORMATION AND SAVE IT TO A CLIENT TABLE. PRINT CONFIRMATION INFO

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 

namespace BlowOut.Controllers
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
    }
}