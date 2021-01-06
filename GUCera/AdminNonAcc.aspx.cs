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
    public partial class AdminNonAcc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand AdminNonAcc = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            AdminNonAcc.CommandType = CommandType.StoredProcedure;

            conn.Open();

            SqlDataReader rdr = AdminNonAcc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                int creditHours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                string content;
                try
                {
                     content = rdr.GetString(rdr.GetOrdinal("content"));

                }
                catch {
                    content = "--";
                }
               

                Label lbl_courseName = new Label();
                lbl_courseName.Text = "name: " + courseName + ",                  ";
                form1.Controls.Add(lbl_courseName);

                Label lbl_creditHours = new Label();
                lbl_creditHours.Text = "  credit hours: " + creditHours + ",                  ";
                form1.Controls.Add(lbl_creditHours);

                Label lbl_price = new Label();
                lbl_price.Text = "  price: " + price + ",                  ";
                form1.Controls.Add(lbl_price);

                Label lbl_content = new Label();
                lbl_content.Text = "  content: " + content + "  <br /> <br />";
                form1.Controls.Add(lbl_content);


            }
        }
    }
}