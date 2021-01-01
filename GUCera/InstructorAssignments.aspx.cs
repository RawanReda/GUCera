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
    public partial class InstructorAssignments : System.Web.UI.Page
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

                SqlCommand cmd = new SqlCommand("select * from Course where id=" + courseID, conn);
                cmd.CommandType = CommandType.Text;
                conn.Close();
                conn.Open();

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.Read())
                {
                    rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    rdr.Read();
                    String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                    conn.Close();

                    title.Text = "<h2>" + courseName + "</h2>";

                }
            }
        }


        protected void define(object sender, EventArgs e)
        {


            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            int id = (int)Session["field1"];
            int num =int.Parse(ano.Text);
            string type = ty.Text.ToString();
            int fullgrade = int.Parse(full.Text);
            decimal weight = decimal.Parse(wgt.Text);
            DateTime deadline = DateTime.Parse(dead.ToString());
            string content = cnt.Text.ToString();


            //Add input of procedure
            cmd.Parameters.Add(new SqlParameter("@insId", id));
            cmd.Parameters.Add(new SqlParameter("@cid", courseID));
            cmd.Parameters.Add(new SqlParameter("@number", num));
            cmd.Parameters.Add(new SqlParameter("@type", type));
            cmd.Parameters.Add(new SqlParameter("@fullGrade", fullgrade));
            cmd.Parameters.Add(new SqlParameter("@weight", weight));
            cmd.Parameters.Add(new SqlParameter("@deadline", deadline));
            cmd.Parameters.Add(new SqlParameter("@content", content));



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();



        }


        protected void viewSubmissions(object sender, EventArgs e)
        {


            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            cmd.CommandType = CommandType.StoredProcedure;




        }

    }
}