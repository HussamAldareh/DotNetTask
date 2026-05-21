using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Task3_MVC_.Controllers
{

    public class AdmainController : Controller
    {
        public IActionResult HIAdmain()
        {
            return View();
        }
    }
}
