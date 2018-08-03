using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTwoSum.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int a = 10, b = 20, c;
            c = a + b;
            ViewBag.sum = c;
            int d;
            return View();
        }
    }
}