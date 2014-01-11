using System.Web.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Jokes.App_Start.JokesRouteConfig), "RegisterJokesPreStart", Order = 1)]
namespace Jokes.App_Start
{
    public static class JokesRouteConfig
    {
        ///<summary>
        /// Inserts the HotTowel SPA sample view controller to the front of all MVC routes
        /// so that the HotTowel SPA sample becomes the default page.
        ///</summary>
        ///<remarks>
        /// This class is discovered and run during startup
        /// http://blogs.msdn.com/b/davidebb/archive/2010/10/11/light-up-your-nupacks-with-startup-code-and-webactivator.aspx
        ///</remarks>
        public static void RegisterJokesPreStart()
        {

            // Preempt standard default MVC page routing to go to HotTowel Sample
            System.Web.Routing.RouteTable.Routes.MapRoute(
                name: "JokesMvc",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Jokes",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}