using dotnet_crud.Models;
using dotnet_crud.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_crud.Controllers
{
    public class StudentController: Controller
    {
        private StudentRepository _studentRepository = new StudentRepository();

        [HttpPost("api/student/add")]
        public IActionResult Add([FromBody] Student student)
        {
            var registered_student = _studentRepository.Add(student);
            return Ok(registered_student);
        }


        [HttpPost("api/students")]
        public IActionResult GetAll()
        {
            return Ok(_studentRepository.GetAll());
        }


        [HttpPost("api/student/id")]
        public IActionResult GetById(int studentId)
        {
            var registered_student = _studentRepository.GetById(studentId);
            return Ok(registered_student);
        }

    }
}
