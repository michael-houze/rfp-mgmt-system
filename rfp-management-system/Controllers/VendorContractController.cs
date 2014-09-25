using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rfp_mgmt_system.Controllers
{
    public class VendorContractController : Controller
    {
        // GET: VendorContract
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Respond()
        {
            return View();
        }

        public ActionResult Decline()
        {
            return View();
        }
    }
}