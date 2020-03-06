using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elastic_Search_Development.Connector;
using Elastic_Search_Development.Models;

namespace Elastic_Search_Development.Controllers
{
    public class SearchController : Controller
    {
        private readonly ConnectToElasticSearch _connectToElasticSearch;
        public SearchController()
        {
            _connectToElasticSearch = new ConnectToElasticSearch();
        }

        [HttpGet]
        public ActionResult Search()
        {

            List<HumanResource> humanResourceModel = new List<HumanResource>();
            
            return View("Search", humanResourceModel);
        }

        //Using JSON

        //[HttpPost]
        //public JsonResult DataSearch(string jobtitle, string nationalIDNumber)
        //{
        //    var responsedata = _connectToElasticSearch.EsClient().Search<HumanResource>(s => s
        //                             .Index("humanresources")
        //                             .Size(50)
        //                             .Query(q => q
        //                                 .Match(m => m
        //                                     .Field(f => f.Jobtitle)
        //                                     .Query(jobtitle)
        //                                 )
        //                             )
        //                         );

        //    var datasend = (from hits in responsedata.Hits
        //                    select hits.Source).ToList();

        //    return this.Json(datasend, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public ActionResult Search(string jobtitle, string nationalIDNumber)
        {
            var responsedata = _connectToElasticSearch.EsClient().Search<HumanResource>(s => s
                                     .Index("humanresources")
                                     .Size(50)
                                     .Query(q => q
                                         .Match(m => m
                                             .Field(f => f.Jobtitle)
                                             .Query(jobtitle)
                                         )
                                     )
                                 );

            var datasend = (from hits in responsedata.Hits
                            select hits.Source).ToList();

            List<HumanResource> humanResourceModel = new List<HumanResource>();
            humanResourceModel = datasend;

            return View("Search", humanResourceModel);
        }
    }
}