﻿using System;
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
    public partial class AdminAllCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand AdminViewAllCourses = new SqlCommand("AdminViewAllCourses", conn);
            AdminViewAllCourses.CommandType = CommandType.StoredProcedure;

            conn.Open();

            SqlDataReader rdr = AdminViewAllCourses.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                string courseName = rdr.GetString(rdr.GetOrdinal("name"));
                int creditHours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                decimal price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                string content = rdr.GetString(rdr.GetOrdinal("content"));
                bool accepted;
                try // mesh sha8ala bardo
                {
                    if (rdr.GetOrdinal("accepted") == null || rdr.GetBoolean(rdr.GetOrdinal("accepted")))
                    {
                        accepted = false;
                    }
                    else
                    {
                        if (rdr.GetBoolean(rdr.GetOrdinal("accepted")) == true && rdr.GetBoolean(rdr.GetOrdinal("accepted")) != null) //mesh sha8ala
                        {
                            accepted = true;

                        }
                        else
                        {
                            accepted = false;
                        }
                    }
                }
                catch (Exception)
                {
                    accepted = false;
                }


                Label lbl_courseName = new Label();
                lbl_courseName.Text = "name: " +  courseName + ",                  ";
                form1.Controls.Add(lbl_courseName);

                Label lbl_creditHours = new Label();
                lbl_creditHours.Text = "  credit hours: " + creditHours + ",                  ";
                form1.Controls.Add(lbl_creditHours);

                Label lbl_price= new Label();
                lbl_price.Text = "  price: " + price + ",                  ";
                form1.Controls.Add(lbl_price);

                Label lbl_content = new Label();
                lbl_content.Text = "  content: " + content + ",                  ";
                form1.Controls.Add(lbl_content);

                Label lbl_accepted = new Label();
                lbl_accepted.Text = "  accepted: " + accepted + "  <br /> <br />";
                form1.Controls.Add(lbl_accepted);

            }
        }
    }
}