using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharmrAtelie.Startup))]
namespace CharmrAtelie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
