using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Task3_MVC_.Controllers
{
    [Authorize (Roles ="User")]
    public class UsersController : Controller
    {
        public IActionResult HiUser()
        {
            return View();
        }
    }
}
