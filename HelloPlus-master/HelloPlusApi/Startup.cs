

//[assembly: OwinStartup(typeof(HelloPlusApi.Startup))]
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

namespace HelloPlusApi
{
    //using System.Configuration;
    //using System.IdentityModel.Tokens;
    //using System.Web.Http;
    //using Microsoft.Owin.Cors;
    //using Microsoft.Owin.Security.Jwt;
    //using Microsoft.Owin.Security.OAuth;
    //using Owin;
    //using Microsoft.Owin;



    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            // Web API routes
            // config.MapHttpAttributeRoutes();
            //  this.ConfigureOAuth(app);

            //app.UseWebApi(config);

            //app.UseCors(CorsOptions.AllowAll);
        }

    }

}