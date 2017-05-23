using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Graphix2.Startup))]
namespace Graphix2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
