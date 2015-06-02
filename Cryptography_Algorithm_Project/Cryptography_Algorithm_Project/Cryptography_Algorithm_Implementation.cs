using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Cryptography_Algorithm_Project
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        string input_key1;
        Socket sck;
        //EndPoints
        EndPoint epLocal, epRemote;
        //Buffer used for reciving and sending messages
        byte[] buffer;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //setup socket
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp); //instantiating New socket
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress,true);
            //Get User IP's
            textLocalIp.Text = get_Local_IP();
            textRemoteIP.Text = get_Local_IP();
        }
        private string get_Local_IP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    return IP.ToString();
                }
            }
                return "127.0.0.1";
        }

        //private void send_message_Click(object sender, EventArgs e)
        //{
        //    encrypt_label.Visible = true;
        //    Encrypt_textBox.Visible =  true;

        //}

        private void Vigenere_Button_CheckedChanged(object sender, EventArgs e)
        {
           
            if (input_textBox.TextLength != 0)
            {
                
                    encryptdecryptsendgroupBox.Visible = true;

                    string input_message = input_textBox.Text.ToUpper();
                    string input_key = "ASDESYTR";
                    input_key1 = input_key;
                
                            Vigenere_Algorithm obj = new Vigenere_Algorithm(input_key);
                            string get_encrypted_message = obj.encrypt_message(input_message);
                            encrypt_label.Visible = true;
                            VigenereEncrypt_textBox.Visible = true;
                            VigenereEncrypt_textBox.Text = get_encrypted_message;
                            VigenerebuttonSend.Visible = true;
                            string get_decrypt_message = "";
                            get_decrypt_message = obj.decrypt_message(get_encrypted_message);
                            decrypt_label.Visible = true;
                            Vigeneredecrypt_textBox.Visible = true;
                            Vigeneredecrypt_textBox.Text = get_decrypt_message;
                           }
            else
            {
                MessageBox.Show("Message Text Box is empty.");
                speech.Speak("You can't proceed further because message Text Box is empty. Must enter something in the message box to proceed further.");
                
            }   
          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (textLocalPort.Text != "" && textRemotePort.Text != "")
                {
                    if (textLocalPort.Text != textRemotePort.Text)
                    {
                        //Binding Socket
                        epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                        sck.Bind(epLocal);
                        //Connecting to Remote IP
                        epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text), Convert.ToInt32(textRemotePort.Text));
                        sck.Connect(epRemote);
                        speech.Speak("Connection established successfully. Click OK button to proceed further.");
                        MessageBox.Show("Connected succssfully. Click ok to proceed further.");
                       
                        Connect_panel.Hide();
                        //Listening the Specific Port
                        buffer = new byte[1500];
                        sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                    }
                    else
                    {
                        speech.Speak("You can't enter same ports. Try again. ");
                        MessageBox.Show("You can't enter same ports. Try again. ");
                 
                        textLocalPort.Text = "";
                        textRemotePort.Text = "";
                    }
                }
                else
                {
                    speech.Speak("Ports are empty.Enter different ports.");
                    MessageBox.Show("Ports are empty.Enter different ports.");
                    
                }
            }
            catch (Exception err)
            {
                speech.Speak("Ports are empty. Kindly enter different suitable ports to proceed further.");
                MessageBox.Show("Connection Failed. Check your connection. ");
                
                throw;
            }
          
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            
            try
            {
                
                byte[] receiveddata = new byte[1500];
                receiveddata = ((byte[])aResult.AsyncState);
                //Converting Byte Array to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedmessage = aEncoding.GetString(receiveddata);
                //Adding message to list-of-messages
                if (receivedmessage != null)
                {
                    speech.Rate = 1;
                    speech.Volume = 100;
                    CHAT_HISTORY.Items.Add("Friend: " + receivedmessage);
                    speech.Speak(receivedmessage);
                   // MessageBox.Show("Message Received Successfully.");
                }
                else
                {
                   // CHAT_HISTORY.Items.Add("Freind: Server not responding check your connection.");
                    speech.Speak("Server not responding check your connection.");
                }
                //Again Calling Function "MessageCallback"
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error 1: " +ex.ToString());
                throw;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Convert String into ByteArray
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingmessage = new byte[1500];
            sendingmessage = aEncoding.GetBytes(Vigeneredecrypt_textBox.Text);
            //Sending Message
            sck.Send(sendingmessage);
            if (input_textBox.Text != null)
            {
            //Adding to list-box
            CHAT_HISTORY.Items.Add("Me :  " + input_textBox.Text);
          
               // MessageBox.Show("Message sent successfully.");
                input_textBox.Text = "";
            }
            else
            {
                //MessageBox.Show("You can't send an empty message. You must write something in the message textbox.");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        // RSA Cipher Functionality
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext; 

        private void RSAButton_CheckedChanged(object sender, EventArgs e)
        {
           
            if (input_textBox.TextLength != 0)
            {
                
                RSAgroupBox.Visible = true;
                
            }
            else
            {
                speech.Speak("You can't proceed further because message text box is empty. Write something in message box to proceed further.");
                MessageBox.Show("Message Text Box is empty.");
               
            }
        }

        private void RSAgroupBox_Enter(object sender, EventArgs e)
        {
            RSASendbutton.Visible = true;
        }
        // :::::::::::::::::::::: RSA Cipher Functions :::::::::::::::::::::::::::::::::::::: 
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                } return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
     
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        //:::::::::::::::::: RSA Encryption :::::::::::::::::::::::::

        private void RSAEncryptbutton_Click(object sender, EventArgs e)
        {
            EncryptRSAtextBox.Visible = true;
            plaintext = ByteConverter.GetBytes(input_textBox.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            EncryptRSAtextBox.Text = ByteConverter.GetString(encryptedtext);
        }

        private void EncryptRSAtextBox_TextChanged(object sender, EventArgs e)
        {

        }
        //:::::::::::::::::: RSA Decryption :::::::::::::::::::::::::
        private void RSADecryptbutton_Click(object sender, EventArgs e)
        {
            DecryptRSAtextBox.Visible = true;
            byte[] decryptedtext = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            DecryptRSAtextBox.Text = ByteConverter.GetString(decryptedtext);
        }

        private void DecryptRSAtextBox_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void RSASendbutton_Click(object sender, EventArgs e)
        {
            //Convert String into ByteArray
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingmessage = new byte[1500];

            sendingmessage = aEncoding.GetBytes(DecryptRSAtextBox.Text);
            //Sending Message
            sck.Send(sendingmessage);
            //Adding to list-box
            CHAT_HISTORY.Items.Add("Me : " + input_textBox.Text);
            input_textBox.Text = "";
            EncryptRSAtextBox.Text = "";
            DecryptRSAtextBox.Text = "";
            EncryptRSAtextBox.Hide();
            DecryptRSAtextBox.Hide();
        }
        private void RSAreceive_button()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           string password = "0340";
         
            if (password == pass_textBox.Text)
            {
                speech.Speak("You successfully login into the chat server. Click OK to proceed further.");
                MessageBox.Show("PIN Number correct. Click Ok to proceed.");
                
                
                Login_panel .Hide();
                Connect_panel.Show();
            }
            else
            {
                speech.Speak("You entered an invalid pin number or password. Kindly try again.");
                MessageBox.Show("Invalid Pin No or Password.");
               
                pass_textBox.Text = "";
            }
        }

        private void Login_panel_Paint(object sender, PaintEventArgs e)
        {
            this.Show();
        }

        private void Create_label_Click(object sender, EventArgs e)
        {
            //speech.Speak("Hello you clicked on me.");
        }

        private void Connect_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logingroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void buttonone_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonone.Text;
        }

        private void twobutton_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += twobutton.Text;
        }

        private void buttonthree_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonthree.Text;
        }

        private void buttonfour_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonfour.Text;
        }

        private void buttonfive_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonfive.Text;
        }

        private void buttonsix_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonsix.Text;
        }

        private void buttonseven_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonseven.Text;
        }

        private void buttoneight_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttoneight.Text;
        }

        private void buttonnine_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonnine.Text;
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            pass_textBox.Text += buttonzero.Text;
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            speech.Speak("Pin Number or Password Box is cleared. Write password again.");
            pass_textBox.Text="";
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Logoutbutton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Instructions_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            speech.Speak("This application is basically built for server client connection. Step1: Enter the port of server and client.Step2: Remember Ports of server and client should not be same.\rBut we can also make an client to client connection by just simply entring the IP of other client and vice versa.");
            MessageBox.Show(" This application is basically built for server client connection.\rStep1: Enter the port of server and client.\r Step2: Remember Ports of server and client should not be same.\rBut we can also make an client to client connection by just simply entring the IP of other client and vice versa.  ");
        }

        private void sendmessagehelp_label_Click(object sender, EventArgs e)
        {
            speech.Speak("Following things you should keep in mind while sending message.\r First, don't use any symbol or number in your message when you select vigenere algorithm because it ignores the symbols and numbers. Second, After writing message, select algorithm you want to use for security. Third, After selecting algorithm check whether it is doing right encryption or not.  At last, click send button to send the message. Once you click the send button the receiver will receive a text + voice message. ");
            MessageBox.Show("Following things you should keep in mind while sending message.\r First, don't use any symbol or number in your message when you select vigenere algorithm because it ignores the symbols and numbers.\r Second, After writing message, select algorithm you want to use for security.\r Third, After selecting algorithm check whether it is doing right encryption or not. \r At last, click send button to send the message.\r Once you click the send button the receiver will receive a text + voice message. ");
        }

        private void InfoVigenere_label_Click(object sender, EventArgs e)
        {
            Speech.Speak();
        }
        
      
       
    }
}
