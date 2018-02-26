using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UcakBiletiRezervasyon.Startup))]
namespace UcakBiletiRezervasyon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
