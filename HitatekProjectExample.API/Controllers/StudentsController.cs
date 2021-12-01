using HitatekProjectExample.Business.Abstract;
using HitatekProjectExample.DataAccess.Abstract;
using HitatekProjectExample.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HitatekProjectExample.API.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students); //200 + data

            //public List<Student> Get()
            //{
            //    return _studentService.GetAllStudents();
            //}
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student != null)
            {
                return Ok(student);
            }
            return NotFound(); // 404

            //public Student Get(int id)
            //{
            //    return _studentService.GetStudentById(id);
            //}
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (ModelState.IsValid)
            {
                var createdStudent = _studentService.CreateStudent(student);
                return CreatedAtAction("Get", new { id = createdStudent.Id }, createdStudent); // 201 + data
            }
            return BadRequest(ModelState); // 400 + Validation errors

            //public Student Post([FromBody] Student student)
            //{
            //    return _studentService.CreateStudent(student);
            //}
        }

        [HttpPut]
        public IActionResult Put([FromBody] Student student)
        {
            if (_studentService.GetStudentById(student.Id) != null)
            {
                return Ok(_studentService.UpdateStudent(student)); // 200 + data
            }
            return NotFound();

            //public Student Put([FromBody] Student student)
            //{
            //    return _studentService.UpdateStudent(student);
            //}
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_studentService.GetStudentById(id) != null)
            {
                _studentService.DeleteStudent(id);
                return Ok(); // 200 + data
            }
            return NotFound();

            //public void Delete(int id)
            //{
            //    _studentService.DeleteStudent(id);
            //}
        }

    }
}
