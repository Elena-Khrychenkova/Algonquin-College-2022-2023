using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab_8.Models
{
    public class ParttimeStudent : Student
    {
        public static int MaxNumOfCourses { get; set; }

      

        public ParttimeStudent(string name)
            : base(name)
        {

        }
        public override void RegisterCourses(List<Course> coursesSelected)
        {

            int countCourses = 0;
            foreach (Course course in coursesSelected)
            {
                countCourses++;
            }
            if (countCourses > MaxNumOfCourses)
            {
                throw new Exception("Your selection exceeds the maximum number of course: 3");
            }
            else
            {
                RegisterCourse.AddRange(coursesSelected);
            }

        }
        public override string ToString()
        {
            return $"{ID} - {Name} (Part Time)";
        }
    }
}