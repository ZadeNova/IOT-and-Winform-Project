using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WinFormIOTProject
{
    public partial class UltraSonic : Form
    {
        public UltraSonic()
        {
            InitializeComponent();
        }
        private void UltraSonic_Load(object sender, EventArgs e)
        {
            //InitComms();
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve124);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError123);
        }
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        DataComms dataComms;
        
        public delegate void myprocessDataDelegate123(String strData);
        private void saveultrsSensorDataToDB(string strTime, string strUltraValue, string strStatus)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT Ultra_table (DATETIME, Ultra, Ultra_status, userid)" + "VALUES (@time, @value, @status, @user)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strUltraValue);
            updateCmd.Parameters.AddWithValue("@status", strStatus);
            updateCmd.Parameters.AddWithValue("@user", User.AccountID);

            myconnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myconnect.Close();
        }

        private string extractStringValue123(string strData, string ID)
        {
            string result123 = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result123;
        }

        private float extractFloatValue123(string strData, string ID)
        {
            return (float.Parse(extractStringValue123(strData, ID)));
        }

        private void handleLightSensorData123(string strData, string strTime, string ID)
        {
            string strUltraValue123 = extractStringValue123(strData, ID);
            Roomtemptxt.Text = strUltraValue123;
            Roomtemptxt.Text = strUltraValue123;

            float flightValue123 = extractFloatValue123(strData, ID);
            string status = "";
            if (flightValue123 <15)
                status = "Something is close";
            else
                status = "Nothing ";
            Status2txt.Text = status;
            saveultrsSensorDataToDB(strTime, strUltraValue123, status);
        }

        private void handleButtonData123(string strData, string strTime, string ID)
        {
            string strbuttonValue = extractStringValue123(strData, ID);
            //tbButtonValue.Text = strbuttonValue;
            //tbDoorBell.Text = strbuttonValue;
        }

        private void extractSensorData123(string strData, string strTime)
        {
            if (strData.IndexOf("Ultra=") != -1)
                handleLightSensorData123(strData, strTime, "Ultra=");
        }

        public void handleSensorData123(string strData)
        {
            string dt = DateTime.Now.ToString("s");
            extractSensorData123(strData, dt);
            string strMessage = dt + ":" + strData;
            listBox1.Items.Insert(0, strMessage);
        }

        public void processDataReceive123(string strData)
        {
            if (strData.IndexOf("Ultra=") != -1) {
                myprocessDataDelegate123 d = new myprocessDataDelegate123(handleSensorData123);
                listBox1.Invoke(d, new object[] { strData });
            }
            
        }

        public void commsDataRecieve124(string dataReceived123)
        {
            processDataReceive123(dataReceived123);
        }

        public void commsSendError123(string errMsg123)
        {
            MessageBox.Show(errMsg123);
            processDataReceive123(errMsg123);
        }
        private void InitComms()
        {

            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecieve124);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError123);


        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {

        }

        private void Roomtemptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clearbtn2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void Roomtemptxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Status2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("STOP");
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
