using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using İcarePlatform.Models;

namespace İcarePlatform.Areas.AdminIcarePlatform.Controllers
{
    public class AdminAboutUsController : Controller
    {
        private IcareDBContext db = new IcareDBContext();

        // GET: AdminIcarePlatform/AdminAboutUs
        public ActionResult Index()
        {
            return View(db.AboutUs.ToList());
        }

        // GET: AdminIcarePlatform/AdminAboutUs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutU aboutU = db.AboutUs.Find(id);
            if (aboutU == null)
            {
                return HttpNotFound();
            }
            return View(aboutU);
        }

        // GET: AdminIcarePlatform/AdminAboutUs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminIcarePlatform/AdminAboutUs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Id,description,UrlImg,header,Icon")] AboutU aboutU)
        {
            if (ModelState.IsValid)
            {
                db.AboutUs.Add(aboutU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aboutU);
        }

        // GET: AdminIcarePlatform/AdminAboutUs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutU aboutU = db.AboutUs.Find(id);
            if (aboutU == null)
            {
                return HttpNotFound();
            }
            return View(aboutU);
        }

        // POST: AdminIcarePlatform/AdminAboutUs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]

        public ActionResult Edit([Bind(Include = "Id,description,UrlImg,header,Icon")] AboutU aboutU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aboutU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aboutU);
        }

        // GET: AdminIcarePlatform/AdminAboutUs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AboutU aboutU = db.AboutUs.Find(id);
            if (aboutU == null)
            {
                return HttpNotFound();
            }
            return View(aboutU);
        }

        // POST: AdminIcarePlatform/AdminAboutUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AboutU aboutU = db.AboutUs.Find(id);
            db.AboutUs.Remove(aboutU);
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
