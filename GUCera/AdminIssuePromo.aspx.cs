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

            SqlCommand issuePromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issuePromo.CommandType = CommandType.StoredProcedure;

            int sid = Int16.Parse(stid.Text);
            string code = codeB.Text;

            issuePromo.Parameters.Add("@sid", sid);
            issuePromo.Parameters.Add("@pid", code);

            conn.Open();
            issuePromo.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "You issued a promocode";
            //Response.Write("You issued a promocode");
        }
    }
}