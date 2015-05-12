using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
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
          
            if (Key_textBox.TextLength != 0 && input_textBox.TextLength != 0)
            {
                string input_message = input_textBox.Text.ToUpper();
                string input_key = Key_textBox.Text.ToUpper();
                 input_key1 = input_key;
                Vigenere_Algorithm obj = new Vigenere_Algorithm(input_key);
                string get_encrypted_message = obj.encrypt_message(input_message);
                encrypt_label.Visible = true;
                Encrypt_textBox.Visible = true;
                Encrypt_textBox.Text = get_encrypted_message;
                buttonSend.Visible=true;
                string get_decrypt_message = "";
                get_decrypt_message = obj.decrypt_message(get_encrypted_message);
                decrypt_label.Visible = true;
                decrypt_textBox.Visible = true;
                decrypt_textBox.Text = get_decrypt_message;
                input_textBox.Text = " ";
                Key_textBox.Text = " ";
               // Vigenere_Button.Click = false;

            }
            else
            {
                MessageBox.Show("Message Text Box or Key Text Box is empty.");
            }
          
        }
      
        //private void Exit_button_Click(object sender, EventArgs e)
        //{
        //    Environment.Exit(0);
        //}

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
            //Listening the Specific Port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer); 
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                Vigenere_Algorithm obj1=new Vigenere_Algorithm(input_key1);
                byte[] receiveddata = new byte[1500];
                receiveddata = ((byte[])aResult.AsyncState);
                //Converting Byte Array to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedmessage = aEncoding.GetString(receiveddata);
                string get_decrypt_message = "";
             //   get_decrypt_message = obj1.decrypt_message(receivedmessage);
                //Adding message to list-of-messages
                listMessages.Items.Add("Friend : " + receivedmessage);
                //Again Calling Function "MessageCallback"
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Convert String into ByteArray
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingmessage = new byte[1500];
            sendingmessage = aEncoding.GetBytes(Encrypt_textBox.Text);
            //Sending Message
            sck.Send(sendingmessage);
            //Adding to list-box
            listMessages.Items.Add("Me : " + input_textBox.Text);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void RSAButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Key_textBox.TextLength != 0 && input_textBox.TextLength != 0)
            {
                string input_message = input_textBox.Text.ToUpper();
                string input_key = Key_textBox.Text.ToUpper();
               // Vigenere_Algorithm obj = new Vigenere_Algorithm(input_key);
               // string get_encrypted_message = obj.encrypt_message(input_message);
                encrypt_label.Visible = true;
                Encrypt_textBox.Visible = true;
               // Encrypt_textBox.Text = get_encrypted_message;
                buttonSend.Visible = true;
              //  string get_decrypt_message = "";
              //  get_decrypt_message = obj.decrypt_message(get_encrypted_message);
                decrypt_label.Visible = true;
                decrypt_textBox.Visible = true;
                //decrypt_textBox.Text = get_decrypt_message;
                input_textBox.Text = " ";
                Key_textBox.Text = " ";

            }
            else
            {
                MessageBox.Show("Message Text Box or Key Text Box is empty.");
            }
        }
        
      
       
    }
}
