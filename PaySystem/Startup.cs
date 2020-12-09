using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaySystem.Startup))]
namespace PaySystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
