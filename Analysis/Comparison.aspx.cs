using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Analysis_Comparison : System.Web.UI.Page
{
    Random r = new Random();
    public static double var;
    public static double var1;

    Dictionary<string, double> testData = new Dictionary<string, double>();

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            // bind chart type names to ddl
            //ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
            //ddlChartType.DataBind();
        }
        var = r.Next(10, 16);
        var1 = r.Next(20, 30);
        DataBind();
      
    }

    protected override void OnDataBinding(EventArgs e)
    {
        base.OnDataBinding(e);
       

        // define test data
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        for (int i = 0; i < 2; i++)
        {
            if (i == 1)
                testData.Add("Single cloud Transaction, Existing", var1);
            else
                testData.Add("Multi Cloud Transaction, New", var);
        }

        cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);

        MsgBox.Show("Time Required for Single cloud Transaction \t" + var1 + "\t Time Required for Multi Cloud Transaction \t" + var);
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        // update chart rendering
        cTestChart.Series["Testing"].ChartTypeName = "column";
        cTestChart.ChartAreas[0].Area3DStyle.Enable3D = true;
        cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(20);
    }
}