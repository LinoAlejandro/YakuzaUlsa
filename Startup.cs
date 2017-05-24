using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YakuzaUlsa.Startup))]
namespace YakuzaUlsa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
