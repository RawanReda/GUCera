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
    public partial class InstructorCertifies : System.Web.UI.Page
    {

        int courseID;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
            {

                //If courseid can be obtained from the request
                //take it from the request and store it
                int s = Int32.Parse((String)Request.QueryString["cid"]);
                courseID = s;

            }

        }

        protected void certify(object sender, EventArgs e)
        {
            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            int student =Int32.Parse(inputID.Text);

            int id = (int)Session["field1"];
            //Add input of procedure
            cmd.Parameters.Add(new SqlParameter("@cid", courseID));
            cmd.Parameters.Add(new SqlParameter("@sid", student));
            cmd.Parameters.Add(new SqlParameter("@insID", id));
            DateTime date = DateTime.Now;
            cmd.Parameters.Add(new SqlParameter("@issueDate", date));
           
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT * FROM StudentCertifyCourse WHERE sid =" + student , conn);
            cmd2.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (rdr.Read())
            {
                msg.Text = "Certified!";
            }
            else
            {
                msg.Text = "Can't Certify";
            }






        }
    }
}