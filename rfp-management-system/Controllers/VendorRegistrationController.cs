using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rfp_mgmt_system.Models;
using rfp_mgmt_system.Models.ViewModels;

namespace rfp_mgmt_system.Controllers
{
    public class VendorRegistrationController : Controller
    {
        private BaptistHealthEntities db = new BaptistHealthEntities();

        // GET: VendorRegistration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VENDOR vendor = db.VENDOR.Find(id);
            if (vendor == null)
            {
                return HttpNotFound();
            }
            return View(vendor);
        }

        // GET: VendorRegistration/Create
        public ActionResult Create()
        {
            VendorReg newVendor = new VendorReg();
            newVendor.Items = db.ITEM.ToList();
            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username");
            return View(newVendor);
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
                db.VENDOR.Add(vendor);
                db.SaveChanges();
                return RedirectToAction("Details", "VendorRegistration", new { id = vendor.Vendor_ID });
            }

            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username", vendor.Vendor_ID);
            return View(vendor);
        }

        public ActionResult ProductCategory()
        {
            return View(db.ITEM.ToList());
        }

    }
}
