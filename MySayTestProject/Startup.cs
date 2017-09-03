using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySayTestProject.Startup))]
namespace MySayTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
