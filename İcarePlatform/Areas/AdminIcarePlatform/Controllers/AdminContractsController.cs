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
    public class AdminContractsController : Controller
    {
        private IcareDBContext db = new IcareDBContext();

        // GET: AdminIcarePlatform/AdminContracts
        public ActionResult Index()
        {
            var contracts = db.Contracts.Include(c => c.Estate);
            return View(contracts.ToList());
        }

        // GET: AdminIcarePlatform/AdminContracts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // GET: AdminIcarePlatform/AdminContracts/Create
        public ActionResult Create()
        {
            ViewBag.EstateId = new SelectList(db.Estates, "Id", "EstateCode");
            return View();
        }

        // POST: AdminIcarePlatform/AdminContracts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ContractType,ContractLink,EstateId,RentalId,ContractDeadline,SignContract,ModifiedOn,RentPrice")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Contracts.Add(contract);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstateId = new SelectList(db.Estates, "Id", "EstateCode", contract.EstateId);
            return View(contract);
        }

        // GET: AdminIcarePlatform/AdminContracts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstateId = new SelectList(db.Estates, "Id", "EstateCode", contract.EstateId);
            return View(contract);
        }

        // POST: AdminIcarePlatform/AdminContracts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ContractType,ContractLink,EstateId,RentalId,ContractDeadline,SignContract,ModifiedOn,RentPrice")] Contract contract)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contract).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstateId = new SelectList(db.Estates, "Id", "EstateCode", contract.EstateId);
            return View(contract);
        }

        // GET: AdminIcarePlatform/AdminContracts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contract contract = db.Contracts.Find(id);
            if (contract == null)
            {
                return HttpNotFound();
            }
            return View(contract);
        }

        // POST: AdminIcarePlatform/AdminContracts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contract contract = db.Contracts.Find(id);
            db.Contracts.Remove(contract);
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
