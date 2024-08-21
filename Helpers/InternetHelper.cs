using Newtonsoft.Json;
using System.Net;

namespace SirenaTestApp.Helpers
{
    internal class InternetHelper
    {
        static bool GetString(string url, out string data)
        {
            if (Program.UseFullLog)
                Console.WriteLine($"Send: {url}");
            using (WebClient client = new WebClient())
            {
                try
                {
                    data = client.DownloadString(url);
                    if(Program.UseFullLog)
                        Console.WriteLine($"Get: {data}");
                    return true;
                }
                catch (Exception Ex)
                {
                    if (Program.UseFullLog)
                        Console.WriteLine($"WebClient Exception: {Ex.Message}");
                    data = null;
                }
            }
            return false;
        }
        public static bool GetObject<T>(string url, out T data)
        {
            string Data;
            if (GetString(url, out Data))
            {
                try
                {
                    data = JsonConvert.DeserializeObject<T>(Data);
                    return true;
                }
                catch (Exception Ex)
                {
                    if (Program.UseFullLog)
                        Console.WriteLine($"Deserialize Exception: {Ex.Message}");
                }
            }
            data = default;
            return false;
        }
    }
}