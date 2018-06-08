using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Request_Response_Class.ApiConsumeModels;

namespace Request_Response_Class.ApiConsumeModels
{
    public static class ConsumerSelector
    {
        public static IApiConsumer Selector(string way)
        {
            if (way== "ReqResp")
            {
                return new RequestResponseClass();
            }
            else if(way == "WebCl")
            {
                return new WebClientClass();
            }
            else if (way == "HttpCl")
            {
                return new HttpClientClass();
            }
            else if (way == "RestSh")
            {
                return new RestSharpClass();
            }
            else if (way == "ServiceStack")
            {
                return new ServiceStackHttpUtilsClass();
            }
            return null;
        }
    }
}
