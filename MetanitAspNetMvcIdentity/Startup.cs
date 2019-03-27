using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MetanitAspNetMvcIdentity.Startup))]
namespace MetanitAspNetMvcIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
