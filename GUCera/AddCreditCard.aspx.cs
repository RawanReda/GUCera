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

            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if(Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }
            //      int sid = (int)Session["field1"];
        }

        protected void add(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if(Number.Text == "" || CHName.Text == "" || EXDate.Text == "" || CVV.Text == "")
            {
                txt.Text = "<p style='color:red '> Please enter all required fields. </p>";
            }
            else {
                //   int id = Int16.Parse(ID.Text);

               
                if(Number.Text.Length > 15)
                {
                    no.Text = "<p style='color:red '> Please enter the number less than 15, otherwise it will be truncated. </p>";
                }

                if (CHName.Text.Length > 16)
                {
                    name.Text = "<p style='color:red '> Please enter the name less than 16, otherwise it will be truncated. </p>";
                }

                string number = Number.Text;
                string cardholdername = CHName.Text;
                SqlCommand addcd = new SqlCommand("addCreditCard", conn);
                addcd.CommandType = CommandType.StoredProcedure;
                int j = 0;
                int x = 0;
                try
                {
                    DateTime expirydate = DateTime.Parse(EXDate.Text);
                    addcd.Parameters.Add(new SqlParameter("@expiryDate", expirydate));
                }
                catch
                {
                    j = 1;
                    credit.Text = "<p style='color:red '> Please Enter the ExpiryDate in this format Y-M-D. </p>";
                }

                try
                {

                    int cvv = Int16.Parse(CVV.Text);
                    addcd.Parameters.Add(new SqlParameter("@cvv", cvv));
                }
                catch
                {
                    x = 1;
                    c.Text = "<p style='color:red '> Please Enter 3 numbers only. </p>";
                }



                addcd.Parameters.Add(new SqlParameter("@sid", (int)Session["field1"]));
                
            addcd.Parameters.Add(new SqlParameter("@number", number));
            addcd.Parameters.Add(new SqlParameter("@cardHolderName", cardholdername));




/*

                if (number == "" || cardholdername == "" || EXDate.Text == "" || CVV.Text == "")
                {
                    // Response.Write("Please fill in all fields");
                    // AddCD.Text = "<p style='color:red '> Please fill in all fields </p>";

                    Label lbl_error = new Label();
                    lbl_error.Text = "Please fill in all fields";
                    form1.Controls.Add(lbl_error);


                }*/
                



                    try
                    {
                  //if (no.Text != "" || name.Text != "")
                   // {
                        conn.Open();
                        addcd.ExecuteNonQuery();
                        conn.Close();
                        credit.Text = "";
                        c.Text = "";
                        txt.Text = "<p style='color:green '> Your credit card details has been added. </p>";
                 //   }
                    
                    /* Label lbl_error = new Label();
                     lbl_error.Text = "Credit card details are added";
                     form1.Controls.Add(lbl_error);*/
                 //   no.Text = "";
                  //  name.Text = "";
                   
                }
                    catch
                    {


                    /* Label lbl_error = new Label();
                     lbl_error.Text = "You are already added this credit card";
                     form1.Controls.Add(lbl_error);*/
                    if (j == 0 && x ==0)
                    {
                        credit.Text = "";
                        c.Text = "";
                        txt.Text = "<p style='color:red '> This credit card has been added before. </p>";
                        
                    }
                }
             

                }
            




        }
    }
}