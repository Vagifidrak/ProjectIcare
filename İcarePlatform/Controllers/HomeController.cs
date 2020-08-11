using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace İcarePlatform.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Haqqımızda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Əlaqə";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string name=null, string email = null, string subject=null, string message = null)
        {
            if(name != null && email != null && message != null)
            {
                WebMail.SmtpServer = "mail.e-icare.az";
                WebMail.EnableSsl = true;
                WebMail.UserName = "admin@e-icare.az";
                WebMail.Password = "asankira2020";
                WebMail.SmtpPort = 465;
                WebMail.Send("admin@e-icare.az", subject, email + "-" + message);
                TempData["contact"] = "Mesajınız uğurla göndərildi";
            }
            else
            {
                TempData["contact"] = "Xəta baş verdi təkrar yoxlayın";
            }
            return View();
        }
    }
}