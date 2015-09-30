using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(artbyboba.Startup))]
namespace artbyboba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
