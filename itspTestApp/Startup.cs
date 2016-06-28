using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(itspTestApp.Startup))]
namespace itspTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
