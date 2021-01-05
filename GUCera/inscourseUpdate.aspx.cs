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
    public partial class inscourseUpdate : System.Web.UI.Page
    {

        int courseID;
        SqlConnection conn;
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
            {

                //If courseid can be obtained from the request
                //take it from the request and store it
                string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                conn = new SqlConnection(connStr);
                int s = Int32.Parse((String)Request.QueryString["cid"]);
                courseID = s;

                SqlCommand cmd = new SqlCommand("select * from Course where id=" + courseID, conn);
                cmd.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    rdr.Read();
                    String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                    conn.Close();

                    title.Text = "<h2>" + courseName + "</h2>";

                }
            }
            else { Response.Redirect("No Course Data was found"); }
            redir.Text = "<a href='instructorHome.aspx'> Home</a>";


        }

        protected void updateContent(object sender, EventArgs e)
        {

            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("UpdateCourseContent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cont.Text == "")
            {
                msg.Text = "<p style='color: red'> Please enter course content</p>";
            }
            else { 

            id = (int)Session["field1"];
            String conten = cont.Text;

            cmd.Parameters.Add(new SqlParameter("@instrId", id));
            cmd.Parameters.Add(new SqlParameter("@courseId", courseID));
            cmd.Parameters.Add(new SqlParameter("@content", conten));

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            msg.Text = "<p style='color: green'> Course content updated Successfully!</p>";


            }


        }

        //protected void updateDescription(object sender, EventArgs e)
        //{
        //    //obtain connection info and create sql connection to database
        //    string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
        //    conn = new SqlConnection(connStr);

        //    //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
        //    SqlCommand cmd = new SqlCommand("UpdateCourseDescription", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    id = (int)Session["field1"];
        //    String des = desc.Text;

        //    cmd.Parameters.Add(new SqlParameter("@instrId", id));
        //    cmd.Parameters.Add(new SqlParameter("@cid", courseID));
        //    cmd.Parameters.Add(new SqlParameter("@courseDescription", des));

        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();


        //    msg.Text = "<p style='color: green'> Description Updated Successfully</p>";


        //}
    }
}