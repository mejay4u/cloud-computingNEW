using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myweb;
using System.Text;
using System.Windows.Forms;

public partial class UpdateFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                string uname = Session["user"].ToString();
                EncryptData objEnc = new EncryptData();
                DropDownList1.DataSource = objEnc.getDataFiles(uname);
                DropDownList1.DataBind();
                Button1.Visible = false;
            }
        }
        catch (Exception ex)
        {
            Response.Write("<script page language='javascript'> alert('Error in Service');</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            Button1.Visible = true;
            string fname = DropDownList1.SelectedItem.ToString();
            EncryptData objEnc = new EncryptData();
            StringBuilder sb = new StringBuilder(objEnc.AllContent(fname, Session["key"].ToString()));
            // sb.Append(output);
            sb.Append("\r\n");

            string text = sb.ToString();
            TextBox1.Text = text;
        }
        catch (Exception ex)
        {
            Response.Write("<script page language='javascript'> alert('Error in Service');</script>");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string mFileData = TextBox1.Text.ToString();
            string mFirst = mFileData.Substring(0, mFileData.Length / 2);

            string mSecond = mFileData.Substring((mFileData.Length / 2), (mFileData.Length / 2) + (mFileData.Length % 2));

            EncryptData objEnc = new EncryptData();
            string result = objEnc.UpdateData(Session["user"].ToString(), mFirst, mSecond, DropDownList1.SelectedItem.ToString(), Session["key"].ToString());
            if (result.Equals("yes"))
            {
                MessageBox.Show("File Updated Success..");
            }
            else
            {
                MessageBox.Show("File Updation error..");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in Service");
        }
    }
}