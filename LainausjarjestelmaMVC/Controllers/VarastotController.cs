﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LainausjarjestelmaMVC.Models;

namespace LainausjarjestelmaMVC.Controllers
{
    public class VarastotController : Controller
    {
        private LainausjarjestelmaEntities db = new LainausjarjestelmaEntities();

        // GET: Varastot
        public ActionResult Index()
        {
            return View(db.Varastot.ToList());
        }

        // GET: Varastot/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varastot varastot = db.Varastot.Find(id);
            if (varastot == null)
            {
                return HttpNotFound();
            }
            return View(varastot);
        }

        // GET: Varastot/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Varastot/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VarastoID,Varastopaikka,Numero")] Varastot varastot)
        {
            if (ModelState.IsValid)
            {
                db.Varastot.Add(varastot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(varastot);
        }

        // GET: Varastot/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varastot varastot = db.Varastot.Find(id);
            if (varastot == null)
            {
                return HttpNotFound();
            }
            return View(varastot);
        }

        // POST: Varastot/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VarastoID,Varastopaikka,Numero")] Varastot varastot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(varastot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(varastot);
        }

        // GET: Varastot/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Varastot varastot = db.Varastot.Find(id);
            if (varastot == null)
            {
                return HttpNotFound();
            }
            return View(varastot);
        }

        // POST: Varastot/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Varastot varastot = db.Varastot.Find(id);
            db.Varastot.Remove(varastot);
            db.SaveChanges();
            return RedirectToAction("Index");
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
