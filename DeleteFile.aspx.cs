using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myweb;
using System.Windows.Forms;
public partial class DeleteFile : System.Web.UI.Page
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

            }
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

            EncryptData objenc = new EncryptData();
            string res = objenc.DeleteFile(DropDownList1.SelectedItem.ToString());
            bool FLAG = false;

            if (res.Equals("success"))
            {
                MessageBox.Show("File Delete Success");
                //  Response.Write("<script page language='javascript'> alert('');</script>");
                FLAG = true;
            }
            else
            {
                MessageBox.Show("Error in file deletion");

            }
            if (FLAG)
                Response.Redirect(Request.RawUrl, true);
        }

        catch (Exception ex)
        {
           // MessageBox.Show("Error in Service");
        }
    }
}