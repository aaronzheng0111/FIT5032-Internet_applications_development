using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week5Lec_CodeFirst.Startup))]
namespace week5Lec_CodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
