using Practical_17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_17.StudentData
{
     public interface IStudentData
    {
        List<Student> GetStudents();

        Student GetStudent(Guid id);

        Student AddStudent(Student student);
        void DeleteStudent(Student student);
        Student EditStudent(Student student);

    }
}
