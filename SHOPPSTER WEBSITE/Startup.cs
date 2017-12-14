using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SHOPPSTER_WEBSITE.Startup))]
namespace SHOPPSTER_WEBSITE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
