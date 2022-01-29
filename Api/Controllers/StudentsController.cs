using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;
using System.Data.Entity;
using Microsoft.AspNetCore.Authorization;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly CollegeDBContext _context;

        public StudentsController(CollegeDBContext context)
        {
            _context = context;
        }

        public StudentsController()
        {
        }

        //GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Student>> createStudents(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudents", new { id = student.studentId }, student);
            
        }

        private bool StudentsExist(int id)
        {
            return _context.Students.Any(e => e.studentId == id);
        }
    }
}
