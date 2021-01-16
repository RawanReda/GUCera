using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentViewCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            theDiv.Visible = false; 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (course_ID.Text == "")
            {
                NoEntries.Text = ("<p style='color:red'> Please enter a course ID. ");

            }
            else
            {
                int id1 = Int16.Parse(course_ID.Text);
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
                    DateTime issueDate = new DateTime(2019, 05, 09, 9, 15, 0);
                    while (rdr.Read())
                    { 
                        theDiv.Visible = true;
                        issueDate = rdr.GetDateTime(rdr.GetOrdinal("issueDate"));
                        }
                    conn.Close();
                    conn.Open();
                        SqlCommand cmd1 = new SqlCommand("ViewMyProfile", conn);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.Add(new SqlParameter("@id", (int)Session["field1"]));
                        SqlDataReader rdr1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);
                        
                    string Name = "";
                        while (rdr1.Read())
                        {
                            string Firstn = rdr1.GetString(rdr1.GetOrdinal("firstName"));
                            string Lastn = rdr1.GetString(rdr1.GetOrdinal("lastName"));
                            Name = Firstn + " " + Lastn;
                           
                        }
                        NoEntries.Text = "";
                    SqlConnection conn2 = new SqlConnection(connStr);

                    //before we output the feedback details to the form, we need the course name by using a SQL query
                    SqlCommand cmd2 = new SqlCommand("select * from Course where id=" + id1, conn2);
                    cmd2.CommandType = CommandType.Text;

                    conn2.Open();
                    SqlDataReader rdr2 = cmd2.ExecuteReader(CommandBehavior.SingleRow);
                    rdr2.Read();
                    String courseName = rdr2.GetString(rdr2.GetOrdinal("name"));
                    conn2.Close();
                    Literal1.Text = "Congratulations " + Name +" for completing "+courseName+ " on " 
                    + " " + issueDate;



                    
                }
                else
                {
                    theDiv.Visible = false;
                    NoEntries.Text = "<p style='color:red'> Student not enrolled in course or did not finish course.";
                }

            }
        }
    }
}