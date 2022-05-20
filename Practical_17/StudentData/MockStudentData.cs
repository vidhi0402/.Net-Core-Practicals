using Practical_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.StudentData
{
    public class MockStudentData : IStudentData
    {
        private List<Student> students = new List<Student>
        {
            new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Mohit",
                Address = "Ahmedabad",
                School = "OmLand Mark School"
            },
             new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Raj",
                Address = "Mumbai",
                School = "Achiver School"
            },
              new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Priya",
                Address = "Gandhinagar",
                School = "Ved International school"
            },
               new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Rina",
                Address = "Dahod",
                School = "Prakash Vidyalaya"
            },
                new Student()
            {
                Id = Guid.NewGuid(),
                Name = "Rahul",
                Address = "Rajkot",
                School = "Vardhaman School"
            },
        };

        public Student AddStudent(Student student)
        {
            student.Id = Guid.NewGuid();
            students.Add(student);
            return student;
        }

        public void DeleteStudent(Student student)
        {
            students.Remove(student);
        }

        public Student EditStudent(Student student)
        {
            var existingStudent = GetStudent(student.Id);
            existingStudent.Name = student.Name;
            existingStudent.Address = student.Address;
            existingStudent.School = student.School;
            return existingStudent;
        }

        public Student GetStudent(Guid id)
        {
            return students.SingleOrDefault(x =>x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
