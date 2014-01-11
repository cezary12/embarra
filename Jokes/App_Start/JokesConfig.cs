using System.Web.Optimization;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(Jokes.App_Start.JokesConfig), "PreStart")]
namespace Jokes.App_Start
{
    public static class JokesConfig
    {
        public static void PreStart()
        {
            // Add your start logic here
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}