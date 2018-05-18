using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AkiTek.Startup))]
namespace AkiTek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
