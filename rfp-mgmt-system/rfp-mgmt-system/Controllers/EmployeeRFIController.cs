using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rfp_mgmt_system.Controllers
{
    public class EmployeeRFIController : Controller
    {
        //
        // GET: /EmployeeRFI/
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