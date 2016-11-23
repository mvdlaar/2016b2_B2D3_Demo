using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2016b2_B2D3_Demo.Startup))]
namespace _2016b2_B2D3_Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
