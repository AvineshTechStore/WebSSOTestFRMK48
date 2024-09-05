using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OdessaWebSSOTestApp.Startup))]
namespace OdessaWebSSOTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}