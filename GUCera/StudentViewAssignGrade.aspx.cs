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
    public partial class StudentViewAssignGrade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckNow_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            if (Assigntype.Text == "" || AssignNo.Text == "" || CourseID.Text == "") {
                Grade.Text = "<p style='color:red '> Please fill in all fields </p>";
            }
            else { 
            string AssignT = Assigntype.Text;
            int AssignN = Int16.Parse(AssignNo.Text);
            int Course_ID = Int16.Parse(CourseID.Text);

            SqlCommand cmd = new SqlCommand("viewAssignGrades", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@assignType", AssignT));
            cmd.Parameters.Add(new SqlParameter("@assignnumber", AssignN));
            cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
            cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));
            SqlParameter grade = cmd.Parameters.Add("@assignGrade ", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;

           
           
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (grade.Value.ToString() != "")
                    {
                        Grade.Text = ("<p style='color:green'>Assignment grade for the entered information: " + grade.Value);
                    }
                    else {
                        Grade.Text = ("<p style='color:red'>This assignment has not been graded yet. ");
                    }



                }
                catch (SqlException ex)
                {
                    Grade.Text = ("<p style='color:red'> Error:" + ex.Number + " " + ex.Message + "</p>");


                }

            }
        }
    }
}