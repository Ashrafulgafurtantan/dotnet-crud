using dotnet_crud.Models;
using pos_system.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_crud.Repository
{
    public class StudentRepository: DatabaseRepository
    {

        public Student Add(Student student)
        {
            DatabaseContext.Students.Add(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public List<Student> GetAll()
        {
            return DatabaseContext.Students.ToList();
            
        }

        public Student GetById(int id)
        {
            return DatabaseContext.Students.SingleOrDefault(student=>student.Id == id);
            
        }

        public Student UpdateUser(Student student)
        {
            DatabaseContext.Students.Update(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public int DeleteUser(Student student)
        {
            DatabaseContext.Students.Remove(student);
            return DatabaseContext.SaveChanges();
            
        }



    }
}
