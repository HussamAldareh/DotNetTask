using Microsoft.AspNetCore.Mvc;
using TaskTuple.Models;

namespace TaskTuple.Controllers
{
    public class StudentController : Controller
    {
        public StudentController()
        {
            
        }
        public IActionResult Index()
        {

            var students = new List<Student>()
    {
        new Student { Id = 1, Name = "Ahmad" },
        new Student { Id = 2, Name = "Ali" }
    };

            var courses = new List<Course>()
    {
        new Course { CourseId = 1, CourseName = "Math" },
        new Course { CourseId = 2, CourseName = "Programming" }
    };

            var tuple = new Tuple<IEnumerable<Student>, IEnumerable<Course>>(students, courses);

            return View(tuple);
        }
    }
}
