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
    public partial class Accept_Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [Obsolete]
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int cid = Int16.Parse(TextBox1.Text);

           // string field1 = (string)(Session["field1"]);
            int aid = (int)Session["field1"];

            SqlCommand adminAcceptProc = new SqlCommand("AdminAcceptRejectCourse", conn);
            adminAcceptProc.CommandType = CommandType.StoredProcedure;

            /*SqlCommand AdminViewNonAcceptedCourses = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            AdminViewNonAcceptedCourses.CommandType = CommandType.StoredProcedure;

            conn.Open();

            SqlDataReader rdr = AdminViewNonAcceptedCourses.ExecuteReader(CommandBehavior.CloseConnection);
            int tempid;
            while (rdr.Read())
            { 
                int courseid = rdr.GetInt32(rdr.GetOrdinal("id")); // mesh sha8ala
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                
                if (TextBox1.Text.Equals(courseName))
                {
                    cid = courseid;
                }
            }*/

            adminAcceptProc.Parameters.Add("@adminid", aid);
            adminAcceptProc.Parameters.Add("@courseId", cid);

            conn.Open();
            adminAcceptProc.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "You accepted a course";
            //Response.Write("You accepted a course");
            // Response.Redirect("Admin Page.aspx", true);



        }
    }
}