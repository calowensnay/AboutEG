using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AboutEG.Startup))]
namespace AboutEG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
