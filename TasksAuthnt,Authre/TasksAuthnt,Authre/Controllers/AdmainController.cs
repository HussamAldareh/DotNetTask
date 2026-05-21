using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TasksAuthnt_Authre.Controllers
{
    public class AdmainController : Controller
    {

        [Authorize(Roles = "Admin")]

        // GET: AdmainController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdmainController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmainController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmainController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmainController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmainController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmainController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmainController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
