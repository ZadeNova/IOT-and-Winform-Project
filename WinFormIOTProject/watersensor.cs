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
        delegate void SetTextCallback(string text);
        private void SetTexttemlisttext(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTexttemlisttext);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox1.Text = text;
                this.listBox1.Items.Insert(0, text);
            }
        }



        private void SetTexttemvaltext(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Roomtemptxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTexttemvaltext);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Roomtemptxt.Text = text;
            }
        }

        private void SetTexttemstatext(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Status2txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTexttemstatext);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Status2txt.Text = text;
            }
        }
        private void handlewaterSensorData(string strData, string strTime, string ID)
        {
            string strCommandText3 = "SELECT * from WinformPieSetting where userid = @userid ";
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            SqlCommand cmd33 = new SqlCommand(strCommandText3, myConnect);
            cmd33.Parameters.AddWithValue("@userid", User.AccountID);
            myConnect.Open();
            SqlDataReader dr = cmd33.ExecuteReader();
            dr.Read();
            int temval = Convert.ToInt16(dr["watervalue"]);
            string temsta1 = dr["waterstatus"].ToString();
            string temsta2 = dr["waterstatus1"].ToString();
            dr.Close();
            myConnect.Close();

            string strwaterValue = extractStringValue(strData, ID);
            SetTexttemvaltext(strwaterValue);
           

            float flightValue = extractFloatValue(strData, ID);
            string status = "";
            if (flightValue <= temval)
                status = temsta1;
            else
                status = temsta2;
            SetTexttemstatext(status);
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
            SetTexttemlisttext(strData);
        }

        public void processDataReceive(string strData)
        {
            if (strData.IndexOf("Water=") != -1)
            {
                myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
                d.Invoke(strData);
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
