using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Request_Response_Class.ApiConsumeModels
{
    public interface IApiConsumer
    {
       string GetResponse(string uri);

    }
}
