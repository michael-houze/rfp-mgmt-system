using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rfp_mgmt_system;

namespace rfp_mgmt_system.Controllers
{
    public class EmployeeManagementController : Controller
    {
        private BHEntities db = new BHEntities();

        // GET: /EmployeeManagement/
        public ActionResult Index()
        {
            var employees = db.EMPLOYEEs.Include(e => e.Emp_Admin).Include(e => e.EMP_LOGIN);
            return View(employees.ToList());
        }

        // GET: /EmployeeManagement/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE employee = db.EMPLOYEEs.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: /EmployeeManagement/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID");
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username");
            return View();
        }

        // POST: /EmployeeManagement/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EmployeeID,EmployeeFirstName,EmployeeLastName,EmployeeEmail,EmployeeSecurityQuestion,EmployeeSecurityAnswer")] EMPLOYEE employee)
        {
            if (ModelState.IsValid)
            {
                db.EMPLOYEEs.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", employee.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", employee.EmployeeID);
            return View(employee);
        }

        // GET: /EmployeeManagement/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE employee = db.EMPLOYEEs.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", employee.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", employee.EmployeeID);
            return View(employee);
        }

        // POST: /EmployeeManagement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EmployeeID,EmployeeFirstName,EmployeeLastName,EmployeeEmail,EmployeeSecurityQuestion,EmployeeSecurityAnswer")] EMPLOYEE employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.Emp_Admin, "EmployeeID", "EmployeeID", employee.EmployeeID);
            ViewBag.EmployeeID = new SelectList(db.EMP_LOGIN, "EmployeeID", "Emp_Username", employee.EmployeeID);
            return View(employee);
        }

        // GET: /EmployeeManagement/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE employee = db.EMPLOYEEs.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: /EmployeeManagement/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE employee = db.EMPLOYEEs.Find(id);
            db.EMPLOYEEs.Remove(employee);
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
