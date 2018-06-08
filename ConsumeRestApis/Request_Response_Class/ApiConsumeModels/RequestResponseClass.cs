using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Request_Response_Class.ApiConsumeModels
{
    public class RequestResponseClass : IApiConsumer
    {
        public string GetResponse(string uri)
        {
            Console.WriteLine("Using" + this + "-->");
            Console.WriteLine();
            var request = (HttpWebRequest)WebRequest.Create(uri);

            request.Method = "GET";
            request.UserAgent = "Chrome/67.0";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var response = (HttpWebResponse)request.GetResponse();
            Console.WriteLine(response.StatusDescription);//Prints OK


            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            return content;
        }
    }
}
