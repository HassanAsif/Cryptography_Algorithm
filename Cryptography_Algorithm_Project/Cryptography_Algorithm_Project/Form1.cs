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
                Vigenere_Algorithm obj = new Vigenere_Algorithm(input_key);
                string get_encrypted_message = obj.encrypt_message(input_message);
                encrypt_label.Visible = true;
                Encrypt_textBox.Visible = true;
                Encrypt_textBox.Text = get_encrypted_message;
                
                string get_decrypt_message = "";
                get_decrypt_message = obj.decrypt_message(get_encrypted_message);
                decrypt_label.Visible = true;
                decrypt_textBox.Visible = true;
                decrypt_textBox.Text = get_decrypt_message;
                
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


        }
        
      
       
    }
}
