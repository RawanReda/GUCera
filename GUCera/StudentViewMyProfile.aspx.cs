using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

               Decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("gpa"));

                string fn = rdr.GetString(rdr.GetOrdinal("firstName"));

                string ln = rdr.GetString(rdr.GetOrdinal("lastName"));

                string pass = rdr.GetString(rdr.GetOrdinal("password"));

                //int gender = Convert.ToInt32(rdr.GetSqlBinary(rdr.GetOrdinal("gender")).ToString(),16);
                //int gender=  int.Parse((rdr.GetSqlBinary(rdr.GetOrdinal("gender"))).ToString(), System.Globalization.NumberStyles.HexNumber);
                //var gender = rdr.GetSqlBinary(rdr.GetOrdinal("gender")).Value;
                //var gender = rdr.GetSqlBinary(rdr.GetOrdinal("gender"));

                //SqlDbType.Binary.GetType g = rdr.GetSqlBinary(rdr.GetOrdinal("gender"));

                //   Byte[] gender = (byte[])rdr.GetSqlBinary(rdr.GetOrdinal(" gender"));

                string s = "";
                Byte[] gender = (byte[])rdr["gender"];
                for(int i=0; i<gender.Length; i++)
                {
                    if (gender[i].Equals(1))
                        s = "F";
                    else
                        if (gender[i].Equals(0))
                        s = "M";
                }

            //    long g1 = rdr.GetByte(gender);
                /*  string g2 = g1.ToString();
                string gender = Encoding.UTF8.GetString(g1);
                    if (gender.Equals(1))
                    {
                        g2 = "F";
                    }
                    else
                    {
                        g2 = "M";
                    }
    */
                string email = rdr.GetString(rdr.GetOrdinal("email"));

               string address = rdr.GetString(rdr.GetOrdinal("address"));

                Label lbl_id1 = new Label();
                lbl_id1.Text = "ID : " + id1;
                form1.Controls.Add(lbl_id1);

                Label lbl_fn = new Label();
                lbl_fn.Text = "   First Name : " + fn;
                form1.Controls.Add(lbl_fn);

                Label lbl_ln = new Label();
                lbl_ln.Text = "   Last Name : " + ln;
                form1.Controls.Add(lbl_ln);

                Label lbl_pass = new Label();
                lbl_pass.Text = "   Password : " + pass;
                form1.Controls.Add(lbl_pass);

                Label lbl_e = new Label();
                lbl_e.Text = "   Email : " + email;
                form1.Controls.Add(lbl_e);

                Label lbl_gender = new Label();
                lbl_gender.Text = "   Gender : "+ s;
                form1.Controls.Add(lbl_gender);

                Label lbl_add = new Label();
                lbl_add.Text = "   Address : " + address;
                form1.Controls.Add(lbl_add);

                Label lbl_gpa = new Label();
                lbl_gpa.Text = "   GPA : " + gpa +"<br></br>";
                form1.Controls.Add(lbl_gpa);

            }

    
        }

      
    }
}