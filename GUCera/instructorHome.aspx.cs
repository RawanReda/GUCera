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

            cmd.Parameters.Add(new SqlParameter("@creditHourse", CrHrs));
            cmd.Parameters.Add(new SqlParameter("@name", Course_name));
            cmd.Parameters.Add(new SqlParameter("@price", pri));
            cmd.Parameters.Add(new SqlParameter("@instructorId", isID));




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
            cmd.Parameters.Add(new SqlParameter("@instrId", (int) Session["field1"]));
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);


            while (rdr.Read())


            {
                int cid = rdr.GetInt32(rdr.GetOrdinal("id"));
                string cname = rdr.GetString(rdr.GetOrdinal("name"));
                int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));

                title.Text = "<h3> My Courses </h3>";

                Panel card = new Panel();

                Button MyButton = new Button();
                //MyButton.UseSubmitBehavior = false;
                //MyButton.PostBackUrl = "UpdateCourse.aspx?pid=" + cid.ToString();
                MyButton.Text = "Update Course Details";
                Label lbl_cid = new Label();
                lbl_cid.Text = "<h4 style='" +
                                                    "margin-left: 40px;" +
                                                    "font-weight: 700;" +
                                                    "font-size: 18px;'>" + cid + "</h4>";
                card.Controls.Add(lbl_cid);

                Label lbl_cname = new Label();
                lbl_cname.Text = "<div >" + cname + "</div>";
                card.Controls.Add(lbl_cname);
                Label lbl_crs = new Label();
                lbl_crs.Text = "<div>" + ch + "</div>";
                card.Controls.Add(lbl_crs);

                card.Controls.Add(MyButton);

                CourseList.Controls.Add(card);


            }


        }
    }
}