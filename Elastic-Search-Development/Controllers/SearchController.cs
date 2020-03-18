using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Elastic_Search_Development.Connector;
using Elastic_Search_Development.Models;
using C360IndexerTest;

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
        /// <param name="customerName"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Search(string customerInfo)
        {

            //var listOfCustomers = Program.GetListOfCustomers();
            ElastiSearchService elastiSearchService = new ElastiSearchService();
           var result = elastiSearchService.ListIndexes();
            
            //var responsedata = _connectToElasticSearch.EsClient().Search<Customer>(s => s
            //                         .Index("customer")
            //                         .Size(50)
            //                         .Query(q => q
            //                             .Match(m => m
            //                                 .Field(c => c.FirstName)
            //                                 .Field(c => c.LastName)
            //                                 .Query(customerName)
            //                             )
            //                         )
            //                     );

            var responsedata = _connectToElasticSearch.EsClient().Search<Customer>(s => s
                                   .Index("customer")
                                   .Size(50)
                                   .Query(q => q
                                       .MultiMatch(m => m
                                           .Fields(f => f
                                           .Field(c => c.FirstName)
                                           .Field(c => c.LastName)
                                           .Field(c => c.DateOfBirth)
                                           .Field(c => c.ssn)
                                           .Field(c => c.Email))
                                           .Query(customerInfo)
                                       )
                                   )
                               );

            var datasend = (from hits in responsedata.Hits
                            select hits.Source).ToList();

            var i = 0;

            foreach(var hits in responsedata.Hits)
            {
                datasend[i].Score = hits.Score.ToString();
                i++;
            }

            List<Customer> customerModel = new List<Customer>();
            customerModel = datasend;

            return View("Search", customerModel);
        }
    }
}