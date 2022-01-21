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
            SoundChart.Series[0].Points.DataBindXY(ConvertedSoundDateTime, SoundValuesList);
            SoundChart.ChartAreas[0].AxisX.Interval = 3;
            SoundChart.Series[0].LegendText = "Sound value";
            //SoundChart.Series[0].XValueType = ChartValueType.DateTime;
            //SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;

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




    }
}
