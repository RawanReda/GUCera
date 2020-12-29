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
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registration(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            string firstn = firstname.Text;
            string lastn = lastname.Text;
            string pass = password.Text;
            string em = email.Text;
            string add = address.Text;
            string g = gender.Text;

            SqlCommand studentreg = new SqlCommand("studentRegister", conn);
            studentreg.CommandType = CommandType.StoredProcedure;

            studentreg.Parameters.Add(new SqlParameter("@first_name", firstn));
            studentreg.Parameters.Add(new SqlParameter("@last_name", lastn));
            studentreg.Parameters.Add(new SqlParameter("@password", pass));
            studentreg.Parameters.Add(new SqlParameter("@email", em));
            if (g == "F")
            {

                studentreg.Parameters.Add(new SqlParameter("@gender", 1));
            }
            else
            {
                studentreg.Parameters.Add(new SqlParameter("@gender", 0));
            }
            studentreg.Parameters.Add(new SqlParameter("@address", add));

            conn.Open();
            studentreg.ExecuteNonQuery();
            conn.Close();



        }
    }
}