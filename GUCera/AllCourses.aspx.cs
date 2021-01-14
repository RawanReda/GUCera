using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class AllCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = CommandType.StoredProcedure;

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }

            int i = 0;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {

                /* string ch = rdr.GetInt32(rdr.GetOrdinal("creditHours")) + "";
                string cd = rdr.GetString(rdr.GetOrdinal("courseDescription"));
                 string p= rdr.GetDecimal(rdr.GetOrdinal("price")) + "";
                 string cc = rdr.GetString(rdr.GetOrdinal("content")) + "";
                  int inst = rdr.GetInt32(rdr.GetOrdinal("instructorId"));

                  

                  Label lbl = new Label();
                  lbl.Text = courseName + "<br></br> " + ch + " <br></br>" + p;

                  course.Controls.Add(lbl);
                  form1.Controls.Add(course);*/

                Panel course = new Panel();
                course.BackColor = System.Drawing.Color.LightBlue;
                course.Width = 200;


                string courseName = rdr.GetString(rdr.GetOrdinal("name"));

                Label lbl_CourseName = new Label();
                lbl_CourseName.Text = "Course Name  :  " +courseName + " <br></br>";
                course.Controls.Add(lbl_CourseName);
                // form1.Controls.Add(lbl_CourseName);

                int cid = rdr.GetInt32(rdr.GetOrdinal("id"));

                   Label lbl_id = new Label();
                   lbl_id.Text =  "Course Id  :  "+cid + " <br></br>";
                   course.Controls.Add(lbl_id);
                // form1.Controls.Add(lbl_id);

                string ch;

                   try
                   {
                      ch = rdr.GetInt32(rdr.GetOrdinal("creditHours")) + "";

                      Label lbl_ch = new Label();
                     lbl_ch.Text = "CreditHours  :  " + ch + " <br></br>";
                    course.Controls.Add(lbl_ch);
                    //  form1.Controls.Add(lbl_ch);
                }
                   catch
                   {
                      ch = "";
                  }
                   String cd;

                   try
                  {
                       cd = rdr.GetString(rdr.GetOrdinal("courseDescription"));

                       Label lbl_cd = new Label();
                      lbl_cd.Text = "Course Description  :  " + cd + " <br></br>";
                      course.Controls.Add(lbl_cd);
                    //  form1.Controls.Add(lbl_cd);
                }
                  catch
                  {
                      cd = "";
                   }

                  string p;
                  try
                  {
                       p = rdr.GetDecimal(rdr.GetOrdinal("price")) + "";

                       Label lbl_p = new Label();
                       lbl_p.Text = "Price  :  " + p + " <br></br>";
                    course.Controls.Add(lbl_p);
                    //  form1.Controls.Add(lbl_p);
                }
                   catch
                  {
                       p = "";
                   }

                   string cc;

                   try
                    {

                      cc = rdr.GetString(rdr.GetOrdinal("content")) + "";

                       Label lbl_cc = new Label();
                      lbl_cc.Text = "CourseContent  :  " + cc + " <br></br>";
                 //   course.Controls.Add(lbl_cc);
                    // form1.Controls.Add(lbl_cc);

                }
                   catch
                  {
                     cc = "";
                  }

                   int inst = rdr.GetInt32(rdr.GetOrdinal("instructorId"));

                   Label lbl_inst = new Label();
                   lbl_inst.Text = "instructorId  :  " + inst + " <br></br>";
                     course.Controls.Add(lbl_inst);

                
                // form1.Controls.Add(lbl_inst);

                form1.Controls.Add(course);

               /* Label lbl = new Label();
                 lbl.Text =  "<br/>  <br/>";
                  form1.Controls.Add(lbl);*/

                ButtonCreate_Click();

                   Label lbl1 = new Label();
                  lbl1.Text =  "<br/>  <br/>";
                   form1.Controls.Add(lbl1);

                    i = 1;
                }
                if (i == 0)
                {


                   txt1.Text = "<p style='color:red '> The Admin has not added any courses yet. </p>";
            }
       
        }

        private void ButtonCreate_Click()
        {
            Button buttonDynamic = new Button
            {
                Text = "Enroll",
                Visible = true,
            };

            buttonDynamic.Click += ButtonDynamic_Click;
            //        buttonDynamic.Location = new Point(12, 12);

          //  this.Controls.Add(buttonDynamic);
            form1.Controls.Add(buttonDynamic);
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            
        }

        private void ButtonDynamic_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Click event handler!", "Message Box", MessageBoxButtons.OK);
            Response.Redirect("EnrollInACourse.aspx", true);
        }

      
    }
}