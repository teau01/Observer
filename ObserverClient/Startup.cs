using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ObserverClient.Startup))]
namespace ObserverClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
