using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using myweb;
using System.Text;

public partial class Default2 : System.Web.UI.Page
{
    public static int count, no;

    string line, line1, line2 = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Session["user"].ToString();
        EncryptData ecss = new EncryptData();
        GridView1.DataSource = ecss.getDataFiles(user);
        GridView1.DataBind();

    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        try
        {
            GridViewRow row = GridView1.Rows[e.NewSelectedIndex];

            String output = row.Cells[1].Text;

            EncryptData objEnc = new EncryptData();
            String sb = objEnc.AllContent(output, Session["key"].ToString());
            // sb.Append(output);
            // sb.Append("\r\n");

            string text = sb.ToString();

            Response.Clear();
            Response.ClearHeaders();

            Response.AddHeader("Content-Length", (text.Length+20).ToString());
            Response.ContentType = "text/plain";
            Response.AppendHeader("content-disposition", "attachment;filename=" + output);

            string[] rec = text.Split('\n');
            for (int i = 0; i < rec.Length; i++) {
                Response.Write(rec[i]);
                //Response.Write(
               Response.Write(Environment.NewLine);
            }
            
           Response.End();
            

        }
        catch (Exception ex)
        {
          // Response.Write( ex.InnerException);
        }
    }
}