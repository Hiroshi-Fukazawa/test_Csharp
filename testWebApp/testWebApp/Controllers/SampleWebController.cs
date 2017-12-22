using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testWebApp.Controllers
{
    public class SampleWebController : Controller
    {
        // GET: SampleWeb
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        public ActionResult Input()
        {
            return View();
        }

        public ActionResult Result()
        {
            return View();
        }
    }
}