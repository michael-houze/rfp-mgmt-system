﻿using System.Web;
using System.Web.Mvc;

namespace rfp_mgmt_system
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
