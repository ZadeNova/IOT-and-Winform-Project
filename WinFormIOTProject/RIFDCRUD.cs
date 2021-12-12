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
using System.Net.Sockets;
using System.Configuration;

namespace WinFormIOTProject
{
    public partial class RIFDCRUD : Form
    {
        public RIFDCRUD()
        {
            InitializeComponent();
        }

        private void RFIDTEST_Load(object sender, EventArgs e)
        {
            InitComms();
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


            RFIDtxtCheck.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                RFIDtxtCheck.Text = newText;
            });

            RFIDdeletetxt.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                RFIDdeletetxt.Text = newText;
            });

            RFIDupdatetxt.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                RFIDupdatetxt.Text = newText;
            });
            // write all the logic here to extract float or int or string
            // Here is the place for the data to communicate with the UI of winforms

            //RFIDSensorDataToDB();


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

        // This method must be called right at the start for data communications
        private void InitComms()
        {

            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);

        }

        private void Checknowbtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDtxtCheck.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and password exists in database
                string strCommandText = "SELECT * FROM UserAccount WHERE RFID_ID=@RFID ";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@RFID", RFIDtxtCheck.Text);


                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Enter into admin form
                        MessageBox.Show("This RFID being use !");
                        RFIDUSERCHECK = reader["NAME"].ToString();
                        Usernametxt.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            Usernametxt.Text = RFIDUSERCHECK;
                        });
                        Console.WriteLine(RFIDUSERCHECK);

                        //dataComms.sendData("RFIDSUCC");

                    }
                    else
                    {
                        MessageBox.Show("This RFID is new , not being use !");
                        RFIDUSERCHECK = "";
                        Usernametxt.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            Usernametxt.Text = RFIDUSERCHECK;
                        });
                        Console.WriteLine(RFIDUSERCHECK);
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDtxtCheck.Text))
            {
                MessageBox.Show("IsEmpty");
            }
            else
            {
                MessageBox.Show("Not Empty");

                // Check if user and password exists in database
                string strCommandText = "SELECT * FROM UserAccount WHERE RFID_ID=@RFID";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@RFID", RFIDtxtCheck.Text);


                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Enter into admin form
                        MessageBox.Show("Deleting");
                        string delete = "UPDATE UserAccount SET RFID_ID='NoRFID' WHERE RFID_ID=@idk";
                        myConnect.Close();
                        myConnect.Open();
                        SqlCommand cmd1 = new SqlCommand(delete, myConnect);
                        cmd1.Parameters.AddWithValue("@idk", RFIDtxtCheck.Text);
                        cmd1.ExecuteNonQuery(); // It executes the sql command
                        MessageBox.Show("Deleted");
                        myConnect.Close();
                        //dataComms.sendData("RFIDSUCC");

                    }
                    else
                    {

                        MessageBox.Show("This RFID is new , not being use !");
                        MessageBox.Show("Cant be deleted !  ");
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

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect1 = new SqlConnection(strConnectionString);
            myConnect1.Open();
            //
            //string strCommandText = "INSERT INTO UserAccounts(Name,Email,Password,Role,Status,RFID_ID) VALUES (@Name,@Email,@Password,@Role,@Status,@RFID_ID)";

            //SqlCommand cmd = new SqlCommand(strCommandText, myConnect);

            //Check if empty
            if (string.IsNullOrWhiteSpace(RFIDupdatetxt.Text))
            {
                MessageBox.Show("Please scan your RFID again ! ");
            }
            else if (string.IsNullOrWhiteSpace(Usernametxt.Text))
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
                cmd.Parameters.AddWithValue("@uqqName", Usernametxt.Text);

                try
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string strCommandfindusedfrid = "SELECT * FROM UserAccount WHERE RFID_ID=@RFID12";
                        SqlCommand cmdfindusedfried = new SqlCommand(strCommandfindusedfrid, myConnect1);
                        cmdfindusedfried.Parameters.AddWithValue("@RFID12", RFIDupdatetxt.Text);
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
                                MessageBox.Show("Updating");
                                string delete = "UPDATE UserAccount SET RFID_ID=@idk WHERE NAME=@uqqqName AND RFID_ID='NoRFID'";
                                myConnect1.Close();
                                myConnect1.Open();
                                SqlCommand cmd12 = new SqlCommand(delete, myConnect1);
                                cmd12.Parameters.AddWithValue("@uqqqName", Usernametxt.Text);
                                cmd12.Parameters.AddWithValue("@idk", RFIDupdatetxt.Text);

                                cmd12.ExecuteNonQuery(); // It executes the sql command
                                MessageBox.Show("Updated ! ");
                                myConnect1.Close();

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

        private void RFIDtxtCheck_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
