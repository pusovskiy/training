using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task14hw.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult ShowStores()
        {   
            
            return View();
        }

        public ActionResult ShowAdvantage()
        {
            return View();
        }
    }
    
}