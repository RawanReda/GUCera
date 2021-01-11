using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class EnterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);




            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (course_Id.Text == "")
            {
                Literal1.Text = ("<p style='color:red'> Please enter a course ID. ");

            }
            else
            {
                int id1 = Int16.Parse(course_Id.Text);
                Session["AssignCourseId"] = id1;
                Response.Redirect("StudentViewAssignments.aspx", true);
            }
        }
    }
}