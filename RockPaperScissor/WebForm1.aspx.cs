using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RockPaperScissor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string user;
        string computerResponse;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            user = "rock";
            results();          
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            user = "paper";
            results();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            user = "scissor";
            results();
        }

        public void results()
        {
            Random num = new Random();
            int r = num.Next(1, 4);

            if (r == 1)
            {
                computerResponse = "rock";
            }
            if (r == 2)
            {
                computerResponse = "paper";
            }
            if (r == 3)
            {
                computerResponse = "scissor";
            }
            TextBox1.Text = user;
            TextBox2.Text = computerResponse;

            if (user == computerResponse)//(user == "rock" && computerResponse == "rock" || user == "paper" && computerResponse == "paper" || user == "scissor" && computerResponse == "scissor")
            {
                TextBox3.Text = "Tie";
            }

            if (user == "rock" && computerResponse == "scissor" || user == "paper" && computerResponse == "rock" || user == "scissor" && computerResponse == "paper")
            {
                TextBox3.Text = "You Wins!";
            }

            if (user == "rock" && computerResponse == "paper" || user == "paper" && computerResponse == "scissor" || user == "scissor" && computerResponse == "rock")
            {
                TextBox3.Text = "You Loose!";
            }
        }
    }
}