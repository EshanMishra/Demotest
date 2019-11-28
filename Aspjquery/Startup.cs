using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aspjquery.Startup))]
namespace Aspjquery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
