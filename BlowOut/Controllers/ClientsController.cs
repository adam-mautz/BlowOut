﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAl;
using BlowOut.Models;

namespace BlowOut.Controllers
{
    public class ClientsController : Controller
    {
        public static List<Instrument> lstIns = new List<Instrument>();

        // GET: Clients
        public ActionResult Index()
        {
            return View(db.client.ToList());
        }


        // POST METHOD FOR CLIENTS. ADDS CLIENT RECORD AND UPDATES ISNTRUMENT

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,First_Name,Last_Name,address,city,state,zip,email,phone")] Client client, int ID)
        {
            if (ModelState.IsValid)
            {
                db.client.Add(client);
                db.SaveChanges();

                //UPDATES CUSTOMER_id ON INSTRUMENT RECORD
                Instrument instrument = db.instrument.Find(ID);
                instrument.Client_ID = client.Id;
                db.SaveChanges();

                return RedirectToAction("Summary", new { iID = instrument.Id, cID = client.Id });
            }

            return View(client);
        }

        //METHOD TO DISPLAY ORDER CONFIRMATION INFORMATION 
        public ActionResult Summary(int iID, int cID)
        {
            //LOAD VIEWBAG WITH CORRECT INFO
            ViewBag.Name = db.client.Find(cID).First_Name;
            ViewBag.ID = db.client.Find(cID).Id;
            ViewBag.Instrument = db.instrument.Find(iID).Description;
            ViewBag.Type = db.instrument.Find(iID).Type;
            ViewBag.Price = db.instrument.Find(iID).Price;
            ViewBag.Total = db.instrument.Find(iID).Price * 18;

            //LOGIC TO DISPLAY CORRECT PICTURE
            if (db.instrument.Find(iID).Description == "Trumpet")
            {
                ViewBag.Image = "BT2S_0512-min_1024x1024.jpg";
            }
            else if (db.instrument.Find(iID).Description == "Trombone")
            {
                ViewBag.Image = "Trombone.jpg";
            }
            else if (db.instrument.Find(iID).Description == "Flute")
            {
                ViewBag.Image = "Flute.jpg";
            }
            else if (db.instrument.Find(iID).Description == "Saxaphone")
            {
                ViewBag.Image = "Sax.jpg";
            }
            else if (db.instrument.Find(iID).Description == "Clarinet")
            {
                ViewBag.Image = "calrinet.jpg";
            }
            else if (db.instrument.Find(iID).Description == "Tuba")
            {
                ViewBag.Image = "Tuba.jpg";
            }


            return View();
        }


        [HttpGet]
        public ActionResult InstrumentsAndClients()
        {
            return View(db.client.ToList());
        }



        /////////////// SCAFFOLDING CREATED ALL CODE BELOW


        public ActionResult Create(int ID)
        {

            return View();
        }

        private ClientInstrumentContext db = new ClientInstrumentContext();



        // GET: Clients/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }


        // GET: Clients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, First_Name, Last_Name,address,city,state,zip,email,phone")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ClientInstrument","Instruments");
            }
            return View(client);
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.client.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Client client = db.client.Find(id);
            db.client.Remove(client);
            db.SaveChanges();

            //deletes the Client that has been deleted from the instrument's Client_ID field
            db.Database.ExecuteSqlCommand(
                "UPDATE Instrument " +
                "SET Client_ID = null " +
                "WHERE Client_ID = '" + id + "'");

            return RedirectToAction("ClientInstrument","Instruments");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
