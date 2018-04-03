using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactJS_Crud_Backend.Startup))]
namespace ReactJS_Crud_Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
