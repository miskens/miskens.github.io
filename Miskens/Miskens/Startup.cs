using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Miskens.Startup))]
namespace Miskens
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
