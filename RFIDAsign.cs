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
    public partial class RFIDAsign : Form
    {
        
        public RFIDAsign()
        {
            InitializeComponent();
        }
        
        string strConnectionString = ConfigurationManager.ConnectionStrings["SampleDBConnection"].ConnectionString;
      
        private void Userupdatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RFIDupdatetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect1 = new SqlConnection(strConnectionString);
            myConnect1.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDAsigntxt.Text))
            {
                MessageBox.Show("Please scan your RFID again ! ");
            }
            else if (string.IsNullOrWhiteSpace(Userupdatetxt.Text))
            {
                MessageBox.Show("Please enter the UserName ! ");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and RFID exists in database
                string strCommandText = "SELECT * FROM UserAccount WHERE  NAME=@uqqName";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect1);
                //cmd.Parameters.AddWithValue("@RFID", textBox2.Text);
                cmd.Parameters.AddWithValue("@uqqName", Userupdatetxt.Text);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string strCommandfindusedfrid = "SELECT * FROM UserAccount WHERE RFID_ID=@RFID12";
                        SqlCommand cmdfindusedfried = new SqlCommand(strCommandfindusedfrid, myConnect1);
                        cmdfindusedfried.Parameters.AddWithValue("@RFID12", RFIDAsigntxt.Text);

                        string strCommandfindusedfrid1 = "SELECT * FROM UserAccount WHERE RFID_ID !='NoRFID' AND Name=@Usernama";
                        SqlCommand cmdfindusedfried1 = new SqlCommand(strCommandfindusedfrid1, myConnect1);
                        cmdfindusedfried1.Parameters.AddWithValue("@Usernama", Userupdatetxt.Text);
                        try
                        {
                            myConnect1.Close();
                            myConnect1.Open();
                            SqlDataReader reader2 = cmdfindusedfried1.ExecuteReader();
                            if (reader2.Read())
                            {
                                MessageBox.Show("A RFID has been asign to this username before !");
                                MessageBox.Show("Fail to asign , kindly uses other username!");
                            }
                            else {
                                try
                                {
                                    myConnect1.Close();
                                    myConnect1.Open();
                                    SqlDataReader reader1 = cmdfindusedfried.ExecuteReader();
                                    if (reader1.Read())
                                    {
                                        MessageBox.Show("This RFID being use !");
                                        MessageBox.Show("Fail to update , kindly use another FRID !");
                                    }

                                    else
                                    {
                                        // Enter into admin form
                                        MessageBox.Show("Asigning");
                                        string delete = "UPDATE UserAccount SET RFID_ID=@idk WHERE NAME=@uqqqName  AND RFID_ID ='NoRFID'";
                                        myConnect1.Close();
                                        myConnect1.Open();
                                        SqlCommand cmd12 = new SqlCommand(delete, myConnect1);
                                        cmd12.Parameters.AddWithValue("@uqqqName", Userupdatetxt.Text);
                                        cmd12.Parameters.AddWithValue("@idk", RFIDAsigntxt.Text);

                                        cmd12.ExecuteNonQuery(); // It executes the sql command

                                        myConnect1.Close();
                                        myConnect1.Open();
                                        string update_MA_RFID = "UPDATE Manage_RFID SET RFID_STATUS='Active' WHERE RFID_ID=@idk";
                                        SqlCommand cmd2 = new SqlCommand(update_MA_RFID, myConnect1);
                                        cmd2.Parameters.AddWithValue("@idk", RFIDAsigntxt.Text);
                                        cmd2.ExecuteNonQuery();
                                        myConnect1.Close();
                                        MessageBox.Show("Asigned ! ");
                                    


                                        //dataComms.sendData("RFIDSUCC");
                                    }
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message.ToString());
                                }
                                finally
                                {
                                    myConnect1.Close();
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error: " + ex.Message.ToString());
                        }
                        finally
                        {
                            myConnect1.Close();
                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username ");
                        // MessageBox.Show("This RFID is used or the Username have an exisiting RFID ");
                        MessageBox.Show("Fail to update ! ");
                        // dataComms.sendData("RFIDFAIL");
                    }
                }


                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    myConnect1.Close();
                }
            }
        }
       

        //on the place where you will reload form1

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
            if (this.RFIDAsigntxt.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RFIDAsigntxt.Text = text;
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

        private void AsignRFID_Load(object sender, EventArgs e)
        {

            idk.dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            idk.dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
       
       
    }
    }


