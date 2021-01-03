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
    public partial class StudentViewCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

                    Label D1 = new Label();
                    D1.Text = "Certificate issued on: " + issueDate;
                    form1.Controls.Add(D1);


                }
            }
            else
            {
                NoEntries.Text = "Student not enrolled in course or did not finish course.";
            }


        }
    }
}