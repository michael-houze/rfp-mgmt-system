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
    public class EmployeesController : Controller
    {
        private BaptistHealthEntities db = new BaptistHealthEntities();

        // GET: Employees
        public ActionResult Index()
        {
            var eMPLOYEEs = db.EMPLOYEEs.Include(e => e.Emp_Admin).Include(e => e.EMP_LOGIN);
            return View(eMPLOYEEs.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID");
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create([Bind(Include = "EmployeeID,EmployeeFirstName,EmployeeLastName,EmployeeEmail,EmployeeSecurityQuestion,EmployeeSecurityAnswer")] EMPLOYEE eMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.EMPLOYEEs.Add(eMPLOYEE);

                var newEmployeeAdmin = new Emp_Admin { Active = true };
                db.Emp_Admin.Add(newEmployeeAdmin);

                String userName = eMPLOYEE.createUsername();
                String userPassword = eMPLOYEE.createPassword();
                var newEmployeeLogin = new EMP_LOGIN { Emp_Username = userName, Emp_Password = userPassword };
                db.EMP_LOGIN.Add(newEmployeeLogin);

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", eMPLOYEE.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", eMPLOYEE.EmployeeID);
            return View(eMPLOYEE);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", eMPLOYEE.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", eMPLOYEE.EmployeeID);
            return View(eMPLOYEE);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,EmployeeFirstName,EmployeeLastName,EmployeeEmail,EmployeeSecurityQuestion,EmployeeSecurityAnswer")] EMPLOYEE eMPLOYEE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPLOYEE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", eMPLOYEE.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", eMPLOYEE.EmployeeID);
            return View(eMPLOYEE);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            if (eMPLOYEE == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE eMPLOYEE = db.EMPLOYEEs.Find(id);
            db.EMPLOYEEs.Remove(eMPLOYEE);
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
