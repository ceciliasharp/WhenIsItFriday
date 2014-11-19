using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhenIsItFriday.Startup))]
namespace WhenIsItFriday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
