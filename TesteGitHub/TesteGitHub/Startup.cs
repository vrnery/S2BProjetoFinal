using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteGitHub.Startup))]
namespace TesteGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
