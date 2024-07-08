using Microsoft.AspNetCore.Mvc;
using StudentWebApp.Models;
using StudentWebApp.Services;

namespace StudentWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService _studentService;
        public StudentsController(IStudentService studentService) {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public IActionResult GetResult()
        {
            var p = _studentService.GetStudents();
            return View(p);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Students students)
        {
            var p = _studentService.insert(students);

            return View(p);
        }
       

        
        public IActionResult Delete(int id)
        {
            var p = _studentService.delete(id);
            return RedirectToAction("GetResult");
        }
        [HttpGet]
        public IActionResult Update()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Update(Students model)
        {
            _studentService.update(model);
            return RedirectToAction("GetResult");
        }
        
    }
}
