using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppKurierska.Startup))]
namespace AppKurierska
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
