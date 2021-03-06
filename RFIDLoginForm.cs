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
using System.Net.Sockets;

namespace WinFormIOTProject
{

    public partial class RFIDLoginForm : Form
    {


        public RFIDLoginForm()
        {
            InitializeComponent();
        }

        private void RFIDLoginForm_Load(object sender, EventArgs e)
        {
            // InitComms();
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);

        }

        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        DataComms dataComms;


        public delegate void myprocessDataDelegate(String strData);
        // To save your sensor data to DB you need to change to suite your project needs
        private void RFIDSensorDataToDB(string strTime, string RfidID)
        {
            // Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            // Step 2 . Create Command
            String strCommandText = "";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            // Step 3
            myConnect.Open();

            //Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            //Step 5: Close Connection 
            myConnect.Close();

        }// End function

        // Dont edit this
        public string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

        //Dont edit
        public float extractFloatValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }
        public void HandleRFIDdata(string strData, string strTime, string ID)
        {
            string strRFIDValue = extractStringValue(strData, ID);
            //Update GUI data

            Console.WriteLine(strRFIDValue);
            //RFIDtxt.Text= strRFIDValue;
            Console.WriteLine("THIS FUNC EXECUTE");
            if (strData.IndexOf("RFIDLo=") != -1) {
                SetText(strRFIDValue);
            }
           
            // write all the logic here to extract float or int or string
            // Here is the place for the data to communicate with the UI of winforms

            //RFIDSensorDataToDB();


        }
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.RFIDtxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RFIDtxt.Text = text;
            }
        }

        //private void handleButtonData(string strData, string strTime , string ID)
        //{
        //    string strButtonValue = extractStringValue(strData, ID);
        //    // Update the GUI for windows form
        //}

        private void extractSensorData(string strData, string strTime)
        {
            //Any type of data may be send over by hardware
            // so you need to always check what data is received
            // before extracting the information
            // check whether the sensor data is sending form hardware

            Console.WriteLine(strData);
            Console.WriteLine(strTime);
            Console.WriteLine("im here lol");
            if (strData.IndexOf("RFIDLo=") != -1)
            {
                HandleRFIDdata(strData, strTime, "RFIDLo=");
            }
            else if (strData.IndexOf("BUTTON=") != -1)
            {

                //handleButtonData(strData, strTime, "BUTTON=");

            }//Check button status





        }

        // Zade create register time for all users.

        // Raw data received from hardware comes here
        public void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("s"); //Get current time
            extractSensorData(strData, dt); //Get sensor values out
            Console.WriteLine("Handle sensordata");
            // Update raw data received to listbox
            string strMessage = dt + ":" + strData;
            ////lbDataComms.Items.Insert(0, strMessage);
            Console.WriteLine(strData + "ste data from handle sensor data ");
        }

        // This method is automatically called when data is received
        public void processDataReceive(String strData)
        {
            //handleSensorData(strData);
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            d.Invoke(strData);
            Console.WriteLine(d + "this d ");
            ////lbDataComms.Invoke(d,new object[] { strData });
            Console.WriteLine("Process data receive");
        }

        // This method is automatically called when data is received
        public void commsDataReceive(string dataReceived)
        {
            processDataReceive(dataReceived);
        }
        // This method is automatically called when there is error
        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);

        }

        // This method must be called right at the start for data communications
        private void InitComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void RFIDLoginFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void RFIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        // Write the code to send data from windows form to raspberry pi
        // Check 5B first
        // Check 5A for Raspberry pi codes.


        private void Testingbtn_Click(object sender, EventArgs e)
        {


            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDtxt.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and password exists in database
               

                string strCommandText12 = "SELECT * FROM Manage_RFID WHERE RFID_ID=@RFID AND RFID_STATUS ='Disable'";
                SqlCommand cmd12 = new SqlCommand(strCommandText12, myConnect);
                cmd12.Parameters.AddWithValue("@RFID", RFIDtxt.Text);
                try
                {
                    SqlDataReader reader12 = cmd12.ExecuteReader();
                    if (reader12.Read())
                    {
                        MessageBox.Show("RFID being Disable , contact admin !");
                    }
                    else {
                        string strCommandText = "SELECT * FROM UserAccount WHERE RFID_ID=@RFID ";
                        SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                        cmd.Parameters.AddWithValue("@RFID", RFIDtxt.Text);
                        myConnect.Close();
                        myConnect.Open();
                        try
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                // Enter into admin form
                                MessageBox.Show("Login Successful");
                                idk.dataComms.sendData("RFIDSUCC");
                                this.Hide();
                                User.AccountUsername = reader["NAME"].ToString();
                                User.AccountEmail = reader["Email"].ToString();
                                User.AccountRole = reader["Role"].ToString();
                                User.AccountID = Convert.ToInt16(reader["Id"]);
                                AdminDashboard form2 = new AdminDashboard();
                                form2.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Login Unsuccessful");
                                idk.dataComms.sendData("RFIDFAIL");

                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message.ToString());
                        }
                        finally
                        {
                            myConnect.Close();
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myConnect.Close();
                }
               





            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm f2 = new LoginForm();
            f2.Show();
            this.Hide();
        }
    }





}