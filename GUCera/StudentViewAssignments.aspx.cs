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
    public partial class StudentViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);



            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }

            //SqlCommand cmd = new SqlCommand("viewAssign", conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add(new SqlParameter("@courseId", Session["AssignCourseId"]));
            //cmd.Parameters.Add(new SqlParameter("@Sid", (Session["field1"]).ToString()));
            //conn.Open();


            //        SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        sqlDa.Fill(dt);
            //if (dt.Rows.Count == 0)
            //{
            //    NoEntries.Text = "<p style='color:red '>  No assignments at the moment or you are not registered in this course.";
            //}
            //else {  
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (course_ID.Text == "")
            {
                NoEntries.Text = ("<p style='color:red'> Please enter a course ID. ");

            }
            else
            {
                int id1 = Int16.Parse(course_ID.Text);
                Session["AssignCourseId"] = id1;
                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);



                if (Session["field1"] == null)
                {
                    Response.Redirect("Error.aspx");
                }

                SqlCommand cmd = new SqlCommand("viewAssign", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@courseId", Session["AssignCourseId"]));
                cmd.Parameters.Add(new SqlParameter("@Sid", (Session["field1"]).ToString()));
                conn.Open();


                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    //sqlDa.DataSource = null;
                   GridView1.DataSource = null;
                    GridView1.DataBind();
                    NoEntries.Text = "<p style='color:red '>  No assignments at the moment or you are not registered in this course.";
                }
                else
                {
                    NoEntries.Text = ""; 
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }

      
    
}