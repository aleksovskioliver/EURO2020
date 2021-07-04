using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EURO2020.Startup))]
namespace EURO2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
