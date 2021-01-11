using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);




            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }
        }

      

    


     
     



       
       /* protected void Feedback(object sender, EventArgs e)
        {
            Response.Redirect("StudentAddFeedback.aspx", true);
        }*/

        //protected void Certificates(object sender, EventArgs e)
        //{
        //    int id1 = Int16.Parse(course_Id0.Text);
        //    Session["CertificateCourseId"] = id1;
        //    Response.Redirect("StudentViewCertificates.aspx", true);
        //}

        //protected void ViewAssign(object sender, EventArgs e)
        //{
        //    int id1 = Int16.Parse(course_Id.Text);
        //    Session["AssignCourseId"] = id1;
        //    Response.Redirect("StudentViewAssignments.aspx", true);
        //}

        //protected void SubmitAssign(object sender, EventArgs e)
        //{
        //    Response.Redirect("StudentSubmitAssignment.aspx", true);
        //}

        //protected void CheckGrade(object sender, EventArgs e)
        //{
        //    Response.Redirect("StudentViewAssignGrade.aspx", true);
        //}


        //protected void course_Id_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        //protected void course_Id_TextChanged1(object sender, EventArgs e)
        //{

        //}

     

        //protected void SubmitAssign(object sender, EventArgs e)
        //{

        //}

        //protected void ViewAssign(object sender, EventArgs e)
        //{
        //    Response.Redirect("StudentViewAssignments.aspx", true);
        //}

        //protected void CheckGrade(object sender, EventArgs e)
        //{

        //}
    }
}