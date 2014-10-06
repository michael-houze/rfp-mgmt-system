using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rfp_mgmt_system.Models;

namespace rfp_mgmt_system.Controllers
{
    public class VendorRegistrationController : Controller
    {
        private BaptistHealthEntities db = new BaptistHealthEntities();

        // GET: VendorRegistration
        public ActionResult Index()
        {
            var vENDORs = db.VENDORs.Include(v => v.VENDOR_LOGIN);
            return View(vENDORs.ToList());
        }

        // GET: VendorRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORs.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDOR);
        }

        // GET: VendorRegistration/Create
        public ActionResult Create()
        {
            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username");
            return View();
        }

        // POST: VendorRegistration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Vendor_ID,VendorFirstName,VendorLastName,VendorPhone,VendorEmail,CompanyName,Street,City,State,Zip")] VENDOR vendor)
        {

            if (ModelState.IsValid)
            {
                vendor.Sanctioned = "0";
                db.VENDORs.Add(vendor);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username", vendor.Vendor_ID);
            return View(vendor);
        }

        // GET: VendorRegistration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORs.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username", vENDOR.Vendor_ID);
            return View(vENDOR);
        }

        // POST: VendorRegistration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Vendor_ID,VendorFirstName,VendorLastName,VendorPhone,VendorEmail,CompanyName,Street,City,State,Zip,Sanctioned")] VENDOR vENDOR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vENDOR).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username", vENDOR.Vendor_ID);
            return View(vENDOR);
        }

        // GET: VendorRegistration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vENDOR = db.VENDORs.Find(id);
            if (vENDOR == null)
            {
                return HttpNotFound();
            }
            return View(vENDOR);
        }

        // POST: VendorRegistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VENDOR vENDOR = db.VENDORs.Find(id);
            db.VENDORs.Remove(vENDOR);
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
