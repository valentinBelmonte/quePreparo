using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quePreparoConCSharp.Startup))]
namespace quePreparoConCSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
