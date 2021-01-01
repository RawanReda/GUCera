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

        }

        protected void creditcard(object sender, EventArgs e)
        {
            Response.Redirect("AddCreditCard.aspx", true);
        }

        protected void promocodes(object sender, EventArgs e)
        {

        }

     

        protected void Feedback(object sender, EventArgs e)
        {

        }

        protected void Certificates(object sender, EventArgs e)
        {

        }

        protected void ViewAssign(object sender, EventArgs e)
        {

        }

        protected void SubmitAssign(object sender, EventArgs e)
        {

        }

        protected void CheckGrade(object sender, EventArgs e)
        {

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