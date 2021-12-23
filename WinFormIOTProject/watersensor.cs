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
    public partial class watersensor : Form
    {
        public watersensor()
        {
            InitializeComponent();
        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void watersensor_Load(object sender, EventArgs e)
        {
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;


        public delegate void myprocessDataDelegate(string strData);
        private void savewaterSensorDataToDB(string strTime, string strwaterValue, string strStatus)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT Water_table (DATETIME, Water, Water_status, userid)" + "VALUES (@time1, @value1, @status1, @user1)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
            updateCmd.Parameters.AddWithValue("@time1", strTime);
            updateCmd.Parameters.AddWithValue("@value1", strwaterValue);
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

        private void handlewaterSensorData(string strData, string strTime, string ID)
        {
            string strwaterValue = extractStringValue(strData, ID);
            Roomtemptxt.Text = strwaterValue;
            Roomtemptxt.Text = strwaterValue;

            float flightValue = extractFloatValue(strData, ID);
            string status = "";
            if (flightValue <= 250)
                status = "Moderately Wet";
            else
                status = "dry";
            Status2txt.Text = status;
            savewaterSensorDataToDB(strTime, strwaterValue, status);
        }

        private void handleButtonData(string strData, string strTime, string ID)
        {
            string strbuttonValue = extractStringValue(strData, ID);
            //tbButtonValue.Text = strbuttonValue;
            //tbDoorBell.Text = strbuttonValue;
        }

        private void extractSensorData(string strData, string strTime)
        {
            if (strData.IndexOf("Water=") != -1)
                handlewaterSensorData(strData, strTime, "Water=");
            else {
            }
        }

        public void handleSensorData(string strData)
        {
            string dt = DateTime.Now.ToString("s");
            extractSensorData(strData, dt);

            string strMessage = dt + ":" + strData;
            listBox1.Items.Insert(0, strMessage);
        }

        public void processDataReceive(string strData)
        {
            if (strData.IndexOf("Water=") != -1)
            {
                myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
                listBox1.Invoke(d, new object[] { strData });
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

        private void Roomtemptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("STOP");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Status2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
