using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Hello()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Hello(string userName)
        {
            ViewBag.Answer = StringManipulation.Greeting.SayHello(userName);

            return View("Answer");
        }
    }
}