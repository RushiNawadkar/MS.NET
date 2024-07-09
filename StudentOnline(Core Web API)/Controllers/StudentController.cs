using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStudentPortal.Entity;
using OnlineStudentPortal.Services;

namespace OnlineStudentPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpGet("get")]
        public IActionResult GetResult()
        {
            var p=_studentService.GetAll();
            return Ok(p);
        }

        [HttpPost("Register")]
        public IActionResult Register(Student student)
        {
            var p=_studentService.insert(student);
            return Ok(p);
        }

        [HttpPut("update")]
        public IActionResult update(Student student)
        {
            var p=_studentService.update(student);
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var p= _studentService.delete(id);
            return Ok(p);
        }

        [HttpGet("{id}")]
        public IActionResult Find(int id)
        {
            var p = _studentService.find(id);
                return Ok(p);
        }

        [HttpGet("Status/{status}")]
        public IActionResult Status(string status)
        {
            var p = _studentService.findAll(status);
            return Ok(p);
        }
        
    }
}
