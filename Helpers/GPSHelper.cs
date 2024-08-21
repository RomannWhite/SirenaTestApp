using SirenaTestApp.Models;

namespace SirenaTestApp.Helpers
{
    public class GPSHelper
    {
        const double EarthRadius = 6372.795;//km
        const double MilesInKm = 0.62137;
        static double DegToRad(double deg) => deg * Math.PI / 180;
        public static double KmToMiles(double dist) => dist *= MilesInKm;
        public static double CalcDistanceKm(GRSInfo point1, GRSInfo point2)
        {
            #region A lot of math
            double Lat1 = DegToRad(point1.Latitude);
            double Long1 = DegToRad(point1.Longitude);
            double Lat2 = DegToRad(point2.Latitude);
            double Long2 = DegToRad(point2.Longitude);

            double CosLat1 = Math.Cos(Lat1);
            double CosLat2 = Math.Cos(Lat2);
            double SinLat1 = Math.Sin(Lat1);
            double SinLat2 = Math.Sin(Lat2);
            double CosDelta = Math.Cos(Long2 - Long1);
            double SinDelta = Math.Sin(Long2 - Long1);

            double X = SinLat1 * SinLat2 + CosLat1 * CosLat2 * CosDelta;
            double Y = Math.Sqrt(Math.Pow(CosLat2 * SinDelta, 2) + Math.Pow(CosLat1 * SinLat2 - SinLat1 * CosLat2 * CosDelta, 2));

            double Atan = Math.Atan2(Y, X);
            return Atan * EarthRadius;
            #endregion
        }
    }
}
