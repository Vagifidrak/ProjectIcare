using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using İcarePlatform.Models;
using İcarePlatform.ViewModels;

namespace İcarePlatform.Areas.AdminIcarePlatform.Controllers
{
    public class AdminContactMeController : Controller
    {
        private IcareDBContext db = new IcareDBContext();

        // GET: AdminIcarePlatform/AdminContactMe
        public ActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.ContactMe = db.ContactMes.First();
            return View(vm);
        }

        // GET: AdminIcarePlatform/AdminContactMe/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMes.Find(id);
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            return View(contactMe);
        }

        // GET: AdminIcarePlatform/AdminContactMe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminIcarePlatform/AdminContactMe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Office,Number,Email,ImgUrl,ImgIcon")] ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                db.ContactMes.Add(contactMe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactMe);
        }

        // GET: AdminIcarePlatform/AdminContactMe/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMes.Find(id);
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            return View(contactMe);
        }

        // POST: AdminIcarePlatform/AdminContactMe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Office,Number,Email,ImgUrl,ImgIcon")] ContactMe contactMe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactMe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactMe);
        }

        // GET: AdminIcarePlatform/AdminContactMe/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactMe contactMe = db.ContactMes.Find(id);
            if (contactMe == null)
            {
                return HttpNotFound();
            }
            return View(contactMe);
        }

        // POST: AdminIcarePlatform/AdminContactMe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactMe contactMe = db.ContactMes.Find(id);
            db.ContactMes.Remove(contactMe);
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
