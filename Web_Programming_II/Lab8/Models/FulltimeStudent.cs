using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab_8.Models
{
    public class FulltimeStudent : Student
    {
        public static int MaxWeeklyHours { get; set; } = 16;
      


        public FulltimeStudent(string name)
            : base(name)
        {
       
        }

        public override void RegisterCourses(List<Course> coursesSelected)
        {

            int sumOfHours = 0;
            foreach (Course course in coursesSelected)
            {
                sumOfHours += course.WeeklyHours;
            }
            if (sumOfHours > MaxWeeklyHours)
            {
                throw new Exception("Your selection exceeds the maximum number of hours: 16");
            }
            else
            {
                RegisterCourse.AddRange(coursesSelected);
            }

        }

        public override string ToString()
        {
            return $"{ID} - {Name} (Full Time)";
        }
    }
}