using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameFootball.Startup))]
namespace GameFootball
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
