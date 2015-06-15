using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Dota2Nube.Startup))]
namespace Dota2Nube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
