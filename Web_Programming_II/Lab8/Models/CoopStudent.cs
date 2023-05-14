using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Lab_8.Models
{
    public class CoopStudent : Student
    {
        public static int MaxWeeklyHours { get; set; }

        public static int MaxNumOfCourses { get; set; }
       
        public CoopStudent(string name)
            : base(name)
        {

        }


        public override void RegisterCourses(List<Course> coursesSelected)
        {
            int sumOfhours = coursesSelected.Sum(course => course.WeeklyHours);
            int sumOfcourses = coursesSelected.Count();
            foreach (Course course in coursesSelected)
            {
                coursesSelected.Count();
                sumOfhours += course.WeeklyHours;
            }
            if(sumOfhours> MaxWeeklyHours)
            {
                throw new Exception("Your selection exceeds the maximum number of hours: 4");
            }
            if(sumOfcourses > MaxNumOfCourses)
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
            return $"{ID} - {Name} (Coop)";
        }
    }
}