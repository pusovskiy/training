using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task14hw.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Test(string category,int hour = 0)
        {
            ViewBag.Category = category;
            ViewBag.Hour = hour;
            return View();
        }

        
    }
}