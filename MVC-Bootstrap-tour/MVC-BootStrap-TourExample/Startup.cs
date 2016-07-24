using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_BootStrap_TourExample.Startup))]
namespace MVC_BootStrap_TourExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
