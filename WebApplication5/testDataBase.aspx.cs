using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class testDataBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OrdersConnectionString"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            string sqlstr = "select * from Customers";

            SqlCommand sqlcommand = new SqlCommand(sqlstr, connection);

            connection.Open();

            SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    Label1.Text += sqlDataReader[1].ToString();
                }
            }
        }
    }
}