using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScrumprojektGrupp2.Startup))]
namespace ScrumprojektGrupp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
