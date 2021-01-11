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
    public partial class AdminIssuePromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            if (stid.Text.Equals("") || codeB.Text.Equals(""))
            {
                Label1.Text = "Please enter all the required fields";
            }
            else //lessa makhalastehashh
            {
                SqlCommand issuePromo = new SqlCommand("adminIssueExt", conn);
                issuePromo.CommandType = CommandType.StoredProcedure;

                int sid = Int16.Parse(stid.Text);
                string code = codeB.Text;

                issuePromo.Parameters.Add("@sid", sid);
                issuePromo.Parameters.Add("@pid", code);
                SqlParameter success = issuePromo.Parameters.Add("@success", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;

                conn.Open();
                issuePromo.ExecuteNonQuery();
                conn.Close();
                if(success.Value.ToString().Equals("0"))
                {
                    Label1.Text = "This promocode doesn't exist";
                }
                else
                {
                    if (success.Value.ToString().Equals("1"))
                    {
                        Label1.Text = "This student id doesn't exist";
                    }
                    else
                    {
                        if (success.Value.ToString().Equals("2"))
                        {
                            Label1.Text = "This student already has this promocode";
                        }
                        else
                        {
                            if (success.Value.ToString().Equals("3"))
                            {
                                Label1.Text = "You successfully issued a promocode to a student";
                            }
                        }
                    }
                }
                
                //Response.Write("You issued a promocode");
            }
        }
    }
}