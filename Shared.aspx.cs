using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using myweb;
using System.Windows.Forms;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try 
        {
        string user = Session["user"].ToString();
        EncryptData ecss = new EncryptData();
        GridView1.DataSource = ecss.GetAccessList(user);
        GridView1.DataBind();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in Service");
        }

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        try
        {
        GridViewRow row = GridView1.Rows[e.NewSelectedIndex];
        string key = TextBox1.Text;
        if (key == null)
        {
            Response.Write("<script page language='javascript'> alert('First Enter Original Decryption key in Textbox');</script>");
            
        }
        else
        {
            try
            {
                String output = row.Cells[1].Text;

                EncryptData objEnc = new EncryptData();
                String text = objEnc.AllContent(output, key);
                // sb.Append(output);
                //sb.Append("\r\n");

               // string text = sb.ToString();

                Response.Clear();
                Response.ClearHeaders();

                Response.AddHeader("Content-Length", text.Length.ToString());
                Response.ContentType = "text/plain";
                Response.AppendHeader("content-disposition", "attachment;filename=" + output);
                TextBox1.Text = "";
                string[] rec = text.Split('\n');
                for (int i = 0; i < rec.Length; i++)
                {
                    Response.Write(rec[i]);
                    //Response.Write(
                    Response.Write(Environment.NewLine);
                }
              //  Response.End();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong key");
            
            }
        }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in Service");
        }

    }
   
}