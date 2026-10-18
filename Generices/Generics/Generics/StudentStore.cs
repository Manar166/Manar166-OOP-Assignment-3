using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Generics
{
    public class StudentStore
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            if (student is not null)
            { 
                students.Add(student);
            } 
        }

        public Student GetStudentById(int id)
        {
            foreach (var item in students)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }


        public List<Student> GetALlStudents() => students;


        public void Remove(int id)
        {
            var student = GetStudentById(id);
            if (student != null)
            {
                students.Remove(student);
            }



        }
    }
}
