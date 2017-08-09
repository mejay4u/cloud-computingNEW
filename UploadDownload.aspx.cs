using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using myweb;
using System.Windows.Forms;

public partial class Default2 : System.Web.UI.Page
{
    public static int count, no;

    string line, line1, line2 = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string unname = Session["user"].ToString();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int counter = 0;
            string fname = "D:\\" + FileUpload1.FileName;

            //string f1name = FileUpload1.PostedFile.FileName;
            // string fName = FileUpload1.Fi;
            StreamReader file = new StreamReader(fname);
            StreamReader file1 = new StreamReader(fname);


            while ((line = file.ReadLine()) != null)
            {

                counter++;
            }

            int midData = counter / 2;
            int k = 0;
            while ((line = file1.ReadLine()) != null)
            {
                if (k <= midData)
                {
                    line1 = line1 + line;
                    k++;
                }
                else
                {
                    line2 = line2 + line;
                }
            }
            EncryptData objenc = new EncryptData();
            string result = objenc.SaveData(Session["user"].ToString(), line1, line2, FileUpload1.FileName, Session["key"].ToString());

            if (result.Equals("yes"))
            {
                MessageBox.Show("File Uploded Successfully...");

            }
            else
            {
                MessageBox.Show("Server Error...");

            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error in Service");
        }

    }
}