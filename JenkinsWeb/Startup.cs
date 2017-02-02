using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsWeb.Startup))]
namespace JenkinsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
