using System;
using System.Net.Http.Headers;

namespace PMS.Xam.WebApiClient
{
    public static class Config
    {
        public static Uri BaseAddress = new Uri("http://10.31.185.98/api/");

        public static MediaTypeWithQualityHeaderValue JsonHeaderValue =
            new MediaTypeWithQualityHeaderValue("application/json");

        public static MediaTypeWithQualityHeaderValue JsonHeaderTextValue =
            new MediaTypeWithQualityHeaderValue("text/json");

        public static MediaTypeWithQualityHeaderValue PlainHeaderValue = new MediaTypeWithQualityHeaderValue("text/html");
    }
}