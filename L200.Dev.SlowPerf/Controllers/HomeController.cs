using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L200.Dev.SlowPerf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SlowPerf()
        {
            System.Threading.Thread.Sleep(30 * 1000);
            return View();
        }

        public ActionResult Crash()
        {
            throw new Exception("code is HelloWorld");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CurrentUser()
        {
            string name = "no user found";
            try
            {
                name = this.HttpContext.User.Identity.Name;
            }
            catch(Exception )
            {

            }
            ViewBag.UserName = name;
            return View();
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