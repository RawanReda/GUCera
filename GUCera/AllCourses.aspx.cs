using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AllCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }

            int i = 0;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));

                Label lbl_CourseName = new Label();
                lbl_CourseName.Text = "Course Name  :  " +courseName +"  ";
                form1.Controls.Add(lbl_CourseName);

                int cid = rdr.GetInt32(rdr.GetOrdinal("id"));

                Label lbl_id = new Label();
                lbl_id.Text =  "Course Id  :  "+cid + "  ";
                form1.Controls.Add(lbl_id);

                int ch = rdr.GetInt32(rdr.GetOrdinal("creditHours"));

                Label lbl_ch = new Label();
                lbl_ch.Text = "CreditHours  :  "+ch + "  ";
                form1.Controls.Add(lbl_ch);

                String cd = rdr.GetString(rdr.GetOrdinal("courseDescription"));

                Label lbl_cd = new Label();
                lbl_cd.Text = "courseDescription  :  " + cd + "  ";
                form1.Controls.Add(lbl_cd);

                decimal p = rdr.GetDecimal(rdr.GetOrdinal("price"));

                Label lbl_p = new Label();
                lbl_p.Text = "Price  :  " + p + "  ";
                form1.Controls.Add(lbl_p);

                String cc = rdr.GetString(rdr.GetOrdinal("content"));

                Label lbl_cc = new Label();
                lbl_cc.Text = "CourseContent  :  " + cc + "  ";
                form1.Controls.Add(lbl_cc);

                int inst = rdr.GetInt32(rdr.GetOrdinal("instructorId"));

                Label lbl_inst = new Label();
                lbl_inst.Text = "instructorId  :  " + inst +"<br/>  <br/> ";
                form1.Controls.Add(lbl_inst);





                /*   Label lbl = new Label();
                   lbl.Text = "<a href='EnrollInACourse.aspx";
                   form1.Controls.Add(lbl);*/

                /*   using (Button b1 = new Button())
                   {
                       Response.Redirect("StudentAddFeedback.aspx", true);
                   }*/

                /* Button b1 = new Button();
                 b1.UseSubmitBehavior = false;
                 b1.PostBackUrl = "EnrollInACourse.aspx";
                 b1.Text = "Enroll";*/

                //    txt.Text = "<a href='EnrollInACourse.aspx";
                txt.Text = "<a href='EnrollInACourse.aspx?sid=" + Session["field1"] + "'>Enroll</a>";


                i = 1;
            }
            if (i == 0)
            {
              

                txt1.Text = "<p style='color:red '> The Admin has not added any courses yet. </p>";
            }
       
        }

        }
    }
