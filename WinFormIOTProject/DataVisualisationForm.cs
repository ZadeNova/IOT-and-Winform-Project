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
    public partial class DataVisualisationForm : Form

    {

        double x;
       

        public DataVisualisationForm()
        {
            InitializeComponent();
        }
       
            
        private void DataVisualisationForm_Load(object sender, EventArgs e)
        {
            InitComms();
            InitComms1();

            //ChartTempProperties();
            //AddDataChart();

        }


        private Color getColor(int r,int g ,int b, int transparent = 255)
        {
            return System.Drawing.Color.FromArgb(transparent, r, g, b);
        }

        private DateTime getDateTime(int year , int month , int day , int hour , int min ,int sec , int millesecs = 0)
        {
            DateTime dt = new DateTime(year, month, day, hour, min, sec, millesecs);
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss.fff"));
            return dt;
        }

        private void setXAxisDisplayRange(Chart cht, DateTime dtStart,DateTime dtEnd)
        {
            //DateTime minDate = dtStart.AddSeconds(-1);
            //DateTime maxDate = dtEnd;
            //Console.WriteLine("Setting AxisX.Minimum =" + minDate.ToOADate());
            //Console.WriteLine("Setting AxisX.Maximum =" + maxDate.ToOADate());

            //cht.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            //cht.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            //cht.Series[0].IsXValueIndexed = false; // this must be false for AxisX max and min to work
        } //End of setXAxisDisplayRange

        private void ChartTempProperties()
        {

            

            //chart1.BackColor = getColor(64, 64, 64, 64);
            //chart1.BackGradientStyle = GradientStyle.TopBottom;
            //chart1.BorderlineColor = getColor(181, 64, 1);
            //chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            //chart1.BorderlineWidth = 2;

            //// Title
            //Title title1 = new Title();
            //title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            //title1.Text = "Time Base Chart";
            //chart1.Titles.Add(title1);

            //Font labelFont = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);

            //// Graph Legend
            //Legend legend1 = chart1.Legends[0];
            //legend1.BackColor = Color.Transparent;
            //legend1.Enabled = true;
            //legend1.Font = labelFont;

            //// Chart area is the whole X-Y axis area
            //Color colorGridLines = getColor(64, 64, 64, 64);
            //ChartArea chartArea1 = chart1.ChartAreas[0];
            //chartArea1.BackColor = Color.OldLace;
            //chartArea1.BackGradientStyle = GradientStyle.TopBottom;
            //chartArea1.BorderColor = colorGridLines;
            //chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            //chartArea1.ShadowColor = Color.Transparent;

            //// X-Axis settings
            //chartArea1.AxisX.LabelStyle.Font = labelFont;
            //chartArea1.AxisX.LineColor = colorGridLines;
            //chartArea1.AxisX.MajorGrid.LineColor = colorGridLines;

            //chartArea1.AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chartArea1.AxisX.Interval = 1;
            //DateTime minDate = getDateTime(2016, 10, 12, 16, 0, 0);
            //DateTime maxDate = getDateTime(2016, 10, 12, 15, 10, 0);
            //setXAxisDisplayRange(chart1, minDate, maxDate);

            //chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm";
            //// you can change to the below format as well depending on your needs
            ////chartArea1.AxisX.LabelStyle.Format = "MMM DD";
            ////chartArea1.AxisX.LabelStyle.Format = "HH:mm";
            ////chartArea1.AxisX.LabelStyle.Format = "yyyy MMM dd HH:mm";
            ////chartArea1.AxisX.LabelStyle.Format = "MMM dd HH:mm:ss";

            ////Y-Axis Settings
            //chartArea1.AxisY.LabelStyle.Font = labelFont;
            //chartArea1.AxisY.LineColor = colorGridLines;
            //chartArea1.AxisY.MajorGrid.LineColor = colorGridLines;
            //chartArea1.AxisY.Interval = 10;
            //chartArea1.AxisY.IsStartedFromZero = true;

            //// Line graph data points
            //Series series1 = chart1.Series[0];
            //series1.Name = "Temp"; //This will show up in legends text
            //Color lineColor = getColor(26, 59, 105, 180);
            //series1.BorderColor = lineColor;
            //series1.ChartType = SeriesChartType.Spline;
            //series1.XValueType = ChartValueType.DateTime;
            //series1.YValueType = ChartValueType.Double;
            //series1.MarkerStyle = MarkerStyle.Circle;
            //series1.MarkerSize = 6;
            //series1.MarkerBorderColor = lineColor;
            //series1.MarkerColor = lineColor;

            ////Hover cursor on point to show
            //series1.ToolTip = "Timestamp: #VALX{d MMM yyyy H:mm:ss}, Value : #VAL";






        } // End of initChartProperties()


        private void AddDataChart()
        {
           

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("LNT");
            Console.WriteLine("sending LNT");

        }

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
      
       
        public delegate void myprocessDataDelegate(string strData);
        private void saveLightSensorDataToDB(string strTime, string strlightValue, string strStatus)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT Light_table (DATETIME, LIGHT, LIGHT_STATUS, userid)" + "VALUES (@time1, @value1, @status1, @user1)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
            updateCmd.Parameters.AddWithValue("@time1", strTime);
            updateCmd.Parameters.AddWithValue("@value1", strlightValue);
            updateCmd.Parameters.AddWithValue("@status1", strStatus);
            updateCmd.Parameters.AddWithValue("@user1", User.AccountID);

            myconnect.Open();

            int result = updateCmd.ExecuteNonQuery();
            myconnect.Close();
        }

        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

        private float extractFloatValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }

        private void handleLightSensorData(string strData, string strTime, string ID)
        {
            string strlightValue = extractStringValue(strData, ID);
            Roomlighttxt.Text = strlightValue;
            Roomlighttxt.Text = strlightValue;

            float flightValue = extractFloatValue(strData, ID);
            string status = "";
            if (flightValue <= 500)
                status = "Dark";
            else
                status = "Bright";
            Statustxt.Text = status;
            saveLightSensorDataToDB(strTime, strlightValue, status);
        }

        private void handleButtonData(string strData, string strTime, string ID)
        {
            string strbuttonValue = extractStringValue(strData, ID);
            //tbButtonValue.Text = strbuttonValue;
            //tbDoorBell.Text = strbuttonValue;
        }

        private void extractSensorData(string strData, string strTime)
        {
            if (strData.IndexOf("LIGHT=") != -1)
                handleLightSensorData(strData, strTime, "LIGHT=");
        }

        public void handleSensorData(string strData)
        {
            string dt = DateTime.Now.ToString("s");
            extractSensorData(strData, dt);

            string strMessage = dt + ":" + strData;
            lbDataComms.Items.Insert(0, strMessage);
        }
       
        public void processDataReceive(string strData)
        {
            if (strData.IndexOf("LIGHT=") != -1) {
           
                myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
                lbDataComms.Invoke(d, new object[] { strData });

            }
            
        }
      
        public void commsDataRecieve(string dataReceived)
        {
            processDataReceive(dataReceived);
        }

        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);
        }
        private void InitComms()
        {
          
                idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve);
                idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
            
         
        }
        // end of light sensor

        // start of tem sensor


        public delegate void myprocessDataDelegate1(string strData1);
        private void savetempSensorDataToDB1(string strTime1, string strlightValue1, string strStatus1)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT tem_table (DATETIME, TEM, TEM_STATUS, userid1)" + "VALUES (@timetem, @valuetem, @statustem, @user)";
            SqlCommand updateCmd1 = new SqlCommand(strCommandText, myconnect);
            updateCmd1.Parameters.AddWithValue("@timetem", strTime1);
            updateCmd1.Parameters.AddWithValue("@valuetem", strlightValue1);
            updateCmd1.Parameters.AddWithValue("@statustem", strStatus1);
            updateCmd1.Parameters.AddWithValue("@user", User.AccountID);

            myconnect.Open();

            int result1 = updateCmd1.ExecuteNonQuery();
            myconnect.Close();
        }

        private string extractStringValue1(string strData1, string ID1)
        {
            string result1 = strData1.Substring(strData1.IndexOf(ID1) + ID1.Length);
            return result1;
        }

        private float extractFloatValue1(string strData1, string ID1)
        {
            return (float.Parse(extractStringValue1(strData1, ID1)));
        }

        private void handletempSensorData(string strData1, string strTime1, string ID1)
        {
            string strlightValue1 = extractStringValue1(strData1, ID1);
            Roomtemptxt.Text = strlightValue1;
            Roomtemptxt.Text = strlightValue1;

            float flightValue1 = extractFloatValue1(strData1, ID1);
            string status1 = "";
            if (flightValue1 >= 30)
                status1 = "too hot";
            else if (flightValue1 <= 20)
                status1 = "too cool";
            else
                status1 = "normal";
            Status2txt.Text = status1;
            savetempSensorDataToDB1(strTime1, strlightValue1, status1);
        }

        private void handleButtonData1(string strData1, string strTime1, string ID1)
        {
            string strbuttonValue1 = extractStringValue1(strData1, ID1);
            //tbButtonValue.Text = strbuttonValue;
            //tbDoorBell.Text = strbuttonValue;
        }

        private void extractSensorData1(string strData1, string strTime1)
        {
            if (strData1.IndexOf("Temp=") != -1)
                handletempSensorData(strData1, strTime1, "Temp=");
          
        }

        public void handleSensorData1(string strData1)
        {
            string dt = DateTime.Now.ToString("s");
            extractSensorData1(strData1, dt);
            string strMessage1 = dt + ":" + strData1;
            listBox1.Items.Insert(0, strMessage1);
        }

        public void processDataReceive1(string strData1)
        {
            if (strData1.IndexOf("Temp=") != -1) {
                myprocessDataDelegate1 d = new myprocessDataDelegate1(handleSensorData1);
                listBox1.Invoke(d, new object[] { strData1 });
            }


        }

        public void commsDataRecieve1(string dataReceived1)
        {
            processDataReceive1(dataReceived1);
        }

        public void commsSendError1(string errMsg1)
        {
            MessageBox.Show(errMsg1);
            processDataReceive(errMsg1);
        }
        private void InitComms1()
        {
                
                idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve1);
                idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError1);
           
        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            lbDataComms.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void Roomtemptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Status2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Status2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Temperature_Click(object sender, EventArgs e)
        {

        }

        private void lbDataComms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("StopLNT");
            Console.WriteLine("stop lnt");
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // end of tem sensor 

    }
}
