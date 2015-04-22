using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            text_encrypt.Visible = true;
            Encrypt_textBox.Visible =  true;

        }

        private void Play_Fair_Button_CheckedChanged(object sender, EventArgs e)
        {
            Encrypt_textBox.Visible = true;
            text_encrypt.Visible = true;
        }

        private void Vigenere_Button_CheckedChanged(object sender, EventArgs e)
        {
            Encrypt_textBox.Visible = true;
            text_encrypt.Visible = true;
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
