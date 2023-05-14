using Lab_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab_8.Models;

namespace Lab_8
{
    public partial class RegisterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Student> students = (List<Student>)Session["students"];
                if (students != null)
                {
                    foreach (Student s in students)
                    {
                        s.ToString();
                        ListItem item = new ListItem(s.ToString(), s.ID.ToString()); //the value placed
                        stdName.Items.Add(item);
                    }
                }

                foreach (Course course in Helper.GetAvailableCourses())
                {
                    CheckBoxList1.Items.Add(new ListItem(course.Title, course.Code));
                }

            }
        }
        protected void save_Click(object sender, System.EventArgs e)
        {
            List<Student> students = (List<Student>)Session["students"];
            List<Course> coursesSelected = new List<Course>(); //create the list of the courses selected by user
            int countCourses = 0;
            bool noSelection = true; //no course has been selected
            foreach (ListItem CheckBoxList1 in CheckBoxList1.Items) //courses to select
            {
                if (CheckBoxList1.Selected == true) //user selected the courses
                {
                    noSelection = false;
                    Course course = Helper.GetCourseByCode(CheckBoxList1.Value);
                    coursesSelected.Add(course);
                    countCourses++;
                    coursesValidation.Visible = false;
                }
                else if(noSelection == true)
                {
                    coursesValidation.Text = "You need to select at least one course!";
                    coursesValidation.Visible= true;
                }
            }
                foreach (Student student in students)
                {
                    if(student.ID.ToString() == stdName.SelectedValue)
                    {
                    Student selectedStudent = student;
                        try
                        {
                            selectedStudent.RegisterCourses(coursesSelected);
                            
                        if(noSelection == false)
                        {
                            RegestCompl.Text = $"Selected student has regestered {countCourses} course(s), {selectedStudent.TotalWeeklyHours()} hours weekly";
                        }

                        }
                        catch (Exception ex)
                        {
                            rButton.Text = ex.Message;
                        }
                       
                    }
                    
                }
                  

        }
            protected void index_OnChange (object sender, System.EventArgs e)
                {
           

                }
        }

    }
//}
