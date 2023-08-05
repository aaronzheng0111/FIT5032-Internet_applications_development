using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FiIT5032_MyDatabaseFirst.Startup))]
namespace FiIT5032_MyDatabaseFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
