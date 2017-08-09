using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myweb;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string key = TextBox1.Text;

            EncryptData ecs = new EncryptData();
            string result = ecs.getData(TextBox5.Text, TextBox6.Text, key);
            if (result.Equals("yes"))
            {
                Session["acckey"] = key;
                Session["key"] = TextBox2.Text;
                Session["user"] = TextBox5.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {

                Response.Write("<script page language='javascript'> alert('Login failed');</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script page language='javascript'> alert('Error in Service');</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
}