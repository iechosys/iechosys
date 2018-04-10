using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iechosys.Startup))]
namespace iechosys
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
