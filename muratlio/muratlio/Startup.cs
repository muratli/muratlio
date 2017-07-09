using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(muratlio.Startup))]
namespace muratlio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
