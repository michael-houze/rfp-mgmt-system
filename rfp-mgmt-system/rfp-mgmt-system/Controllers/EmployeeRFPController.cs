using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rfp_mgmt_system.Controllers
{
    public class EmployeeRFPController : Controller
    {
        //
        // GET: /EmployeeRFP/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
	}
}