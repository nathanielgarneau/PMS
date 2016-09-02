using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Xam.WebApiClient
{
   public static class Config
   {
       public static Uri BaseAddress = new Uri("http://10.31.185.126/");
       public static MediaTypeWithQualityHeaderValue JsonHeaderValue = new MediaTypeWithQualityHeaderValue("application/json");
    }
}
