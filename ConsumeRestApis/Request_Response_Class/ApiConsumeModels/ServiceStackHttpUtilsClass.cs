using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request_Response_Class.ApiConsumeModels
{
    public class ServiceStackHttpUtilsClass : IApiConsumer
    {
        public string GetResponse(string uri)
        {
            Console.WriteLine("Using" + this + "-->");
            Console.WriteLine();
            var response = uri.GetJsonFromUrl(requestFilter: webReq =>
            {
                webReq.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
            });

            return response;
        }
    }
}
