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
    public partial class SoundSensor : Form
    {
        string count="";
        float range123;
        List<float> numberList = new List<float>();
        public SoundSensor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SoundSensor_Load(object sender, EventArgs e)
        {
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;


        public delegate void myprocessDataDelegate(string strData);
        private void saveSOUNDSensorDataToDB(string strTime, string strsoundValue, string strStatus, string range1)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT Sound_table (DATETIME, Sound, Sound_STATUS, userid, range_sound)" + "VALUES (@time1, @value1, @status1, @user1, @rangeidk)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
            updateCmd.Parameters.AddWithValue("@time1", strTime);
            updateCmd.Parameters.AddWithValue("@value1", strsoundValue);
            updateCmd.Parameters.AddWithValue("@status1", strStatus);
            updateCmd.Parameters.AddWithValue("@rangeidk", range1);
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
            string strsoundValue = extractStringValue(strData, ID);
            Roomtemptxt.Text = strsoundValue;
            Roomtemptxt.Text = strsoundValue;
            float flightValue = extractFloatValue(strData, ID);
            if (count != "10")
            {
                if (numberList.Count != 10)
                {
                    numberList.Add(flightValue);
                    Status2txt.Text = "measuring average noise level";
                }
                else
                {
                    numberList = numberList.OrderBy(i => i).ToList();
                    float firstnu = numberList[0];
                    Console.WriteLine("first{0} ",firstnu);
                    float lastnum = numberList.LastOrDefault();
                    Console.WriteLine("sec{0} ", lastnum);
                    range123 = lastnum - firstnu;
                    Console.WriteLine("range {0} ", range123);
                    string status = "";
                    if (flightValue <= range123)
                        status = "Environment noise level ";
                    else
                        status = "Unusual noise level";
                    Status2txt.Text = status;
                    string inrange = Convert.ToString(range123);
                    saveSOUNDSensorDataToDB(strTime, strsoundValue, status, inrange);
                    count = "10";
                    numberList.Clear();
                }
            }
            else {
                string status = "";
                if (flightValue <= range123)
                    status = "Environment noise level ";
                else
                    status = "Unusual noise level";
                Status2txt.Text = status;
                string inrange = Convert.ToString(range123);
                saveSOUNDSensorDataToDB(strTime, strsoundValue, status, inrange);
            }
          

        }

        private void handleButtonData(string strData, string strTime, string ID)
        {
            string strbuttonValue = extractStringValue(strData, ID);
            //tbButtonValue.Text = strbuttonValue;
            //tbDoorBell.Text = strbuttonValue;
        }

        private void extractSensorData(string strData, string strTime)
        {
            if (strData.IndexOf("Sound=") != -1)
                handlewaterSensorData(strData, strTime, "Sound=");
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
            if (strData.IndexOf("Sound=") != -1)
            {
                myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
                listBox1.Invoke(d, new object[] { strData });
            }
            else {
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

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Roomtemptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Status2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("STOP");
            count = "";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
