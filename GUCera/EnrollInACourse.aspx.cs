using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class EnrollInACourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
              int sid = (int)Session["field1"];

            /*if (Session["field1"].get(null))
            {

                txt.Text = "<p style='color:red '> Please login first. </p>";
                Response.Redirect("Login.aspx", true);
            }*/
        }

        protected void Enroll(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (cid.Text == "" || instrid.Text == "")
            {
                txt.Text = "<p style='color:red '> Please enter all required fields. </p>";
            }
            else
            {
                int courseid = Int16.Parse(cid.Text);
                int instructorid = Int16.Parse(instrid.Text);

                SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
                enroll.CommandType = CommandType.StoredProcedure;


                enroll.Parameters.Add(new SqlParameter("@sid", (int)Session["field1"]));
                enroll.Parameters.Add(new SqlParameter("@cid", courseid));
                enroll.Parameters.Add(new SqlParameter("@instr", instructorid));

                txt.Text = "<p style='color:green '> You are successfully enrolled in a new course. </p>";

                try
                {
                    conn.Open();
                    enroll.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    /* Label lbl_error = new Label();
                     lbl_error.Text = "You are already enrolled in this course or didnt take this course pre-requisite.";
                     form1.Controls.Add(lbl_error);*/
                    txt.Text = "<p style='color:red '> You are already enrolled in this course. </p>";

                }


            }





        }
        }
}