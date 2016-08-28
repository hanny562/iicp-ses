using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SES.Startup))]
namespace SES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
