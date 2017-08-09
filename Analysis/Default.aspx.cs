using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Analysis_Default : System.Web.UI.Page
{
    Dictionary<string, int> testData = new Dictionary<string, int>();
    Random r = new Random();
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            // bind chart type names to ddl
            //ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
            //ddlChartType.DataBind();
        }

        DataBind();
    }

    protected override void OnDataBinding(EventArgs e)
    {
        base.OnDataBinding(e);
        int loop = r.Next(5, 25);
        // define test data
        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        for (int i = 0; i < loop; i++)
        {
            testData.Add("Transaction time in seconds \t Transaction number\t" + i, rnd.Next(10, 40));
        }

        cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
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