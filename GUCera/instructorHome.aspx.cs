using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class instructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database

            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("ViewInstructorProfile", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@instrId", (int)Session["field1"]));

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                string Firstn = rdr.GetString(rdr.GetOrdinal("firstName"));
                string Lastn = rdr.GetString(rdr.GetOrdinal("lastName"));
                string Name = Firstn + " " + Lastn;

                Name1.Text = "Hello, " + Name + "!";
            }

            conn.Close();

        }


        protected void addCourse(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            int usr = (int)Session["field1"];
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("InstAddCourse", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            String Course_name = cname.Text;
            int CrHrs = int.Parse(chours.Text);
            decimal pri = decimal.Parse(price.Text);
            int isID = (int)Session["field1"];

            cmd.Parameters.Add(new SqlParameter("@creditHours", CrHrs));
            cmd.Parameters.Add(new SqlParameter("@name", Course_name));
            cmd.Parameters.Add(new SqlParameter("@price", pri));
            cmd.Parameters.Add(new SqlParameter("@instructorId", isID));


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        protected void viewmyCourses(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            int usr = (int)Session["field1"];
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("InstructorViewAcceptedCoursesByAdmin", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@instrId", (int)Session["field1"]));

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);


            while (rdr.Read())


            {
                int cid = rdr.GetInt32(rdr.GetOrdinal("id"));
                string cname = rdr.GetString(rdr.GetOrdinal("name"));
                int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));

                title.Text = "<h3> My Courses </h3>";

                Panel card = new Panel();

                Button MyButtonF = new Button();
                MyButtonF.UseSubmitBehavior = false;
                MyButtonF.PostBackUrl = "vFeedback.aspx?cid=" + cid.ToString();
                MyButtonF.Text = "View Feedback";


                Button MyButtonA = new Button();
                MyButtonA.UseSubmitBehavior = false;
                MyButtonA.PostBackUrl = "InstructorAssignments.aspx?cid=" + cid.ToString();
                MyButtonA.Text = "Assignments";


                Label lbl_cid = new Label();
                lbl_cid.Text = "<h4>" + "Course ID " + cid + "</h4>";
                card.Controls.Add(lbl_cid);
                Label lbl_cname = new Label();
                lbl_cname.Text = "<div > Name: " + cname + "</div>";
                card.Controls.Add(lbl_cname);
                Label lbl_crs = new Label();
                lbl_crs.Text = "<div style='margin-bottom: 17px;'> Credit Hours: " + ch + "</div>";
                card.Controls.Add(lbl_crs);
                Label line = new Label();
                line.Text = "<hr>";


                card.Controls.Add(MyButtonA);
                card.Controls.Add(MyButtonF);
                card.Controls.Add(line);
                CourseList.Controls.Add(card);


            }




        }
    }
}