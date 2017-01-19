using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Staff.Startup))]
namespace Staff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
