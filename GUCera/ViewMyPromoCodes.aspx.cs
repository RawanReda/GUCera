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
    public partial class ViewMyPromoCodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand promocode = new SqlCommand("viewPromocode", conn);
            promocode.CommandType = CommandType.StoredProcedure;




            promocode.Parameters.Add(new SqlParameter("@sid", (int)Session["field1"]));

            //Executing the SQLCommand



            int i = 0;


            conn.Open();
            SqlDataReader rdr = promocode.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {


                string code = rdr.GetString(rdr.GetOrdinal("code"));

                DateTime isuueDate = rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));

                DateTime expiryDate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));

                decimal discount = rdr.GetDecimal(rdr.GetOrdinal("discount"));



                Label lbl_code = new Label();
                lbl_code.Text = "Code : " + code;
                form1.Controls.Add(lbl_code);

                Label lbl_id = new Label();
                lbl_id.Text = "   IssueDate : " + isuueDate;
                form1.Controls.Add(lbl_id);

                Label lbl_ed = new Label();
                lbl_ed.Text = "   ExpiryDate : " + expiryDate;
                form1.Controls.Add(lbl_ed);

                Label lbl_dis = new Label();
                lbl_dis.Text = "   Discount : " + discount;
                form1.Controls.Add(lbl_dis);


                i = 1;
               

            }
            if(i == 0)
            {
                /*Label lbl_error = new Label();
                lbl_error.Text = "You don't have any promocodes.";
                form1.Controls.Add(lbl_error);*/

                txt.Text = "<p style='color:red '> You don't have any promocodes. </p>";
            }
        }
    }
}