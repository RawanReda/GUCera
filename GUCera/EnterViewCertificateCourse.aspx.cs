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
    public partial class EnterViewCertificateCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (course_Id0.Text == "")
            {
                Literal1.Text = ("<p style='color:red'> Please enter a course ID. ");

            }
            else
            {
                int id1 = Int16.Parse(course_Id0.Text);
                Session["CertificateCourseId"] = id1;
                //Response.Redirect("StudentViewCertificates.aspx", true);
                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);

                SqlCommand cmd = new SqlCommand("viewCertificate", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cid", Session["CertificateCourseId"]));
                cmd.Parameters.Add(new SqlParameter("@sid", (Session["field1"]).ToString()));
                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {

                        DateTime issueDate = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));


                        Literal1.Text = "<p style='color:black'  font-weight: bolder> Certificate issued on: " + issueDate;



                    }
                }
                else
                {
                    Literal1.Text = "<p style='color:red'> Student not enrolled in course or did not finish course.";
                }


            
        }
        }
    }
}