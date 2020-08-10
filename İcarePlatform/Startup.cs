using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(İcarePlatform.Startup))]
namespace İcarePlatform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
