using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rfp_management_system.Controllers
{
    public class AdminEmployeeController : Controller
    {
        // GET: AdminEmployee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Lock()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}