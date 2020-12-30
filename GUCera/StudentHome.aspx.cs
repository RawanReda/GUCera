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
    }
}