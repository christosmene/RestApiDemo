using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Request_Response_Class.ApiConsumeModels
{
    class HttpClientClass : IApiConsumer
    {
        public string GetResponse(string uri)
        {
            Console.WriteLine("Using" + this + "-->");
            Console.WriteLine();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");

                var response = httpClient.GetStringAsync(new Uri(uri)).Result;

                return response;
            }
        }
    }
}
