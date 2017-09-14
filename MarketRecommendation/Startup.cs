using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketRecommendation.Startup))]
namespace MarketRecommendation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
