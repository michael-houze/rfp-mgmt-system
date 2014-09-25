using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rfp_management_system.Controllers
{
    public class EmployeeReportController : Controller
    {
        // GET: EmployeeReport
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Download()
        {
            return View();
        }
    }
}