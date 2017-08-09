using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myweb;
using System.Net;
using System.IO;
using System.Windows.Forms;


public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox6.Text.Length >= 6)
        {
            try
            {
                string str = KeyGenerator.keyData();
                string gender = string.Empty;
                if (RadioButton1.Checked == true) { gender = "male"; }
                if (RadioButton2.Checked == true) { gender = "female"; }
                EncryptData objenc = new EncryptData();
                string result = objenc.InsertData(TextBox1.Text, TextBox2.Text, gender, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, str);
                if (result.Equals("success"))
                {
                    string str1 = KeyGenerator.keyData();
                    ////////////////////////////////////////////////////
                    //string url = "http://bulksms.mysmsmantra.com:8080/WebSMS/SMSAPI.jsp?username=cloud&password=pravin2011&sendername=pravin&mobileno=" + TextBox4.Text + "&message=Login_Secret_Key_is" + str + "";

                    //WebRequest request = HttpWebRequest.Create(url);

                    //WebResponse response = request.GetResponse();

                    //StreamReader reader = new StreamReader(response.GetResponseStream());
                    ///////////////////////////////////////////////////////////////

                    //string url1 = "http://bulksms.mysmsmantra.com:8080/WebSMS/SMSAPI.jsp?username=cloud&password=pravin2011&sendername=pravin&mobileno=" + TextBox4.Text + "&message=Account_Secret_Key_is" + str1 + "";

                    //WebRequest request1 = HttpWebRequest.Create(url1);

                    //WebResponse response1 = request1.GetResponse();

                    //StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                    Response.Write("Your Login Key is \t" + str + " and Your Account Key is " + str1);
                    Response.Write("<script page language='javascript'> alert('User Registration Success..');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";


                }
                else
                {
                    Response.Write("<script page language='javascript'> alert('Error in Registration');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";


                }
            }
            catch (Exception ex)
            {
                Response.Write("<script page language='javascript'> alert('Error in Service');</script>");
            }
        }
        else
        {
            MessageBox.Show("Password length must be greater than six.!!!");
        }



    }
}