using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice2.Startup))]
namespace Practice2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
