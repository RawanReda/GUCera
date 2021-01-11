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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            //To read the input from the user
            int id = Int16.Parse(ID.Text);
            string password = Password.Text;

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand loginproc = new SqlCommand("userLogin", conn);
            loginproc.CommandType = CommandType.StoredProcedure;



            //pass parameters to the stored procedure
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", password));

            //Save the output from the procedure
            SqlParameter sucess = loginproc.Parameters.Add("@success", SqlDbType.Int);
            sucess.Direction = ParameterDirection.Output;

            SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
            type.Direction = ParameterDirection.Output;

            //Executing the SQLCommand
            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if (sucess.Value.ToString().Equals("1"))
            {
                //To send response data to the client side (HTML)
                Response.Write("Passed");
                /*ASP.NET session state enables you to store and retrieve values for a user
                as the user navigates ASP.NET pages in a Web application.
                This is how we store a value in the session*/
                
                Session["field1"] = id;

                if (type.Value.ToString().Equals("1"))
                {
                     Response.Redirect("Admin Page.aspx", true);
                }
                else if (type.Value.ToString().Equals("0"))
                {
                    Response.Redirect("instructorHome.aspx", true);
                }
                else if (type.Value.ToString().Equals("2")) {
                    Response.Redirect("StudentHome.aspx", true);
                }


            }
            else
            {

                error.Text = "<p style='color:red;'> UserID or Password don't match our records. </p>";
        

            }
        }

        protected void StudentReg(object sender, EventArgs e)
        {
            Response.Redirect("StudentRegistration.aspx", true);
        }
        protected void InstructorReg(object sender, EventArgs e)
        {
            Response.Redirect("InstructorRegistration.aspx", true);
        }
    }
}
    