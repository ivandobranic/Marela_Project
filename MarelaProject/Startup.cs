using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarelaProject.Startup))]
namespace MarelaProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
