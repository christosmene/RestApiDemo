using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Request_Response_Class.Models
{
    [JsonObject]
    public class Release
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public  int Id { get; set; }

        [JsonProperty("published_at")]
        public string Date { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }
    }
}
