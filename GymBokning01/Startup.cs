using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymBokning01.Startup))]
namespace GymBokning01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
