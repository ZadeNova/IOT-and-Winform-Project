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

        // Form new variables for time filter here.
        string FromDatetime,ToDateTime,FilterByTime;
        DateTime MinimumDate,MinimumDate2;
        Double toOAdate;
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

            
            SoundChart.Series[0].ChartType = SeriesChartType.Line;
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

            //Chart border color
            Color colorGridLines = getColor(27, 64, 21, 80);
            ChartArea chartArea1 = SoundChart.ChartAreas[0];
            chartArea1.BackColor = Color.OldLace;
            chartArea1.BackGradientStyle = GradientStyle.Center;
            chartArea1.BorderColor = colorGridLines;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.ShadowColor = Color.Transparent;

            // Legend settings
            Legend legend1 = SoundChart.Legends[0];
            legend1.BackColor = Color.Transparent;
            legend1.Enabled = true;
            legend1.Font = labelFont;
            SoundChart.Series[0].LegendText = "Sound value";

            //X axis stuff
            chartArea1.AxisX.LabelStyle.Font = labelFont;
            chartArea1.AxisX.LineColor = colorGridLines;
            chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;
            chartArea1.AxisX.LabelStyle.Format = "MMM";
            chartArea1.AxisX.IsLabelAutoFit = true;
            chartArea1.AxisX.LabelStyle.Interval = 1;
            chartArea1.CursorX.IsUserSelectionEnabled = true;

            chartArea1.AxisX.IntervalType = DateTimeIntervalType.Months;
            //chartArea1.AxisX.Interval = 1;
            chartArea1.AxisX.Title = "Time";
            //chartArea1.AxisX.Minimum = 0;
            //chartArea1.AxisX.IsMarginVisible = false;


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

            //loadSoundData();


            loaddataintoformatthestart();


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            ToDateTimePicker.Format = DateTimePickerFormat.Custom;
            ToDateTimePicker.CustomFormat = "yyyy-MM-dd";
            SoundChartProperties();
            
        }

        private void loadSoundData()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnectionString))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sound_table WHERE DATETIME BETWEEN @StartDate AND @EndDate", con))
                {





                    sda.SelectCommand.Parameters.AddWithValue("@StartDate",FromDatetime);
                    sda.SelectCommand.Parameters.AddWithValue("@EndDate", ToDateTime);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    SoundChart.DataSource = dt;
                    SoundChart.Series[0].XValueMember = "DATETIME";
                    SoundChart.Series[0].YValueMembers = "Sound";
                    SoundChart.DataBind();
                    foreach(DataRow row in dt.Rows)
                    {
                        
                    }
                    //SoundChart.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(dt.Rows[0]["DATETIME"]);
                    
                    // Set Xaxis minimum
                    //MinimumDate = Convert.ToDateTime(dt.Rows[0]["DATETIME"]);
                    //MinimumDate2 = Convert.ToDateTime(String.Format("{0:dd/MM/yyyy}", MinimumDate));
                    //Console.WriteLine(MinimumDate);
                    

                    


                    //toOAdate = MinimumDate2.ToOADate();
                    //SoundChart.ChartAreas[0].AxisX.Minimum = toOAdate;

                }
            }
        }

        private void SoundChart_Click(object sender, EventArgs e)
        {

        }



        private void loaddataintoformatthestart()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnectionString))
            {
                using(SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Sound_table", con))
                {
                    DataTable at = new DataTable();
                    sda.Fill(at);
                    SoundChart.DataSource = at;
                    SoundChart.Series[0].XValueMember = "DATETIME";
                    SoundChart.Series[0].YValueMembers = "Sound";
                    //foreach (DataRow row in at.Rows)
                    //{
                    //    Console.WriteLine(row);
                    //}
                    



                    
                    
                }
            }
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            FromDatetime = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            ToDateTime = ToDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            ChangeChartProperties();
            loadSoundData();
            
            
            
        }


        private void ChangeChartProperties()
        {
            FilterByTime = Filterby.Text;

            if (FilterByTime.Equals("Seconds"))
            {
                MessageBox.Show("Second");
                SoundChart.ChartAreas[0].AxisX.LabelStyle.Format = "ss";
                //chartArea1.AxisX.LabelStyle.Format = "mm:ss";
                SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                SoundChart.ChartAreas[0].AxisX.Interval = 5;

               

            }
            else if (FilterByTime.Equals("Minute"))
            {
                MessageBox.Show("Second1");
                SoundChart.ChartAreas[0].AxisX.LabelStyle.Format = "mm";
                SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
                SoundChart.ChartAreas[0].AxisX.Interval = 5;
                

                
            }
            else if (FilterByTime.Equals("Days"))
            {
                MessageBox.Show("Second2");
                SoundChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
                SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;

               

            }
            else if (FilterByTime.Equals("Month"))
            {
                MessageBox.Show("Second3");
                SoundChart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM";
                SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
               

            }
            else if (FilterByTime.Equals("Year"))
            {
                SoundChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy";
                SoundChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Years;
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        //private void Printstuff(DataSet dataset)
        //{
        //    foreach(DataTable table in dataset.Tables)
        //    {
        //        foreach(DataRow row in table.Rows)
        //        {

        //            Console.WriteLine(row);
        //            Console.WriteLine("Hello");
        //            //foreach(DataColumn column in table.Columns)
        //            //{
        //            //    Console.WriteLine(row[column]);
        //            //}
        //        }
        //    }
        //}






    }
}
