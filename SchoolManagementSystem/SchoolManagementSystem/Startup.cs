using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolManagementSystem.Startup))]
namespace SchoolManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
