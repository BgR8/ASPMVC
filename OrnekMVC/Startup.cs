using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrnekMVC.Startup))]
namespace OrnekMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
