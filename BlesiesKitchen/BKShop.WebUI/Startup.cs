using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BKShop.WebUI.Startup))]
namespace BKShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
