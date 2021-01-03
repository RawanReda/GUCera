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

            string Comment= comment.Text;
          
            int Course_ID = Int16.Parse(course_ID.Text);

            SqlCommand cmd = new SqlCommand("addFeedback", conn);
            cmd.CommandType = CommandType.StoredProcedure;

          
            cmd.Parameters.Add(new SqlParameter("@comment",Comment));
            cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
            cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));


            if (Comment == "" || Course_ID.ToString()=="")
            {
                SubmitFeedbackMssg.Text = "<p style='color:red '> Please fill in all fields </p>";
            }
            else
            {
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