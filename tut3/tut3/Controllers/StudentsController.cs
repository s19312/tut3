using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using tut3.Models;
using tut3.Services;

namespace tut3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
            private IDbService _dbService;

            public StudentsController(IDbService dbService)
            {
                this._dbService = dbService;
            }
          
            [HttpGet]
            public IActionResult GetStudents(string orderBy = "firstName") 
            {       
            return Ok(_dbService.GetStudents());
            }

            
            [HttpGet("{id}")]
            public IActionResult GetStudent(int id) 
            {
                return Ok(_dbService.GetStudents().Where(u => u.IdStudent == id));
            }        

            [HttpPost]
            public IActionResult CreateStudent(Student student)
            {
                student.IndexNumber = $"s{new Random().Next(1, 20000)}";
                return Ok(student);
            }

            [HttpPut("{id}")]
            public IActionResult Update(int id)
            {
                if (id > 0)
                    return Ok("Update complete");
                return NotFound("No such Id!");
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                return Ok("Delete completed");
            }
       }
}
