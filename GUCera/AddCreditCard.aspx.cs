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
    public partial class AddCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

         //   int id = Int16.Parse(ID.Text);
            string number = Number.Text;
            string cardholdername = CHName.Text;
            DateTime expirydate = DateTime.Parse(EXDate.Text);
            int cvv = Int16.Parse(CVV.Text);

            SqlCommand addcd = new SqlCommand("addCreditCard", conn);
            addcd.CommandType = CommandType.StoredProcedure;


            addcd.Parameters.Add(new SqlParameter("@sid", (int)Session["field1"]));
            
            addcd.Parameters.Add(new SqlParameter("@number", number));

            addcd.Parameters.Add(new SqlParameter("@cardHolderName", cardholdername));

            addcd.Parameters.Add(new SqlParameter("@expiryDate", expirydate));

            addcd.Parameters.Add(new SqlParameter("@cvv", cvv));

            conn.Open();
            addcd.ExecuteNonQuery();
            conn.Close();

        }
    }
}