using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeaveRequest.ASP.Startup))]
namespace LeaveRequest.ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
