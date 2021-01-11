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
            else {  
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
                    ////Get the value of the attribute name in the Company table
                    //int AssignNo = rdr.GetOrdinal("number");
                    ////Get the value of the attribute field in the Company table
                    //string AssignType = rdr.GetString(rdr.GetOrdinal("type"));
                    //int fullGrade = rdr.GetOrdinal("fullgrade");
                    //int weight = rdr.GetOrdinal("weight");
                    //DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                    //string content = rdr.GetString(rdr.GetOrdinal("content"));

                    ////Create a new label and add it to the HTML form
                    //Label AssignNo1 = new Label();
                    //AssignNo1.Text = "Assignment Number: " + AssignNo + " , ";
                    //form1.Controls.Add(AssignNo1);

                    //Label AssignType1 = new Label();
                    //AssignType1.Text = "Assignment Type: " + AssignType + " , ";
                    //form1.Controls.Add(AssignType1);

                    //Label FG1 = new Label();
                    //FG1.Text = "Full grade: " + fullGrade + " , ";
                    //form1.Controls.Add(FG1);

                    //Label W1 = new Label();
                    //AssignType1.Text = "Full weight: " + weight + " , ";
                    //form1.Controls.Add(W1);

                    //Label D1 = new Label();
                    //D1.Text = "Deadline: " + deadline + " , ";
                    //form1.Controls.Add(D1);

                    //Label C1 = new Label();
                    //C1.Text = "Content: " + content + "  <br /> <br />";
                    //form1.Controls.Add(C1);

            //    }
            //}
            //else {
              //  NoEntries.Text = "No assignments at the moment or you are not registered in this course.";
            //}
           
           
        }
    }

      
    
}