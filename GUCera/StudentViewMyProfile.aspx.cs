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
    public partial class StudentViewMyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            //To read the input from the user
          //  int sid = Int16.Parse(input.Text);

            /*create a new SQL command which takes as parameters the name of the stored procedure and
             the SQLconnection name*/
            SqlCommand myprofile = new SqlCommand("viewMyProfile", conn);
            myprofile.CommandType = CommandType.StoredProcedure;




            myprofile.Parameters.Add(new SqlParameter("@id", (int) Session["field1"]));

            //Executing the SQLCommand
            conn.Open();
            SqlDataReader rdr = myprofile.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {

                int id1 = rdr.GetInt32(rdr.GetOrdinal("id"));

            //    float gpa = rdr.GetFloat(rdr.GetOrdinal("gpa"));

                int id2 = rdr.GetInt32(rdr.GetOrdinal("id"));

                string fn = rdr.GetString(rdr.GetOrdinal("firstName"));

                string ln = rdr.GetString(rdr.GetOrdinal("lastName"));

                string pass = rdr.GetString(rdr.GetOrdinal("password"));

           //     int gender = rdr.GetInt16(rdr.GetOrdinal("gender"));

           //     string email = rdr.GetString(rdr.GetOrdinal("email"));

            //    string address = rdr.GetString(rdr.GetOrdinal("address"));

                Label lbl_id1 = new Label();
                lbl_id1.Text = "ID : " +id1 ;
                form1.Controls.Add(lbl_id1);
            }

       //     string field1 = (string)(Session["field1"]);
        //    Response.Write(field1);
        }

        protected void enter(object sender, EventArgs e)
        {
           

        }
    }
}