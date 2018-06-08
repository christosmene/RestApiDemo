using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Request_Response_Class.Models
{
    [JsonObject]
    public class Author
    {
        [JsonProperty("login")]
        public string LoginName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("site_admin")]
        public bool IsAdmin { get; set; }

    }
}
