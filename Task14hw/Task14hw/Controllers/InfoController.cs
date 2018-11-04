using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task14hw.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult GetAdress()
        {
            return View();
        }

        public ActionResult GetContacts()
        {
            return View();
        }
    }
}