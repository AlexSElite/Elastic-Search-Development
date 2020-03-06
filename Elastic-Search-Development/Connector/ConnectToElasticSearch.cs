using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elastic_Search_Development.Connector
{
    public class ConnectToElasticSearch
    {
        #region Connection string to connect with Elasticsearch  

        public ElasticClient EsClient()
        {
            var nodes = new Uri[]
            {
                new Uri("http://localhost:9200/"),
            };

            var connectionPool = new StaticConnectionPool(nodes);
            var connectionSettings = new ConnectionSettings(connectionPool).DisableDirectStreaming();
            var elasticClient = new ElasticClient(connectionSettings);

            return elasticClient;
        }

        #endregion Connection string to connect with Elasticsearch  
    }
}