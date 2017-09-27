using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppCinemaProva.Startup))]
namespace WebAppCinemaProva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
