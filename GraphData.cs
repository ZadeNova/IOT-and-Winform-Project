using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;


namespace WinFormIOTProject
{
    public partial class GraphData : Form
    {
        public GraphData()
        {
            InitializeComponent();
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





        private void SoundChartProperties()
        {
            // Background
            SoundChart.BackColor = getColor(64, 64, 64, 64);
            SoundChart.BackGradientStyle = GradientStyle.TopBottom;
            // Border color and line
            SoundChart.BorderlineColor = getColor(181, 64, 1);
            SoundChart.BorderlineDashStyle = ChartDashStyle.Solid;
            SoundChart.BorderlineWidth = 1;
            // Title
            Title title1 = new Title();
            title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            title1.Text = "Sound Value Chart";
            SoundChart.Titles.Add(title1);

            Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            Color colorGridLines = getColor(64, 64, 64, 80);
            ChartArea chartArea1 = SoundChart.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            //X axis stuff
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisX.LabelStyle.Format = "hh:mm:ss";
            chartArea1.AxisX.IsLabelAutoFit = true;


            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.Title = "Time";


            // Y axis stuff
            chartArea1.AxisY.Title = "Sound";

            //Line graph data points
            Series series1 = SoundChart.Series[0];
            series1.XValueType = ChartValueType.DateTime;


            SoundChart.Series[0].MarkerStyle = MarkerStyle.Circle;
            Color lineColor = getColor(26, 59, 105, 180);
            //SoundChart.Series[0].MarkerBorderColor = lineColor;
            //SoundChart.Series[0].MarkerColor = lineColor;

        }



        private void GraphData_Load(object sender, EventArgs e)
        {

            // Get all graph data from sql here.
            string query = "SELECT * FROM Sound_table";
            DataTable sounddt = getSoundData(query);
            //for (var i = 0; i <= sounddt.Rows.Count - 1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(sounddt.Rows);
            Console.WriteLine("HELLOOOO THERE");

            List<DateTime> SoundDateTime = new List<DateTime>();
            List<string> SoundValuesList = new List<string>();
            List<string> ConvertedSoundDateTime = new List<string>();
            foreach(DataRow row in sounddt.Rows)
            {

                SoundDateTime.Add(Convert.ToDateTime(row["DATETIME"]));
                //SoundDateTime.Add(row["DATETIME"].ToString());
                SoundValuesList.Add(row["Sound"].ToString());


            }
            foreach(var i in SoundDateTime)
            {
                Console.WriteLine(i);
                var aa = String.Format("{0:ss}", i); // Convert to seconds
                Console.WriteLine(aa);
                ConvertedSoundDateTime.Add(aa);

            }
            
            


            SoundChart.Series[0].ChartType = SeriesChartType.Line;
            //SoundChart.Series[0].Points.DataBindXY(ConvertedSoundDateTime, SoundValuesList);
            

            //SoundChart.ChartAreas[0].AxisX.Interval = 3;
            SoundChart.Series[0].LegendText = "Sound value";
            //SoundChart.Series[0].XValueType = ChartValueType.DateTime;
            //SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
            SoundChartProperties();

        }

        private static DataTable getSoundData(string query)
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void SoundChart_Click(object sender, EventArgs e)
        {

        }
    }
}
