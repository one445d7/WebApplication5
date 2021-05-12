using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public class GameStep{
        Random random = new Random();
        int com;
        public int ComChoise()
        {
            com = random.Next(1, 4);
            return com;
        }
        public string Judge(int gus,int com)
        {
            if(gus - com == 0)
            {
                return "平手";
            }else if (gus - com == -1)
            {
                return "你輸了";
            }else if (gus - com == -2)
            {
                return "你贏了";
            }else if (gus - com == 1)
            {
                return "你贏了";
            }else
            {
                return "你輸了";
            }
        }
    }
    public partial class game1 : System.Web.UI.Page
    {
        GameStep gameStep = new GameStep();
        int gamer;
        int com;
        //Timer倒計時保留 static int ct;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Logined"] == "login")
            {
                Label3.Text = "線上玩家人數:" + Application["count"];
                Image1.Visible = false;
                com = gameStep.ComChoise();
                if (com == 1)
                {
                    Image1.ImageUrl = @"~/pic/siscer.png";
                }
                else if (com == 2)
                {
                    Image1.ImageUrl = @"~/pic/stone.png";
                }
                else
                {
                    Image1.ImageUrl = @"~/pic/paper.png";
                }
            }
            else
            {
                //Response.Redirect("test1");
                Server.Transfer("test1.aspx");
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Image1.Visible = true;
            gamer = 1;
            Label1.Text = gameStep.Judge(gamer, com);
            
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Image1.Visible = true;
            gamer = 2;           
            Label1.Text = gameStep.Judge(gamer, com);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Image1.Visible = true;
            gamer = 3;
            Label1.Text = gameStep.Judge(gamer, com);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Application["count"] = Convert.ToInt32(Application["count"]) - 1;
            //Response.Redirect("test1");
            Server.Transfer("test1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string message = TextBox1.Text;
            Application["message"] = Application["message"] + Convert.ToString(Session["userName"]) + ":" + message + "<br />";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if(Application["message"] != null)
            {
                Label4.Text = Application["message"].ToString();
            }
        }       
    }
}