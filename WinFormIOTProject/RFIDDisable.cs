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

namespace WinFormIOTProject
{
    public partial class RFIDDisable : Form
    {
        public RFIDDisable()
        {
            InitializeComponent();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDdeletetxt.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and password exists in database
               

                string strCommandText1 = "SELECT * FROM Manage_RFID WHERE RFID_ID=@RFID AND RFID_STATUS='Disable'";
                SqlCommand cmd1 = new SqlCommand(strCommandText1, myConnect);
                cmd1.Parameters.AddWithValue("@RFID", RFIDdeletetxt.Text);
                try
                {
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        MessageBox.Show("Cant Disable this RFID as this RFID is disabled previously");
                    }
                    else {
                        string strCommandText = "SELECT * FROM Manage_RFID WHERE RFID_ID=@RFID";
                        SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                        cmd.Parameters.AddWithValue("@RFID", RFIDdeletetxt.Text);
                        try
                        {
                            myConnect.Close();
                            myConnect.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                // Enter into admin form
                                MessageBox.Show("Disabling");
                                //string delete = "UPDATE UserAccount SET RFID_ID='NoRFID' WHERE RFID_ID=@idk";
                                //myConnect.Close();
                                //myConnect.Open();
                                //SqlCommand cmd1 = new SqlCommand(delete, myConnect);
                                //cmd1.Parameters.AddWithValue("@idk", RFIDdeletetxt.Text);
                                //cmd1.ExecuteNonQuery(); // It executes the sql command

                                myConnect.Close();
                                myConnect.Open();
                                string update_MA_RFID = "UPDATE Manage_RFID SET RFID_STATUS='Disable' WHERE RFID_ID=@idk";
                                SqlCommand cmd2 = new SqlCommand(update_MA_RFID, myConnect);
                                cmd2.Parameters.AddWithValue("@idk", RFIDdeletetxt.Text);
                                cmd2.ExecuteNonQuery();
                                myConnect.Close();
                                MessageBox.Show("Disabled");
                                //dataComms.sendData("RFIDSUCC");

                            }
                            else
                            {

                                MessageBox.Show("Invalid RFID ");
                                MessageBox.Show("Cant be Disable !  ");
                                // dataComms.sendData("RFIDFAIL");
                                
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
    

        private void RFIDdeletetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFIDDisable_Load(object sender, EventArgs e)
        {
            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
        DataComms dataComms;
        string RFIDUSERCHECK = "";
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
            string newText = strRFIDValue;


            // Running on the UI thread
            if (strData.IndexOf("RFID=") != -1)
            {
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
            if (this.RFIDdeletetxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RFIDdeletetxt.Text = text;
            }
        }
        private void extractSensorData(string strData, string strTime)
        {
            //Any type of data may be send over by hardware
            // so you need to always check what data is received
            // before extracting the information
            // check whether the sensor data is sending form hardware

            Console.WriteLine(strData);
            Console.WriteLine(strTime);
            Console.WriteLine("im here lol");
            if (strData.IndexOf("RFID=") != -1)
            {
                HandleRFIDdata(strData, strTime, "RFID=");
            }
            else if (strData.IndexOf("BUTTON=") != -1)
            {

                //handleButtonData(strData, strTime, "BUTTON=");

            }//Check button status





        }

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
    }
}
