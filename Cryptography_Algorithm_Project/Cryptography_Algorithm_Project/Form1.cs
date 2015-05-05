using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Algorithm_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_message_Click(object sender, EventArgs e)
        {
            encrypt_label.Visible = true;
            Encrypt_textBox.Visible =  true;

        }

        private void Play_Fair_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Key_textBox.TextLength != 0 && input_textBox.TextLength != 0)
            {
                Encrypt_textBox.Visible = true;
                encrypt_label.Visible = true;
            }
        }

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

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
