using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onLocation2.Startup))]
namespace onLocation2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
