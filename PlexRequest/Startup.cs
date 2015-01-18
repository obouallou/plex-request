using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlexRequest.Startup))]
namespace PlexRequest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
