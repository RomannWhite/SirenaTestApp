using Newtonsoft.Json;

namespace SirenaTestApp.Models
{
    public class GRSInfo
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }
}

//https://places-dev.cteleport.com/airports/AMS
//"location":
//{
//  "lon":4.763385,
//  "lat":52.309069
//}