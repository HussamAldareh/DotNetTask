using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TasksAsp.net.Models;

namespace TasksAsp.net.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
