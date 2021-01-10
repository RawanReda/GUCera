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


            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
             conn = new SqlConnection(connStr);




            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }



            if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
            {

                //If courseid can be obtained from the request
                //take it from the request and store it
                int s = Int32.Parse((String)Request.QueryString["cid"]);
                courseID = s;



            }

            Literal1.Text = "<a href='InstructorHome.aspx'> Home</a>";

        }

        protected void certify(object sender, EventArgs e)
        {
            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (inputID.Text == "") { msg.Text = "<p style = 'color:red' > Please Enter a StudentID </p>"; }
            else
            {
                int student =Int32.Parse(inputID.Text);

            int id = (int)Session["field1"];

           
            //Add input of procedure
            cmd.Parameters.Add(new SqlParameter("@cid", courseID));
            cmd.Parameters.Add(new SqlParameter("@sid", student));
            cmd.Parameters.Add(new SqlParameter("@insID", id));
            DateTime date = DateTime.Now;
            cmd.Parameters.Add(new SqlParameter("@issueDate", date));


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
 //               msg.Text = "<p style='color: green'> Certified! </p>";


                SqlCommand cmd2 = new SqlCommand("SELECT * FROM StudentCertifyCourse WHERE (sid =" + student +" AND cid ="+ courseID +")", conn);

                conn.Open();
                SqlDataReader rdr = cmd2.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.HasRows)
                {

                    msg.Text = "<p style='color: green'> Certified! </p>";
                    
                }
                else
                {
                    msg.Text = " <p style ='color: Red'> Can't certify this Student because he/she hasn't taken or completed the course </p> ";
                }
                conn.Close();
            }
            catch(SqlException ex) {
                    msg.Text = ("<p style='color:red'> Already Certified  </p>");

                }

            }






        }
    }
}