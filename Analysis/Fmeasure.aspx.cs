using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Analysis_Fmeasure : System.Web.UI.Page
{
    Random r = new Random();
    public static double Precision;
    public static double Recall;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
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
        Precision = r.NextDouble();
        Recall = r.NextDouble();
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
                testData.Add("Precesion", Precision);
            else
                testData.Add("Recall", Recall);
        }

        cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
        double fmeasure = 2 * Precision * Recall / (Precision + Recall);
        MsgBox.Show("F-Measure score is \t:"+fmeasure);
        Response.Write("Precision value \t:" + Precision + "\tRecall value \t:" + Recall);
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        // update chart rendering
        cTestChart.Series["Testing"].ChartTypeName = "pie";
        cTestChart.ChartAreas[0].Area3DStyle.Enable3D = true;
        cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(20);
    }
}