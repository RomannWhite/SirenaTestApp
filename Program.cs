using SirenaTestApp.Helpers;
using SirenaTestApp.Models;

internal class Program
{
    public const bool UseFullLog = false;
    const string AirportInfoURL = "https://places-dev.cteleport.com/airports/";
    private static void Main()
    {
        string Airport1 = "AMS";
        string Airport2 = "SVO";

        if (!InternetHelper.GetObject(AirportInfoURL + Airport1, out AirportInfo AirportInfo1) ||
            !InternetHelper.GetObject(AirportInfoURL + Airport2, out AirportInfo AirportInfo2))
        {
            Console.WriteLine("Some error with loading data");
        }
        else
        {
            double Distance = GPSHelper.CalcDistanceKm(AirportInfo1.GRSInfo, AirportInfo2.GRSInfo);
            Distance = GPSHelper.KmToMiles(Distance);
            Console.WriteLine($"Distance between {Airport1} and {Airport2} : {Distance:0.0} miles");
        }
    }
}