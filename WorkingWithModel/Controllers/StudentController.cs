using Microsoft.AspNetCore.Mvc;
using WorkingWithModel.Models;

namespace WorkingWithModel.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Create(Student stud)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Student stud)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Student Stud)
        {
            return View();
        }
    }
}
