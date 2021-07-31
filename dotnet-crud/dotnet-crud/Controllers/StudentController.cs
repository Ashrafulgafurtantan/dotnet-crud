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


        [HttpPost("api/students")]
        public IActionResult GetById(int id)
        {
            var registered_student = _studentRepository.GetById(id);
            return Ok(registered_student);
        }

        [HttpPost("api/student/update")]
        public IActionResult Update([FromBody] Student student)
        {
            var updated_student = _studentRepository.UpdateUser(student);
            return Ok(updated_student);
        }





    }
}
