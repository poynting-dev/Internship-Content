using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCRUDWithAdoOAuth.Startup))]
namespace MvcCRUDWithAdoOAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
