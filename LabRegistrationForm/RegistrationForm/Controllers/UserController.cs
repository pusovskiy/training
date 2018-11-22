using RegistrationForm.Context;
using RegistrationForm.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        private UserContext db = new UserContext();

        [HttpGet]
        public ActionResult Addition(int id = 0) 
        {
            var add = db.Users.FirstOrDefault(user => user.UserId == id);

            if (add != null)
            {
                ViewBag.IsUpdated = true;

                return View(add);
            }
            else
            {
                ViewBag.IsUpdated = false;
                return View();
            }
        }

        [HttpGet]
        public ActionResult RegistrateNew()
        {
            return RedirectToAction("Addition");
        }

        [HttpPost]
        public ActionResult Addition(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Table");
            }

            return RedirectToAction("Index","Table");
        }

        [HttpPost]
        public ActionResult RegistrateNew(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index", "Table");
            }

            return RedirectToAction("Addition");
        }

        public ActionResult RemoveUser(int id = 0)
        {
            var user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Table");
        }

    }
}