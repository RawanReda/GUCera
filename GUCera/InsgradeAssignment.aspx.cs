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
    public partial class InsgradeAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int courseID;
            int assno;
            string type;
            SqlConnection conn;
            int id;
            int sid;


            if (!string.IsNullOrEmpty(Request.QueryString["sid"]))
            {



                string connStr = ConfigurationManager.ConnectionStrings["GUCera"].ToString();
                conn = new SqlConnection(connStr);
                int s = Int32.Parse((String)Request.QueryString["cid"]);
                int an = Int32.Parse((String)Request.QueryString["assignmentNumber"]);
                string at = ((String)Request.QueryString["type"]);
                int sidin = Int32.Parse(((String)Request.QueryString["sid"]));
                courseID = s;
                assno = an;
                type = at;
                sid = sidin;


                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTakeAssignment WHERE cid =" + courseID + "AND sid =" + sid + "AND assignmentNumber =" + assno + "AND assignmenttype =" + type, conn);
                cmd.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);

                if (rdr.Read())
                {
                    conn.Close();
                    conn.Open();
                    rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    rdr.Read();
                    head.Text =
                            "<p>CourseID " + courseID + "</p>" +
                            "<p>Assignment#" + assno + " of Type:" + type + "</p>" +
                            "Update Grade of: " +
                            "<p> StudentID " + sid + "</p>";


                    conn.Close();



                }
            }
            else Response.Redirect("No Student Data was found");




        }


    }
}