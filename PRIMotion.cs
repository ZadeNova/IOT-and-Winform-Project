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
    public partial class PRIMotion : Form
    {
        public PRIMotion()
        {
            InitializeComponent();
        }

        private void PRIMotion_Load(object sender, EventArgs e)
        {
            //InitComms();
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataRecievePRI);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendErrorPRI);

        }
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
       // DataComms dataComms;

        public delegate void myprocessDataDelegatePRI(String strData);
        private void saveprisSensorDataToDB(string strTime, string strUltraValue)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "INSERT PRI_table (DATETIME, PRI_status, userid)" + "VALUES (@time, @value, @user)";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@value", strUltraValue);
            updateCmd.Parameters.AddWithValue("@user", User.AccountID);


            myconnect.Open();

            int result = updateCmd.ExecuteNonQuery();
            myconnect.Close();
        }

        private string extractStringValuePRI(string strData, string ID)
        {
            string result123 = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result123;
        }

        private float extractFloatValuePRI(string strData, string ID)
        {
            return (float.Parse(extractStringValuePRI(strData, ID)));
        }

        private void handleLightSensorDataPRI(string strData, string strTime, string ID)
        {
            string strUltraValuePRI = extractStringValuePRI(strData, ID);
            Roomtemptxt.Text = strUltraValuePRI;
            //Roomtemptxt.Text = strUltraValuePRI;
            Console.WriteLine(strUltraValuePRI);
            if (strUltraValuePRI == "True") {
                saveprisSensorDataToDB(strTime, strUltraValuePRI);
            }
            
        }

        private void handleButtonDataPRI(string strData, string strTime, string ID)
        {
            string strbuttonValue = extractStringValuePRI(strData, ID);
           
        }

        private void extractSensorDataPRI(string strData, string strTime)
        {
            if (strData.IndexOf("PRI=") != -1)
                handleLightSensorDataPRI(strData, strTime, "PRI=");
        }

        public void handleSensorDataPRI(string strData)
        {
            string dt = DateTime.Now.ToString("s");
            extractSensorDataPRI(strData, dt);
            string strMessage = dt + ":" + strData;
            listBox1.Items.Insert(0, strMessage);
        }

        public void processDataReceivePRI(string strData)
        {
            if (strData.IndexOf("PRI=") != -1) {
                myprocessDataDelegatePRI d = new myprocessDataDelegatePRI(handleSensorDataPRI);
                listBox1.Invoke(d, new object[] { strData });
            }
              
        }

        public void commsDataRecievePRI(string dataReceivedPRI3)
        {
            processDataReceivePRI(dataReceivedPRI3);
        }

        public void commsSendErrorPRI(string errMsgPRI)
        {
            MessageBox.Show(errMsgPRI);
            processDataReceivePRI(errMsgPRI);
        }   
       

        private void Roomtemptxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Console.WriteLine("clearing data");
        }

        private void Status2txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idk.dataComms.sendData("STOP");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
