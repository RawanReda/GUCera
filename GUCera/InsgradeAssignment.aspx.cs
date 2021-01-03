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
    public partial class InsgradeAssignment : System.Web.UI.Page
    {
        int courseID;
        int assno;
        string type;
        SqlConnection conn;
        int id;
        int sid;
        protected void Page_Load(object sender, EventArgs e)
        {
            


            if (!string.IsNullOrEmpty(Request.QueryString["cid"]))
            {



                string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                conn = new SqlConnection(connStr);
                int s = Int32.Parse((String)Request.QueryString["cid"]);
                assno = Int32.Parse((String)Request.QueryString["assignmentNumber"]);
                type = ((String)Request.QueryString["type"]);
                sid = Int32.Parse(((String)Request.QueryString["sid"]));
                courseID = s;


                head.Text =
                            "<p>CourseID " + courseID + "</p>" +
                            "Assignment#" + assno + " of type:" + type +
                            "<p> Update Grade of: " +
                            "StudentID " + sid + "</p>";
            }
            else Response.Redirect("No Data was found");

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            //obtain connection info and create sql connection to database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            conn = new SqlConnection(connStr);

            //create a new SQL command which takes as parameters the name of the stored procedure and the SQLconnection name
            SqlCommand cmd = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            id = (int)Session["field1"];
            Decimal gr = Decimal.Parse(TextBox1.Text.ToString());

            cmd.Parameters.Add(new SqlParameter("@instrId", id));
            cmd.Parameters.Add(new SqlParameter("@sid", sid));
            cmd.Parameters.Add(new SqlParameter("@cid", courseID));
            cmd.Parameters.Add(new SqlParameter("@assignmentNumber", assno));
            cmd.Parameters.Add(new SqlParameter("@type", type));
            cmd.Parameters.Add(new SqlParameter("@grade", gr));
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                msg.Text = "<p style='color: green'> Grade Updated Successfully</p>";

            }

            catch (SqlException ex)
            {
                msg.Text = ("<p style='color:red'> Error:" + ex.Number + " " + ex.Message + "</p>");


            }



        }

       
    }
}