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
    public partial class AddMobileNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            if (Session["field1"] == null)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            //To read the input from the user
            if (TextBox1.Text == "")
            {
                msg.Text = "<p style='color:red'> Please Add Mobile Number</p>";
            }
            else
            {
                String mob = TextBox1.Text;

                /*create a new SQL command which takes as parameters the name of the stored procedure and
                 the SQLconnection name*/
                int id = (int)Session["field1"];

                SqlCommand cmd = new SqlCommand("addMobile", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                //pass parameters to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@ID", id.ToString()));
                cmd.Parameters.Add(new SqlParameter("@mobile_number", mob));



                //Executing the SQLCommand
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    msg.Text = "<p style='color:green'> Added Succesfully! </p>";
                }
                catch(SqlException ex)
                {
                    if (ex.Message.Contains("duplicate key")) {msg.Text="<p style='color:red'>You've already added this number </p>"; }
                    else
                    msg.Text = ex.Message;

                }
            }

        }
    }
}