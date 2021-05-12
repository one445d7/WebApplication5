using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logined"] != null && Session["Logined"] != "login")
            {
                Server.Transfer("game1.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Form["acount"] != null && Request.Form["password"] != null)
            {
                string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AcountConnectionString"].ConnectionString;

                SqlConnection connection = new SqlConnection(s_data);

                string sqlstr = "select * from Users where acount ='" + Request.Form["acount"] + "'";

                SqlCommand sqlcommand = new SqlCommand(sqlstr, connection);

                connection.Open();

                SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    if (sqlDataReader.Read())
                    {
                        if (sqlDataReader["password"].ToString() == Request.Form["password"])
                        {
                            Session["Logined"] = "login";
                            Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                            if (Request.Form["username"] == "")
                            {
                                Session["userName"] = sqlDataReader["userName"].ToString();
                            }
                            Server.Transfer("game1.aspx");
                            Response.Write("OK");
                        }
                        else
                        {
                            Label6.Text = "密碼輸入錯誤!";
                        }
                    }
                }
                else
                {
                    Label6.Text = "帳號輸入錯誤!";
                }
                connection.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("resgin.aspx");
        }
    }
}