using Lets_Travel.Api_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lets_Travel
{
    static class GlobalVariables
    {
        public static Boolean isLoggedIn = false;
        
        public static AppDTO _user = new AppDTO();
        public static string SessionUserId = "";
    }
}
