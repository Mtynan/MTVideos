using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTVideos.Startup))]
namespace MTVideos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
