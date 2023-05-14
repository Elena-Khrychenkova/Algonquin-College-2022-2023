using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_8.Models
{
    public class Student
    {
        private int id;
        public int ID { get; } //read only
        public string Name { get; }  //read only
       public virtual  List<Course> RegisterCourse { get; }

        protected Student(string name)
        {

            Random randomId = new Random();
            id = randomId.Next(100000, 999999); //to generate 6 digit random number
            ID = id;
            Name = name;
            this.RegisterCourse = new List<Course>();
        }
        public virtual void RegisterCourses(List<Course> coursesSelected) 
        {
            coursesSelected.Clear();
            foreach (Course course in coursesSelected)
            {
                RegisterCourse.AddRange(coursesSelected);
            }
            
        }
        public int TotalWeeklyHours()
        {
            int sumofHours = 0;

            foreach (Course course in RegisterCourse)
            {
                sumofHours += course.WeeklyHours;
               
            }
            return sumofHours;
        }
    }
}