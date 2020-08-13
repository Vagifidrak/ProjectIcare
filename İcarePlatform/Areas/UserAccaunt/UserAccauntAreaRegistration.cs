using System.Web.Mvc;

namespace İcarePlatform.Areas.UserAccaunt
{
    public class UserAccauntAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UserAccaunt";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UserAccaunt_default",
                "UserAccaunt/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}