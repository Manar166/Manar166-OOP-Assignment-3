using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class CourseStore
    {
        List<Course> _courses = new List<Course>();

        
        public void Add(Course course)
        {
            if (course is not null)
            {
                _courses.Add(course);
            }

            
        }

        public Course GetById(int id)
        {
            foreach (var item in _courses)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }


        public List<Course> GetALl() => _courses;


        public void Remove(int id)
        {
            var course = GetById(id);
            if (course != null)
            {
                _courses.Remove(course);
            }



        }
    }
}
