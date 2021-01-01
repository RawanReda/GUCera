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
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.Read())
                {
                    int feedbackN = rdr.GetInt32(rdr.GetOrdinal("number"));
                    string comment = rdr.GetString(rdr.GetOrdinal("comment"));
                    int likes = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));
                   

                    //before we output the feedback details to the form, we need the course name by using a SQL query
                    cmd = new SqlCommand("select * from Course where id=" + courseID, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Close();
                    conn.Open();
                    rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    rdr.Read();
                    String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                    conn.Close();


                    Literal fb = new Literal();


                    fb.Text = 
                       "<div >" +
                       "<h4>" +
                       "Course: " + courseName + "</h4>" +
                       "<div >"+
                       "<p> Feedback Number: " + feedbackN + "</p>" +
                       "<p> Comment: " + comment + "</p>" +
                       "<p> Number of Likes: " + likes + "</p>" +
                       "</div>" +
                       "</div>";

                    form1.Controls.Add(fb);


                }
                else
                {
                    //if the row has not been found then no course Feedback can be found matching this course id and this userID
                    Response.Write("No Feedback Found.");
                }

            }

        }
    }
}