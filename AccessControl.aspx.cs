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

public partial class Default2 : System.Web.UI.Page
{
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            string uname = Session["user"].ToString();
            EncryptData objEnc = new EncryptData();
            DropDownList1.DataSource = objEnc.AllUsers();
            DropDownList1.DataBind();
            string s;
            CheckBoxList1.DataSource = objEnc.getDataFiles(uname);
            CheckBoxList1.DataBind();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            EncryptData objenc = new EncryptData();

            String uname = DropDownList1.SelectedValue.ToString();
            String user = DropDownList1.SelectedItem.ToString();
            List<String> files = new List<string>();


            string mSharedFiles = "";
            foreach (ListItem fname in CheckBoxList1.Items)
            {
                if (fname.Selected == true)
                {
                    s = objenc.AccessControl(uname, fname.ToString(), user);
                    mSharedFiles += " " + fname;

                }
            }
            if (s.Equals("true"))
            {
                string usercontact = objenc.GetContact(uname);
                string url = "http://bulksms.mysmsmantra.com:8080/WebSMS/SMSAPI.jsp?username=cloud&password=pravin2011&sendername=bhushan&mobileno=" + usercontact + "&message=Secret Key:-" + Session["key"].ToString() + "Files:- " + mSharedFiles;

                WebRequest request = HttpWebRequest.Create(url);

                WebResponse response = request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());

                MessageBox.Show("File sharing Successfully..");

            }
            else
            {
                MessageBox.Show("File sharing Error..");

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in Service");
        }
    }
}