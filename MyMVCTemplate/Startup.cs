using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCTemplate.Startup))]
namespace MyMVCTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
