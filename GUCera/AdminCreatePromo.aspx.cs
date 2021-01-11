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
    public partial class AdminCreatePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand createPromo = new SqlCommand("AdminCreatePromoExt", conn);
            createPromo.CommandType = CommandType.StoredProcedure;
            if (CodeB.Text.Equals("") || issueDateB.Text.Equals("") || expiryDateB.Text.Equals("") || discountB.Text.Equals(""))
            {
                Label1.Text = "Please enter all required fields";
            }
            else
            {
                string code = CodeB.Text;
                DateTime issueDate = DateTime.Parse(issueDateB.Text);
                DateTime expiryDate = DateTime.Parse(expiryDateB.Text);
                double discount = Double.Parse(discountB.Text);
                int aid = (int)Session["field1"];


                createPromo.Parameters.Add("@code", code);
                createPromo.Parameters.Add("@isuueDate", issueDate);
                createPromo.Parameters.Add("@expiryDate", expiryDate);
                createPromo.Parameters.Add("@discount", discount);
                createPromo.Parameters.Add("@adminId", aid);

                SqlParameter success = createPromo.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;


                conn.Open();
                createPromo.ExecuteNonQuery();
                conn.Close();

               
                    if (success.Value.ToString().Equals("1"))
                    {
                        Label1.Text = "This promocode already exists";
                    }
                    else
                    {
                        if (success.Value.ToString().Equals("2"))
                        {
                            Label1.Text = "You successfully created a promocode";
                        }
                    }
                

                //Response.Write("You created a promocode");


            }
        }
    }
}