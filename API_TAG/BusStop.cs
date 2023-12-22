using Newtonsoft.Json;

namespace API_TAG
{
    public class BusStop
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lines")]
        public string[] Lines { get; set; }

        
    }
}