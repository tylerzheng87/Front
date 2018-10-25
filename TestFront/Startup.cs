using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestFront.Startup))]
namespace TestFront
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
