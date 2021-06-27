using Newtonsoft.Json;

namespace API.Models
{
    class Response
    {
        [JsonProperty("numberInWords")]
        public string numberInWords { get; set; }
    }
}