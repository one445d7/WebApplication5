using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication5
{
    public partial class resgin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AcountConnectionString2"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            string sqlstr = $"insert into [Users](acount,password,userName) values (@acount,@password,@userName)";

            SqlCommand sqlcommand = new SqlCommand(sqlstr, connection);

            connection.Open();            

            if (Request.Form["password"] == Request.Form["password2"])
            {
                sqlcommand.Parameters.Add("@acount", SqlDbType.NVarChar);
                sqlcommand.Parameters["@acount"].Value = Request.Form["acount"];

                sqlcommand.Parameters.Add("@password", SqlDbType.NVarChar);
                sqlcommand.Parameters["@password"].Value = Request.Form["password"];

                sqlcommand.Parameters.Add("@userName", SqlDbType.NVarChar);
                sqlcommand.Parameters["@userName"].Value = Request.Form["userName"];
                Label5.Text = "帳號註冊成功";
                Server.Transfer("test1.aspx");
            }
            else
            {
                Label5.Text = "輸入不正確";
            }

            sqlcommand.ExecuteNonQuery();

            connection.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("test1.aspx");
        }
    }
}