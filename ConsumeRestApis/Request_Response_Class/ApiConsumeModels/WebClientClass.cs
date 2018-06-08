using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Request_Response_Class.ApiConsumeModels
{
    public class WebClientClass : IApiConsumer
    {
        public string GetResponse(string uri)
        {
            Console.WriteLine("Using" + this + "-->");
            Console.WriteLine();
            var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

            var response = client.DownloadString(uri);

            return response;
        }
    }
}
