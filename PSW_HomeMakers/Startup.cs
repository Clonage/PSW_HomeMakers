using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSW_HomeMakers.Startup))]
namespace PSW_HomeMakers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
