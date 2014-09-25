using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rfp_management_system.Startup))]
namespace rfp_management_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
