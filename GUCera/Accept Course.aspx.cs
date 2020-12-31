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
        int session;
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Session.Count; i++)    
    {    
        string value = Session[Session.Keys[i]].ToString();
                session = Int16.Parse(value);
    
        Response.Write(value);    
    }  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int cid = Int16.Parse(TextBox1.Text);

            int aid = (int)Session[Session.Keys[Session.Count-1]];  //mesh sha8ala

            SqlCommand adminAcceptProc = new SqlCommand("AdminAcceptRejectCourse", conn);
            adminAcceptProc.CommandType = CommandType.StoredProcedure;

            adminAcceptProc.Parameters.Add("@adminid", aid);
            adminAcceptProc.Parameters.Add("@courseId", cid);

            conn.Open();
            adminAcceptProc.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Admin Page.aspx", true);
            Response.Write("You accepted a course");
        }
    }
}