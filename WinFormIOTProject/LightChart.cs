using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Data.SqlClient;



namespace WinFormIOTProject
{
    public partial class LightChart : Form
    {

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        public LightChart()
        {
            InitializeComponent();
            ChartTempProperties();
            loadDBtoChart();
        }

        private void GraphDatass_Load(object sender, EventArgs e)
        {

        }


        private Color getColor(int r, int g, int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }

        private DateTime getDateTime(int year, int month, int day, int hour, int min, int sec, int millesecs = 0)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec, millesecs);
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            return dt;
        }

        private void setXAxisDisplayRange(Chart cht, DateTime dtStart, DateTime dtEnd)
        {
            DateTime minDate = dtStart.AddSeconds(-1);
            DateTime maxDate = dtEnd;
            Console.WriteLine("Setting AxisX.Minimum =" + minDate.ToOADate());
            Console.WriteLine("Setting AxisX.Maximum =" + maxDate.ToOADate());

            cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            cht.Series[0].IsXValueIndexed = false; // this must be false for AxisX max and min to work
        } //End of setXAxisDisplayRange

        private void ChartTempProperties()
        {



            chart1.BackColor = getColor(64, 64, 64, 64);
            chart1.BackGradientStyle = GradientStyle.TopBottom;
            chart1.BorderlineColor = getColor(181, 64, 1);
            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineWidth = 2;

            // Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Time Base Chart";
            chart1.Titles.Add(title1);

            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            // Graph Legend
            Legend legend1 = chart1.Legends[0];
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = true;
            legend1.Font = labelFont;

            // Chart area is the whole X-Y axis area
            Color colorGridLines = getColor(64, 64, 64, 64);
            ChartArea chartArea1 = chart1.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            // X-Axis settings
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Interval = 2;
            chartArea1.AxisX.Title = "Time";


            //DateTime minDate = getDateTime(2016, 10, 12, 16, 0, 0);
            //DateTime maxDate = getDateTime(2016, 10, 12, 15, 10, 0);
            //setXAxisDisplayRange(chart1, minDate, maxDate);

            //chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
            // you can change to the below format as well depending on your needs
            //chartArea1.AxisX.LabelStyle.Format = "MMM DD";
            chartArea1.AxisX.LabelStyle.Format = "hh:mm:ss";
            //chartArea1.AxisX.LabelStyle.Format = "ss";
            //chartArea1.AxisX.LabelStyle.Format = "yyyy MMM dd HH:mm";
            //chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm:ss";
            chartArea1.AxisX.IsLabelAutoFit = true;


            //Y-Axis Settings
            chartArea1.AxisY.LabelStyle.Font = labelFont;
            chartArea1.AxisY.LineColor = colorGridLines;
            chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            //chartArea1.AxisY.Interval = 10;
            chartArea1.AxisY.IsStartedFromZero = true;
            chartArea1.AxisY.Title = "Light value";


            // Line graph data points
            Series series1 = chart1.Series[0];
            series1.Name = "Light"; //This will show up in legends text
            Color lineColor = getColor(26, 59, 105, 180);
            series1.BorderColor = lineColor;
            series1.ChartType = SeriesChartType.Spline;
            series1.XValueType = ChartValueType.DateTime;
            series1.YValueType = ChartValueType.Int32;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 4;
            series1.MarkerBorderColor = lineColor;
            series1.MarkerColor = lineColor;

            //Hover cursor on point to show
            series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";






        } // End of initChartProperties()


        private void loadDBtoChart()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);



            String strCommandText = "SELECT * FROM Light_table";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);



                DataSet ds = new DataSet();
                adapter.Fill(ds);
                Console.WriteLine("Dataset Rows = " + ds.Tables[0].Rows.Count);
                chart1.DataSource = ds;
                chart1.Series[0].XValueMember = "DATETIME";
                chart1.Series[0].YValueMembers = "LIGHT";

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            finally
            {
                myConnect.Close();
            }


        }




    }
}
