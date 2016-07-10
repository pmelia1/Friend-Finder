using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Friend_Finder.Startup))]
namespace Friend_Finder
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
