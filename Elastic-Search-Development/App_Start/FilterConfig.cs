﻿using System.Web;
using System.Web.Mvc;

namespace Elastic_Search_Development
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
