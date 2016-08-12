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
       public static Uri BaseAddress = new Uri("http://localhost:55380/");
       public static MediaTypeWithQualityHeaderValue JsonHeaderValue = new MediaTypeWithQualityHeaderValue("application/json");
    }
}
