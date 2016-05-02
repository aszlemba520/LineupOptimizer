using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LineupOptimizer.Startup))]
namespace LineupOptimizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
