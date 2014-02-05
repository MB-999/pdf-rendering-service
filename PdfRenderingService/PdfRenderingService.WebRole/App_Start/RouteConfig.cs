using System.Web.Mvc;
using System.Web.Routing;

namespace PdfRenderingService.WebRole
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ApiDocumentation",
                url: "",
                defaults: new { controller = "ApiDocumentation", action = "Index" }
            );

            routes.MapRoute(
                name: "GeneratePdf",
                url: "generate-pdf",
                defaults: new { controller = "PdfGeneration", action = "GeneratePdf" }
            );
        }
    }
}
