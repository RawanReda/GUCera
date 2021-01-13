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

                h.InnerText = "Certify a student taking the course of ID: "+ courseID;



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


                SqlCommand cmd2 = new SqlCommand("SELECT * FROM StudentCertifyCourse WHERE (sid =" + student +" AND cid ="+ courseID +")", conn);

                conn.Open();
                SqlDataReader rdr = cmd2.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.HasRows)
                {

                    msg.Text = "<p style='color: green'> Certified! </p>";
                    
                }
                else
                {
                        conn.Close();
                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM Student WHERE id=" + student, conn);

                        conn.Open();
                        SqlDataReader rdr2 = cmd3.ExecuteReader(CommandBehavior.SingleRow);

                        if (rdr2.HasRows) {
                             msg.Text = " <p style ='color: Red'> Can't certify this Student because he/she hasn't taken or completed the course.</p> ";

                        }

                        else
                        msg.Text = " <p style ='color: Red'> This is not a student.</p> ";
                    }
                    conn.Close();
            }
            catch(SqlException ex) {
                    if (ex.Message.Contains("duplicate")) { 
                    msg.Text = ("<p style='color:red'> Already Certified. </p>");
                    }
                    else msg.Text = "<p style='color:red'>"+ ex.Message+ "</p>";

                }

            }


        }
    }
