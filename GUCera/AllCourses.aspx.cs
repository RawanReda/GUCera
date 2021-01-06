using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
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

            int i = 0;

            conn.Open();

            //IF the output is a table, then we can read the records one at a time
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));

                Label lbl_CourseName = new Label();
                lbl_CourseName.Text = courseName;
                form1.Controls.Add(lbl_CourseName);

                i = 1;
            }
            if (i == 0)
            {
                Label lbl_error = new Label();
                lbl_error.Text = "The Admin has not add any courses yet.";
                form1.Controls.Add(lbl_error);
            }
            }
    }
}