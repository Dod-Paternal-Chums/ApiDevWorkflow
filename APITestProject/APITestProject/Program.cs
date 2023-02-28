using APITestProject.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace APITestProject
{
    class Program
    {
        public static string MainBungie { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainBungie = "https://www.bungie.net/platform/Destiny/";
            var item = getBungieUser();
        }

        static Response<bungieNetUser> getBungieUser()
        {
            var location = new Uri("");

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", "YOUR-API-KEY-HERE");
                string jsonResponse = client.GetStringAsync(MainBungie + location).Result;
                return JsonConvert.DeserializeObject<Response<bungieNetUser>>(jsonResponse);
            }
        }
    }
}
