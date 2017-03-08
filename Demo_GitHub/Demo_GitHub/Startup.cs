using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_GitHub.Startup))]
namespace Demo_GitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
