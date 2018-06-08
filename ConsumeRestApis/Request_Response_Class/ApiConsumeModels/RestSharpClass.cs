using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Request_Response_Class.ApiConsumeModels
{
    public class RestSharpClass : IApiConsumer
    {
        public string GetResponse(string uri)
        {
            Console.WriteLine("Using" + this + "-->");
            Console.WriteLine();
            var client = new RestClient(uri);

            IRestResponse response = client.Execute(new RestRequest());

            return response.Content;//to content to ekane string
        }
    }
}
