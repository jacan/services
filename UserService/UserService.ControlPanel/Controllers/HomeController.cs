using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserService.ControlPanel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the User service Control Panel";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This service is a control panel for more information se online social services";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please contact me on jckandersen@gmail.com";

            return View();
        }
    }
}
