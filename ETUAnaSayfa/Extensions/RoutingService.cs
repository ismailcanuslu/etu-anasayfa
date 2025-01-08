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

    private static IEndpointRouteBuilder AddNavUniversityRouting(this IEndpointRouteBuilder endpoints)
    {
    
        endpoints.MapControllerRoute(
            name: "RectorateMessage",
            pattern: "/universitemiz/rektorun-mesaji",
            defaults: new { controller = "NavUniversity", action = "RectorateMessage" });
        
        endpoints.MapControllerRoute(
            name: "Management",
            pattern: "/universitemiz/yonetim",
            defaults: new { controller = "NavUniversity", action = "Management" });
        
        endpoints.MapControllerRoute(
            name: "GeneralSecretariat",
            pattern: "/universitemiz/genel-sekreterlik",
            defaults: new { controller = "NavUniversity", action = "GeneralSecretariat" });
        
        endpoints.MapControllerRoute(
            name: "CorporateIdentity",
            pattern: "/universitemiz/kurumsal-kimlik",
            defaults: new { controller = "NavUniversity", action = "CorporateIdentity" });
        
        endpoints.MapControllerRoute(
            name: "CorporateIdentity",
            pattern: "/universitemiz/vizyon-ve-misyon",
            defaults: new { controller = "NavUniversity", action = "VisionAndMission" });
        
        endpoints.MapControllerRoute(
            name: "Kvkk",
            pattern: "/universitemiz/kvkk",
            defaults: new { controller = "NavUniversity", action = "Kvkk" });
        
        endpoints.MapControllerRoute(
            name: "StrategicPlan",
            pattern: "/universitemiz/stratejik-plan",
            defaults: new { controller = "NavUniversity", action = "StrategicPlan" });
        
        endpoints.MapControllerRoute(
            name: "History",
            pattern: "/universitemiz/tarihce",
            defaults: new { controller = "NavUniversity", action = "History" });
        
        endpoints.MapControllerRoute(
            name: "LocationAndCampus",
            pattern: "/universitemiz/konum-ve-yerleske",
            defaults: new { controller = "NavUniversity", action = "LocationAndCampus" });
        
        endpoints.MapControllerRoute(
            name: "UniversityLogo",
            pattern: "/universitemiz/universite-logosu",
            defaults: new { controller = "NavUniversity", action = "UniversityLogo" });
        
        
        return endpoints;
    }

    public static IEndpointRouteBuilder AddNavStudentRouting(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapControllerRoute(
            name: "UniversityLogo",
            pattern: "/ogrenci/akademik-takvim",
            defaults: new { controller = "NavStudent", action = "AcademicCalendar" });
        
        return endpoints;
    }
    
    public static IEndpointRouteBuilder UseAllCustomRoutes(this IEndpointRouteBuilder endpoints)
    {
            endpoints.AddHomeRouting();
            endpoints.AddNavUniversityRouting();
            endpoints.AddNavStudentRouting();
            return endpoints;
    }
}
    
