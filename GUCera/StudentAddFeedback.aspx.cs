using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentAddFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNow_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

             if (comment.Text == "" || course_ID.Text == "")
                {
                    SubmitFeedbackMssg.Text = "<p style='color:red '> Please fill in all fields </p>";
                }

            else { 
          
                string Comment = comment.Text;
                int Course_ID = 0;
                if (course_ID.Text != "")
                {
                    Course_ID = Int16.Parse(course_ID.Text);
                }
            SqlCommand cmd1 = new SqlCommand();// Creating instance of SqlCommand  
            cmd1.Connection = conn; // set the connection to instance of SqlCommand  
            cmd1.CommandText = "SELECT* FROM StudentTakeCourse WHERE cid =" + Course_ID + " AND sid =" + Session["field1"] + ""; // set  
            conn.Open();                                                                                      //the sql command ( Statement )  
            cmd1.ExecuteNonQuery(); SqlDataReader rdr = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

  if (!rdr.HasRows)
            {
                SubmitFeedbackMssg.Text = ("<p style='color:red'> You are not enrolled in this course. ");
                conn.Close();
            }
            else
            {
                    conn.Close();
                SqlCommand cmd = new SqlCommand("addFeedback", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(new SqlParameter("@comment", Comment));
                cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
                cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));


             
                
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        SubmitFeedbackMssg.Text = ("<p style='color:green'> Feedback Successfully added");

                    }
                    catch (SqlException ex)
                    {
                        SubmitFeedbackMssg.Text = ("<p style='color:red'> Error:" + ex.Number + " " + ex.Message + "</p>");


                    }

                }
            }
        }
    }
}