﻿using Griddly.Mvc;
using System.Web;
using System.Web.Mvc;

namespace Griddly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
