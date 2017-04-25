using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAnGiuaKyWeb.Startup))]
namespace DoAnGiuaKyWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
