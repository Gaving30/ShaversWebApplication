using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShaversWebApplication.Startup))]
namespace ShaversWebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
