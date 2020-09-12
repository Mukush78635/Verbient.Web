using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Verbient.Web.Startup))]
namespace Verbient.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
