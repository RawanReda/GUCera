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
                NoEntries.Text = "<p style='color:red '>  No assignments at the moment or you are not registered in this course.";
            }
            else
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    if (course_ID.Text == "")
        //    {
        //        NoEntries.Text = ("<p style='color:red'> Please enter a course ID. ");

        //    }
        //    else
        //    {
        //        int id1 = Int16.Parse(course_ID.Text);
        //        Session["AssignCourseId"] = id1;
        //        string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
        //        SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);



        //        if (Session["field1"] == null)
        //        {
        //            Response.Redirect("Error.aspx");
        //        }

        //        SqlCommand cmd = new SqlCommand("viewAssign", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.Add(new SqlParameter("@courseId", Session["AssignCourseId"]));
        //        cmd.Parameters.Add(new SqlParameter("@Sid", (Session["field1"]).ToString()));
        //        conn.Open();


        //        SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        sqlDa.Fill(dt);
        //        if (dt.Rows.Count == 0)
        //        {
        //            //sqlDa.DataSource = null;
        //           GridView1.DataSource = null;
        //            GridView1.DataBind();
        //            NoEntries.Text = "<p style='color:red '>  No assignments at the moment or you are not registered in this course.";
        //        }
        //        else
        //        {
        //            NoEntries.Text = ""; 
        //            GridView1.DataSource = dt;
        //            GridView1.DataBind();
        //        }
        //    }
        //}
        protected String Check(string type, string num, string cid) {
            int AssignN = Int16.Parse(num);
            int Course_ID = Int16.Parse(cid); 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
           
            SqlCommand cmd = new SqlCommand("submittedOrNot", conn);
            
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@assignType", type));
            cmd.Parameters.Add(new SqlParameter("@assignnumber", AssignN));
            cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
            cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));
            SqlParameter sucess = cmd.Parameters.Add("@state", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;
            conn.Open();
           cmd.ExecuteNonQuery();
            conn.Close();
            if (sucess.Value.ToString().Equals("1"))
            {
                return "Yes";
            }
            else {
                return "No";
            }
            }
        protected String Calculate(string type, string num, string cid, string full)
        {
            //Get the information of the connection to the database
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

                
                int AssignN = Int16.Parse(num);
                int Course_ID = Int16.Parse(cid);

                SqlCommand cmd = new SqlCommand("viewAssignGrades", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@assignType", type));
                cmd.Parameters.Add(new SqlParameter("@assignnumber", AssignN));
                cmd.Parameters.Add(new SqlParameter("@cid", Course_ID));
                cmd.Parameters.Add(new SqlParameter("@sid", Session["field1"]));
                SqlParameter grade =
                        cmd.Parameters.Add(new SqlParameter("@assignGrade ", SqlDbType.Decimal)
                        {
                            Precision = 5,
                            Scale = 2
                        });


                grade.Direction = ParameterDirection.Output;


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (grade.Value.ToString() != "")
                    {
                    return grade.Value.ToString() + "/" + full;
                    }
                    else
                    {
                    return "_/" + full; 
                       
                    }



                }
                catch (SqlException ex)
                {
                return "_"; 


                }

        }
    }
  


}