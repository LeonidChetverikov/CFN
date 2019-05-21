using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace FrameworkVersion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var appSettings = ConfigurationManager.AppSettings;
            var targetFrameworkAttribute = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Runtime.Versioning.TargetFrameworkAttribute), false).SingleOrDefault();

            ViewBag.TargetFramework = ((System.Runtime.Versioning.TargetFrameworkAttribute)targetFrameworkAttribute).FrameworkName;

            return View(appSettings);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}