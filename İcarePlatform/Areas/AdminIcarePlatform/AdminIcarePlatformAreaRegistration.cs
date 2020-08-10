using System.Web.Mvc;

namespace İcarePlatform.Areas.AdminIcarePlatform
{
    public class AdminIcarePlatformAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminIcarePlatform";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminIcarePlatform_default",
                "AdminIcarePlatform/{controller}/{action}/{id}",
                new { action = "AdminHome, Index", id = UrlParameter.Optional }
            );
        }
    }
}