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
    public partial class EnrolledCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);



            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }
            else {

                SqlCommand cmd = new SqlCommand("enrolledCourses", conn);
                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.Add(new SqlParameter("@sid", (Session["field1"]).ToString()));
                conn.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    //sqlDa.DataSource = null;
                    GridView1.DataSource = null;
                    GridView1.DataBind();
                    Literal1.Text = "<p style='color:red '>  No assignments at the moment or you are not registered in this course.";
                }
                else
                {
                    Literal1.Text = "";
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }


            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void ViewAssignments(object sender, EventArgs e) {
           
            int index = Convert.ToInt32((sender as LinkButton).CommandArgument.ToString());
            Session["AssignCourseId"] =index;
            Response.Redirect("StudentViewAssignments.aspx", true);
        }
        protected void ViewCertificates(object sender, EventArgs e)
        {

            int index = Convert.ToInt32((sender as LinkButton).CommandArgument.ToString());
            Session["CertificateCourseId"] = index;
            Response.Redirect("StudentViewCertificates.aspx", true);
        }
    }
}