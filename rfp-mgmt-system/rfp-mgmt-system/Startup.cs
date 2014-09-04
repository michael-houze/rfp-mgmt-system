using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rfp_mgmt_system.Startup))]
namespace rfp_mgmt_system
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
