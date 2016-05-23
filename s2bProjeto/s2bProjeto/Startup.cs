using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(s2bProjeto.Startup))]
namespace s2bProjeto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
