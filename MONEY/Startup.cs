using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MONEY.Startup))]
namespace MONEY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
