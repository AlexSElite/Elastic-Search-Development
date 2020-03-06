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

            List<Customer> customerModel = new List<Customer>();
            
            return View("Search", customerModel);
        }

        /// <summary>
        /// Searches Elastic Search based on the index passed in.
        /// </summary>
        /// <param name="jobtitle"></param>
        /// <param name="nationalIDNumber"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Search(string customerName)
        {
            var responsedata = _connectToElasticSearch.EsClient().Search<Customer>(s => s
                                     .Index("customer")
                                     .Size(50)
                                     .Query(q => q
                                         .Match(m => m
                                             .Field(f => f.CustomerId)
                                             .Query(customerName)
                                         )
                                     )
                                 );

            var datasend = (from hits in responsedata.Hits
                            select hits.Source).ToList();

            List<Customer> customerModel = new List<Customer>();
            customerModel = datasend;

            return View("Search", customerModel);
        }
    }
}