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
    public partial class StudentSubmitAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitNow_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            string AssignT = Assigntype.Text;
            int AssignN = Int16.Parse(AssignNo.Text);
            int Course_ID = Int16.Parse(CourseID.Text);

            SqlCommand cmd = new SqlCommand("submitAssign", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@assignType", AssignT));
            cmd.Parameters.Add(new SqlParameter("@assignnumber", AssignN));
            cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
            cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));


            if (AssignT == "" || (AssignN).ToString() == "" || (Course_ID).ToString() == "")
            {
                SubmitAssignMssg.Text = "<p style='color:red '> Please fill in all fields </p>";
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    SubmitAssignMssg.Text = ("<p style='color:green'> Submission Successful");
                    


                }
                catch (SqlException ex)
                {
                    SubmitAssignMssg.Text = ("<p style='color:red'> Error:" + ex.Number + " " + ex.Message + "</p>");


                }

            }
        }
    }
}