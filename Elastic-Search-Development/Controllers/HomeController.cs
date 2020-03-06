using Elastic_Search_Development.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elastic_Search_Development.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ConnectToElasticSearch _connectToElasticSearch = new ConnectToElasticSearch();

            var results = _connectToElasticSearch.EsClient();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}