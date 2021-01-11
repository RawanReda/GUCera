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
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }

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

                    
                   NoEntries.Text = "<p style='color:green'  font-weight: bolder> Certificate issued on: " + issueDate;
                   


                }
            }
            else
            {
                NoEntries.Text = "<p style='color:red'> Student not enrolled in course or did not finish course.";
            }


        }
    }
}