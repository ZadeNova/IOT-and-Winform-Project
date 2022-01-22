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
        string count = "";
        float range123;
        
        DialogResult result;
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
            promtbox();

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
        private void updateSOUNDSensorDataToDB(string range1)
        {
            SqlConnection myconnect = new SqlConnection(strConnectionString);
            String strCommandText = "update WinformPieSetting set avgsoundvalue=@rangeidk where userid=@user1";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myconnect);
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

        private void promtbox() {

            string strCommandText3 = "SELECT * from WinformPieSetting where userid = @userid ";
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            SqlCommand cmd33 = new SqlCommand(strCommandText3, myConnect);
            cmd33.Parameters.AddWithValue("@userid", User.AccountID);
            myConnect.Open();
            SqlDataReader dr = cmd33.ExecuteReader();
            dr.Read();
            int soundvalue = Convert.ToInt16(dr["avgsoundvalue"]);
            string status1 = dr["soundstatus"].ToString();
            string status2 = dr["soundstatus1"].ToString();
            dr.Close();
            myConnect.Close();
            string message = "Do you want to use " + soundvalue + " as your average environment sound leve ? ";
            string title = "Prompt";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                idk.dataComms.sendData("SOUND");
            }
            else {
                idk.dataComms.sendData("SOUND1");
            }


        }
        private void handlewaterSensorData(string strData, string strTime, string ID)
        {
            string strsoundValue = extractStringValue(strData, ID);
            SetText1(strsoundValue);
            
          
            float flightValue = extractFloatValue(strData, ID);

            string strCommandText3 = "SELECT * from WinformPieSetting where userid = @userid ";
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            
            SqlCommand cmd33 = new SqlCommand(strCommandText3, myConnect);
            cmd33.Parameters.AddWithValue("@userid", User.AccountID);
            myConnect.Open();
            SqlDataReader dr = cmd33.ExecuteReader();
            dr.Read();
            int soundvalue = Convert.ToInt16(dr["avgsoundvalue"]);
            string status1 = dr["soundstatus"].ToString();
            string status2 = dr["soundstatus1"].ToString();
            dr.Close();
            myConnect.Close();
          
            if (result == DialogResult.Yes)
            {
              
                
                string status = "";
                if (flightValue <= soundvalue)
                    status = status1;
                else
                    status = status2;
                SetText2(status);
                string inrange = Convert.ToString(soundvalue);
                saveSOUNDSensorDataToDB(strTime, strsoundValue, status, inrange);
            }
            else
            {
               
                if (count != "10")
                {
                    if (numberList.Count != 10)
                    {
                        
                        numberList.Add(flightValue);
                        string text123 = "measuring average noise level";
                        SetText2(text123);
                    }
                    else
                    {
                        numberList = numberList.OrderBy(i => i).ToList();
                        float firstnu = numberList[0];
                        Console.WriteLine("first{0} ", firstnu);
                        float lastnum = numberList.LastOrDefault();
                        Console.WriteLine("sec{0} ", lastnum);
                        range123 = numberList.Average();
                       // range123 = (lastnum + firstnu)/10;
                        Console.WriteLine("range {0} ", range123);
                        string status = "";
                        if (flightValue <= range123)
                            status = status1;
                        else
                            status = status2;
                        SetText2(status);
                      
                        string inrange = Convert.ToString(Math.Round(range123,MidpointRounding.AwayFromZero));
                        saveSOUNDSensorDataToDB(strTime, strsoundValue, status, inrange);
                        updateSOUNDSensorDataToDB(inrange);

                        count = "10";
                        numberList.Clear();
                    }
                }
                else
                {
                    idk.dataComms.sendData("SOUND");
                    string status = "";
                    if (flightValue <= soundvalue)
                        status = status1;
                    else
                        status = status2;
                    SetText2(status);
                    string inrange = Convert.ToString(soundvalue);
                    saveSOUNDSensorDataToDB(strTime, strsoundValue, status, inrange);
                    //updateSOUNDSensorDataToDB(inrange);

                }
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
            SetText4(strMessage);
            //listBox1.Items.Insert(0, strMessage);
        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox1.Text = text;
                this.listBox1.Items.Insert(0, text);
            }
        }

        private void SetText4(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.listBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listBox1.Items.Insert(0,text);
            }
        }

        private void SetText1(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Roomtemptxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Roomtemptxt.Text = text;
            }
        }

        private void SetText2(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Status2txt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Status2txt.Text = text;
            }
        }


        public void processDataReceive(string strData)
        {

            if (strData.IndexOf("Sound=") != -1)
            {
                if (result == DialogResult.Yes || result == DialogResult.No)
                {
                    myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
                    d.Invoke(strData);
                }
                else {
                }
               
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
