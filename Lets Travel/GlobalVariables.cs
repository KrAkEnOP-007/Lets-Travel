using Lets_Travel.Api_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Lets_Travel
{
    static class GlobalVariables
    {
        public static Boolean isLoggedIn = false;
        
        public static AppDTO _user = new AppDTO();
        public static string SessionUserId = "";
        public static HttpClient client = new HttpClient();
        static GlobalVariables()
        {
            client.BaseAddress = new Uri("https://localhost:44335");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
