using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAgendaDF.Startup))]
namespace MvcAgendaDF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
