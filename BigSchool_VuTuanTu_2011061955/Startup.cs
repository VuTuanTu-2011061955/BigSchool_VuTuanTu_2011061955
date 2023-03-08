using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_VuTuanTu_2011061955.Startup))]
namespace BigSchool_VuTuanTu_2011061955
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
