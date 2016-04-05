using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektMvcGrund.Startup))]
namespace ProjektMvcGrund
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
