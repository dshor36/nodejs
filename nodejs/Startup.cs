using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nodejs.Startup))]
namespace nodejs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
