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

                Name1.Text = "<h2> Hello, " + Name + "! </h2>";
            }

            conn.Close();

        }
        protected void addMobile(object sender, EventArgs e)
        {
            Response.Redirect("AddMobileNumber.aspx", true);

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

            if (cname.Text == "" || chours.Text == "" || price.Text == "")
            {
                msg.Text = "<p style='color:red '> Please fill in all fields </p>";


            }
            else
            {
                try
                {
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
                    msg.Text = "<p style='color:green '>" + Course_name +" added Successfully! Wait for Admin acceptance. </p>";

                }
                catch (SqlException ex) {
                    msg.Text = ("<p style='color:red'> Error:" + ex.Number + " " + ex.Message + "</p>");


                }
            }
                


        }

        protected void viewaccCourses(object sender, EventArgs e)

        {
            msg.Text = "";

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

            Literal l2 = new Literal();
            if (!rdr.HasRows)
            {

                l2.Text = "<p style='color : Red'> No Accepted Courses Yet</p>";
                CourseList.Controls.Add(l2);
            }
            else
            {
                l2.Text = "";
                while (rdr.Read())
                {
                    int cid = rdr.GetInt32(rdr.GetOrdinal("id"));
                    string cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                    //String cnt = "";
                    SqlConnection conn2 = new SqlConnection(connStr);

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course Where id=" + cid, conn2);
                    cmd2.CommandType = CommandType.Text;
                    
                    conn2.Open();
                    SqlDataReader rdr2 = cmd2.ExecuteReader(CommandBehavior.SingleRow);
                    rdr2.Read();
                    String courseContent;
                    try
                    {
                        courseContent = rdr2.GetString(rdr2.GetOrdinal("content"));
                    }
                    catch {
                        courseContent = "--";
                    }
                    conn2.Close();



                    title.Text = "<h3> My Accepted Courses </h3>";

                    Panel card = new Panel();
                    card.CssClass = "cards";


                    Button MyButtonU = new Button();
                    MyButtonU.UseSubmitBehavior = false;
                    MyButtonU.PostBackUrl = "inscourseUpdate.aspx?cid=" + cid.ToString();
                    MyButtonU.Text = "Update Course Content";


                    Button MyButtonF = new Button();
                    MyButtonF.UseSubmitBehavior = false;
                    MyButtonF.PostBackUrl = "vFeedback.aspx?cid=" + cid.ToString();
                    MyButtonF.Text = "View Feedback";


                    Button MyButtonA = new Button();
                    MyButtonA.UseSubmitBehavior = false;
                    MyButtonA.PostBackUrl = "InstructorAssignments.aspx?cid=" + cid.ToString();
                    MyButtonA.Text = "Assignments";

                    Button MyButtonC = new Button();
                    MyButtonC.UseSubmitBehavior = false;
                    MyButtonC.PostBackUrl = "InstructorCertifies.aspx?cid=" + cid.ToString();
                    MyButtonC.Text = "Issue a Certificate to a Student";

                    Literal l1 = new Literal();

                    l1.Text = "<h4>" + "CourseID " + cid + "</h4>" +
                     "<div> Name: " + cname + "</div>" +
                     "<div> Credit Hours: " + ch + "</div>"+
                     "<div style='margin-bottom: 17px;'> Content: " + courseContent + "</div>"; ;

                   
                    Label line = new Label();
                    line.Text = "<hr>";

                   
                    card.Controls.Add(l1);
                    card.Controls.Add(MyButtonU);
                    card.Controls.Add(MyButtonF);
                    card.Controls.Add(MyButtonA);
                    card.Controls.Add(MyButtonC);
                    card.Controls.Add(line);
                    CourseList.Controls.Add(card);


                }
            }




        }

        protected void viewmyCourses(object sender, EventArgs e)

        {
            msg.Text = "";

            int usr = (int)Session["field1"];
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE instructorId =" + usr, conn);
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            Literal l2 = new Literal();
            if (!rdr.HasRows)
            {
                l2.Text = "<p style='color : Red'> No Added Courses Yet</p>";
                CourseList.Controls.Add(l2);
            }
            else
            {
                l2.Text = "";
                while (rdr.Read())
                {
                    int cid = rdr.GetInt32(rdr.GetOrdinal("id"));
                    string cname = rdr.GetString(rdr.GetOrdinal("name"));
                    int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                    //String cnt = rdr.GetString(rdr.GetOrdinal("content"));

                    SqlConnection conn2 = new SqlConnection(connStr);

                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Course Where id=" + cid, conn2);
                    cmd2.CommandType = CommandType.Text;

                    conn2.Open();
                    SqlDataReader rdr2 = cmd2.ExecuteReader(CommandBehavior.SingleRow);
                    rdr2.Read();
                    String courseContent;
                    try
                    {
                        courseContent = rdr2.GetString(rdr2.GetOrdinal("content"));
                    }
                    catch
                    {
                        courseContent = "--";
                    }
                    conn2.Close();



                    title.Text = "<h3> My Added Courses </h3>";

                    Panel card = new Panel();
                    card.CssClass = "cards";


                    Button MyButtonU = new Button();
                    MyButtonU.UseSubmitBehavior = false;
                    MyButtonU.PostBackUrl = "inscourseUpdate.aspx?cid=" + cid.ToString();
                    MyButtonU.Text = "Update Course Content";


                    Literal l1 = new Literal();

                    l1.Text = "<h4>" + "CourseID " + cid + "</h4>" +
                     "<div> Name: " + cname + "</div>" +
                     "<div> Credit Hours: " + ch + "</div>" +
                     "<div style='margin-bottom: 17px;'> Content: " + courseContent + "</div>"; ;


                    Label line = new Label();
                    line.Text = "<hr>";


                    card.Controls.Add(l1);
                    card.Controls.Add(MyButtonU);
                    card.Controls.Add(line);
                    CourseList.Controls.Add(card);


                }
            }




        }

        protected void addno_Click(object sender, EventArgs e)
        {

        }
    }
}