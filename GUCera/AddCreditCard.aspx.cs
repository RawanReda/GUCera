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

            SqlCommand addcd = new SqlCommand("addCreditCard", conn);
            addcd.CommandType = CommandType.StoredProcedure;

            try
            {
                DateTime expirydate = DateTime.Parse(EXDate.Text);
                addcd.Parameters.Add(new SqlParameter("@expiryDate", expirydate));
            }
            catch
            {
                EXDate.Text = "";
            }
            try
            {
                int cvv = Int16.Parse(CVV.Text);
                addcd.Parameters.Add(new SqlParameter("@cvv", cvv));
            }
            catch
            {
                CVV.Text = "";
            }



            addcd.Parameters.Add(new SqlParameter("@sid", (int)Session["field1"]));

            addcd.Parameters.Add(new SqlParameter("@number", number));

            addcd.Parameters.Add(new SqlParameter("@cardHolderName", cardholdername));






            if (number == "" || cardholdername == "" || EXDate.Text == "" || CVV.Text == "")
            {
                 Response.Write("Please fill in all fields");
                // AddCD.Text = "<p style='color:red '> Please fill in all fields </p>";
               
            }
            else
            {



                try
                {
                    conn.Open();
                    addcd.ExecuteNonQuery();

                    conn.Close();

                    Response.Write("Credit card details are added");
                }
                catch
                {
                    Response.Write("You are already added this credit card");
                }
            }




        }
    }
}