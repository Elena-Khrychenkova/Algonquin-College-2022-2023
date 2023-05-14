using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab_8.Models;

namespace Lab_8
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                dropDown.Items.Add(new ListItem("Select...", "Select"));
                dropDown.Items.Add(new ListItem("Full Time", "Full Time"));
                dropDown.Items.Add(new ListItem("Part Time", "Part Time"));
                dropDown.Items.Add(new ListItem("Coop", "Coop"));
            }
        }
        protected void addStudent_Click(object sender, EventArgs e)
        {
            string studentName = stdName.Text;
            string studentType = dropDown.SelectedValue;


            if (Session["students"] == null)
            {
                Session["students"] = new List<Student>();
            }
            List<Student> students = (List<Student>)Session["students"];

            if (studentType == "Full Time" && !string.IsNullOrWhiteSpace(studentName))
            {
                students.Add(new FulltimeStudent(studentName));
                noStudent.Visible = false;

            }
            else if (studentType == "Part Time" && !string.IsNullOrWhiteSpace(studentName))
            {
                students.Add(new ParttimeStudent(studentName));
                noStudent.Visible = false;
            }
            else if (studentType == "Coop" && !string.IsNullOrWhiteSpace(studentName))
            {
                students.Add(new CoopStudent(studentName));
                noStudent.Visible = false;
            }
            foreach (Student s in students)
            {
                TableRow rowNew = new TableRow();
                tableResults.Rows.Add(rowNew);

                TableCell cell = new TableCell();
                rowNew.Cells.Add(cell);
                cell.Text = s.ID.ToString();

                cell = new TableCell();
                rowNew.Cells.Add(cell);
                cell.Text = s.Name;
            }
           
            stdName.Text = " "; //to clear the textbox for next student name input
            dropDown.SelectedValue = "Select"; //to update the dropdown list value for next selection
        }
    }
}