using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task.WebApp.Startup))]
namespace Task.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
