using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HitRave.Startup))]
namespace HitRave
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
