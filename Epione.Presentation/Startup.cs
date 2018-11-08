using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Epione.Presentation.Startup))]
namespace Epione.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
