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
    public partial class vFeedback : System.Web.UI.Page
    {
        int courseID;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }


            if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
            {

                //If courseid can be obtained from the request
                //take it from the request and store it
                int s = Int32.Parse( (String) Request.QueryString["cid"]);
                courseID = s;

                //obtain connection info and create sql connection to database
                string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                conn = new SqlConnection(connStr);

                //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
                SqlCommand cmd = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                int id = (int) Session["field1"];
                //Add input of procedure
                cmd.Parameters.Add(new SqlParameter("@instrid", id));
                cmd.Parameters.Add(new SqlParameter("@cid", courseID));

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (!rdr.HasRows) { Response.Write("<p style='color:darkgreen'> No Feedback added for this course yet </p>"); }
                else { 
                while (rdr.Read()) { 
                    int feedbackN = rdr.GetInt32(rdr.GetOrdinal("number"));
                    string comment = rdr.GetString(rdr.GetOrdinal("comment"));
                    int likes = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));

                    SqlConnection conn2 = new SqlConnection(connStr);

                    //before we output the feedback details to the form, we need the course name by using a SQL query
                    SqlCommand cmd2 = new SqlCommand("select * from Course where id=" + courseID, conn2);
                    cmd2.CommandType = CommandType.Text;

                    conn2.Open();
                    SqlDataReader rdr2 = cmd2.ExecuteReader(CommandBehavior.SingleRow);
                    rdr2.Read();
                    String courseName = rdr2.GetString(rdr2.GetOrdinal("name"));
                    conn2.Close();
                    

                    title.Text = "<h2>"+ courseName + "</h2>";

                    Literal fb = new Literal();


                    fb.Text =

                       "<div style='background-color:lightgrey; margin:4px;padding-left: 8px;'>" +
                       "<h3> Feedback #" + feedbackN + "</h3>" +
                       " Comment: " + comment +
                       "<br>"+
                       " Number of Likes: " + likes +
                       "<hr>" +
                       "</div>";

                    form1.Controls.Add(fb);

                    
                }

                }

            }
            redir.Text = "<a href='instructorHome.aspx' style='color:white'> Home</a>";

        }
    }
}