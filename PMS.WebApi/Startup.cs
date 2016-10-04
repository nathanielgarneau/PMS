using Microsoft.Owin;
using Owin;
using PMS.WebApi;

[assembly: OwinStartup(typeof (Startup))]

namespace PMS.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}