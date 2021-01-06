using System;
using System.Collections.Generic;
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

        }

        protected void myprofile(object sender, EventArgs e)
        {
            Response.Redirect("StudentViewMyProfile.aspx", true);
        }

        protected void allcourses(object sender, EventArgs e)
        {
            Response.Redirect("AllCourses.aspx", true);
        }

        protected void enroll(object sender, EventArgs e)
        {
            Response.Redirect("EnrollInACourse.aspx", true);
        }

        protected void creditcard(object sender, EventArgs e)
        {
            Response.Redirect("AddCreditCard.aspx", true);
        }

        protected void promocodes(object sender, EventArgs e)
        {
            Response.Redirect("ViewMyPromoCodes.aspx", true);
        }



       
        protected void Feedback(object sender, EventArgs e)
        {
            Response.Redirect("StudentAddFeedback.aspx", true);
        }

        protected void Certificates(object sender, EventArgs e)
        {
            int id1 = Int16.Parse(course_Id0.Text);
            Session["CertificateCourseId"] = id1;
            Response.Redirect("StudentViewCertificates.aspx", true);
        }

        protected void ViewAssign(object sender, EventArgs e)
        {
            int id1 = Int16.Parse(course_Id.Text);
            Session["AssignCourseId"] = id1;
            Response.Redirect("StudentViewAssignments.aspx", true);
        }

        protected void SubmitAssign(object sender, EventArgs e)
        {
            Response.Redirect("StudentSubmitAssignment.aspx", true);
        }

        protected void CheckGrade(object sender, EventArgs e)
        {
            Response.Redirect("StudentViewAssignGrade.aspx", true);
        }


        protected void course_Id_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void course_Id_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void addMobile(object sender, EventArgs e)
        {
            Response.Redirect("AddMobileNumber.aspx", true);

        }

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