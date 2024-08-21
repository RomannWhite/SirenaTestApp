using Newtonsoft.Json;

namespace SirenaTestApp.Models
{
    public class AirportInfo
    {
        [JsonProperty("iata")]
        public string IATA { get; set; }
        [JsonProperty("location")]
        public GRSInfo GRSInfo { get; set; }
        //public GRSInfo location { get; set; }
    }
}

//https://places-dev.cteleport.com/airports/AMS
//{
//  "iata":"AMS",
//  "name":"Amsterdam",
//  "city":"Amsterdam",
//  "city_iata":"AMS",
//  "icao":"EHAM",
//  "country":"Netherlands",
//  "country_iata":"NL",
//  "location":
//  {
//      "lon":4.763385,
//      "lat":52.309069
//  },
//  "rating":3,
//  "hubs":7,
//  "timezone_region_name":"Europe/Amsterdam",
//  "type":"airport"
//}