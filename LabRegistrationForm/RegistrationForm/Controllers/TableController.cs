using RegistrationForm.Context;
using RegistrationForm.Models;
using System.Linq;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class TableController : Controller
    {
        private const int PAGE_SIZE = 5;

        UserContext db = new UserContext();
        
        public ActionResult Index(string nameUser,int page = 1)
        {
            UserListViewModel model = new UserListViewModel
            {
                Users = db.Users
                    .Where(u => nameUser == null || u.Name == nameUser || u.Name.Contains(nameUser))
                    .OrderBy(u => u.UserId)
                    .Skip((page - 1) * PAGE_SIZE)
                    .Take(PAGE_SIZE),
                PagingInfo = new PagingInfo()
                {
                    PageNumber = page,
                    PageSize = PAGE_SIZE,
                    TotalItems = db.Users
                        .Count(u => nameUser == null || u.Name == nameUser || u.Name.Contains(nameUser))
                },
                NameUser = nameUser
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(UserListViewModel viewModel)
        {
            return Index(viewModel.NameUser);
        }
    }
}