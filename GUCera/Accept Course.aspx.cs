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

            string courseName = TextBox1.Text.ToString() ;
            
            SqlCommand adminViewCoursestProc = new SqlCommand("AdminViewAllCourses", conn);
            adminViewCoursestProc.CommandType = CommandType.StoredProcedure;

           
            SqlDataReader rdr;

            

            SqlCommand cmd = new SqlCommand("select * from Course where name='" + courseName +"'", conn);
            cmd.CommandType = CommandType.Text;
         
            conn.Open();
            rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            rdr.Read();
            int cid =(int)  rdr.GetInt32(rdr.GetOrdinal("id"));
            conn.Close();

            int aid = (int)Session["field1"];
            //int success =2 ;

            SqlCommand adminAcceptProc = new SqlCommand("AdminAccRejExt", conn);
            adminAcceptProc.CommandType = CommandType.StoredProcedure;

            adminAcceptProc.Parameters.Add("@adminid", aid);
            adminAcceptProc.Parameters.Add("@courseId", cid);
            //adminAcceptProc.Parameters.Add("@success", success);
            SqlParameter success = adminAcceptProc.Parameters.Add("@success", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;

            conn.Open();
            adminAcceptProc.ExecuteNonQuery();
            conn.Close();
            
            if (success.Value.ToString().Equals("1"))
            {
                Label1.Text = "You accepted a course";
            }
            else
            {
                if (success.Value.ToString().Equals("0"))
                {
                    Label1.Text = "This course is already accepted";
                }
            }
            //Response.Write("You accepted a course");
            // Response.Redirect("Admin Page.aspx", true);



        }
    }
}