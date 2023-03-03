using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestProject.Calls
{
     public class GetUsers
    {
        public static string getBungieUser()
        {
            var options = new RestClientOptions("https://www.bungie.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/Platform/Destiny2/1/Profile/4611686018434591512/LinkedProfiles", Method.Get);
            request.AddHeader("X-API-Key", "2eb1b964655942fba6dd3e0ee2dd9c2d");
            RestResponse response = client.ExecuteAsync(request).Result;
            Console.WriteLine(response.Content);
            return response.Content;
        }
    }
}
