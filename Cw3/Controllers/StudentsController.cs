using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cw3.Models;

namespace Cw3.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski,Malewski,Andrzejewski sortowanie={orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }else if (id == 2)
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult updateStudent(int id)
        {
            return Ok($"Aktualizacja dokonczona id={id}");
        }

        [HttpDelete("{id}")]
        public IActionResult deleteStudent(int id)
        {
            return Ok($"Usuwanie ukonczone id={id}");
        }

    }
}