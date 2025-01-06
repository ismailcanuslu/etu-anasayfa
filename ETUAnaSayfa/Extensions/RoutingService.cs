namespace ETUAnaSayfa.Extensions;

public static class RoutingService
{
    private static IEndpointRouteBuilder AddHomeRouting(this IEndpointRouteBuilder endpoints)
        {
            
            endpoints.MapControllerRoute(
                name: "Index",
                pattern: "/",
                defaults: new { controller = "Home", action = "Index" });
            
            endpoints.MapControllerRoute(
                name: "/Home/GetPaginatedAnnouncements",
                pattern: "/Home/GetPaginatedAnnouncements",
                defaults: new { controller = "Home", action = "GetPaginatedAnnouncements" });
            
            endpoints.MapControllerRoute(
                name: "HomeContact",
                pattern: "/iletisim",
                defaults: new { controller = "Home", action = "Contact" });
            
            
            return endpoints;
            
        }
    
    public static IEndpointRouteBuilder UseAllCustomRoutes(this IEndpointRouteBuilder endpoints)
    {
            endpoints.AddHomeRouting();
            return endpoints;
        }
}
    
