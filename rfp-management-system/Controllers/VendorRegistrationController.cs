using System.Net;
using System.Web.Mvc;
using rfp_mgmt_system.Models;

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
            VENDOR vendor = db.VENDORS.Find(id);
            if (vendor == null)
            {
                return HttpNotFound();
            }
            return View(vendor);
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
                db.VENDORS.Add(vendor);
                db.SaveChanges();
                return RedirectToAction("Details", "VendorRegistration", new { id = vendor.Vendor_ID });
            }

            ViewBag.Vendor_ID = new SelectList(db.VENDOR_LOGIN, "Vendor_ID", "Vendor_Username", vendor.Vendor_ID);
            return View(vendor);
        }

    }
}
