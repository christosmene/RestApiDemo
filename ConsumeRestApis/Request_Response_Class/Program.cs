using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Request_Response_Class.ApiConsumeModels;
using Request_Response_Class.Models;
using ServiceStack;

namespace Request_Response_Class
{
    class Program
    {
        enum consumingWay
        {
            ReqResp, WebCl, HttpCl, RestSh, ServiceStack
        };
        const string uri = @"https://api.github.com/repos/restsharp/restsharp/releases";
        static void Main(string[] args)
        {
            
            var releasesList = new List<Release>();
            IApiConsumer rrm = ConsumerSelector.Selector(consumingWay.HttpCl.ToString());

            var releases = JArray.Parse(rrm.GetResponse(uri));



            foreach (var release in releases)
            {
                releasesList.Add(JsonConvert.DeserializeObject<Release>(release.ToString()));

            }

            foreach (var release in releasesList)
            {
                Console.WriteLine("Realese: " + release.Url + " Id: " + release.Id + " Published at: " + release.Date
                    +"\nAuthor        " + " LoginName: " + release.Author.LoginName + " Id: " + release.Author.Id+" Site Admin: "+ release.Author.IsAdmin );    
                Console.WriteLine();
            }

            string resultJson = JsonConvert.SerializeObject(releasesList);
            File.WriteAllText(@"../../Releases.json", resultJson);

        }

        
    }
}
