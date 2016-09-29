using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMessenger.Startup))]
namespace WebMessenger
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
