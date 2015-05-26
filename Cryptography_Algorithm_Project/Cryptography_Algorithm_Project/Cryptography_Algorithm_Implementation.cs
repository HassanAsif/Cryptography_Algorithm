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
            //Binding Socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);
            //Connecting to Remote IP
            epRemote = new IPEndPoint(IPAddress.Parse( textRemoteIP .Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);
            MessageBox.Show("Connected succssfully. Click ok to proceed further.");
            Connect_panel.Hide();
            //Listening the Specific Port
            buffer = new byte[1500];
       
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
           
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            try
            {
                
                byte[] receiveddata = new byte[1500];
                receiveddata = ((byte[])aResult.AsyncState);
                //Converting Byte Array to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedmessage = aEncoding.GetString(receiveddata);
                //Adding message to list-of-messages
                if (receivedmessage!= null)
                {

                    speech.Rate = 1;
                    speech.Volume = 100;
                    CHAT_HISTORY.Items.Add("Friend: " + receivedmessage);
                    speech.Speak(receivedmessage);
                }
                //Again Calling Function "MessageCallback"
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error 1: " +ex.ToString());
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
            //Adding to list-box
            CHAT_HISTORY.Items.Add("Me :  " + input_textBox.Text);
            input_textBox.Text = "";
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
                MessageBox.Show("Message Text Box is empty.");
            }
        }

        private void RSAgroupBox_Enter(object sender, EventArgs e)
        {
            RSASendbutton.Visible = true;
        }
        //..............   RSA Cipher Functions ....................
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
        //....................................................................

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

        private void RSADecryptbutton_Click(object sender, EventArgs e)
        {
            DecryptRSAtextBox.Visible = true;
            byte[] decryptedtex = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            DecryptRSAtextBox.Text = ByteConverter.GetString(decryptedtex);
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
                MessageBox.Show("PIN Number correct. Click Ok to proceed.");
                Login_panel .Hide();
                Connect_panel.Show();


            }
            else
            {
                MessageBox.Show("User Name and Password are incorrect.");
               
                pass_textBox.Text = "";
            }
        }

        private void Login_panel_Paint(object sender, PaintEventArgs e)
        {
            this.Show();
        }

        private void Create_label_Click(object sender, EventArgs e)
        {

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
            pass_textBox.Text="";
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        
      
       
    }
}
