namespace Cryptography_Algorithm_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.VigenereEncrypt_textBox = new System.Windows.Forms.TextBox();
            this.input_messagelabel = new System.Windows.Forms.Label();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.Vigenere_Button = new System.Windows.Forms.RadioButton();
            this.key_label = new System.Windows.Forms.Label();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.Vigeneredecrypt_textBox = new System.Windows.Forms.TextBox();
            this.decrypt_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.portLabel1 = new System.Windows.Forms.Label();
            this.ipLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textRemoteIP = new System.Windows.Forms.TextBox();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.iplabel2 = new System.Windows.Forms.Label();
            this.portlabel2 = new System.Windows.Forms.Label();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.VigenerebuttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RSAButton = new System.Windows.Forms.RadioButton();
            this.chatBoxLabel = new System.Windows.Forms.Label();
            this.encryptdecryptsendgroupBox = new System.Windows.Forms.GroupBox();
            this.RSAgroupBox = new System.Windows.Forms.GroupBox();
            this.RSADecryptbutton = new System.Windows.Forms.Button();
            this.RSAEncryptbutton = new System.Windows.Forms.Button();
            this.RSASendbutton = new System.Windows.Forms.Button();
            this.DecryptRSAtextBox = new System.Windows.Forms.TextBox();
            this.EncryptRSAtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.encryptdecryptsendgroupBox.SuspendLayout();
            this.RSAgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(9, 32);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(487, 31);
            this.input_textBox.TabIndex = 0;
            // 
            // VigenereEncrypt_textBox
            // 
            this.VigenereEncrypt_textBox.Location = new System.Drawing.Point(9, 32);
            this.VigenereEncrypt_textBox.Multiline = true;
            this.VigenereEncrypt_textBox.Name = "VigenereEncrypt_textBox";
            this.VigenereEncrypt_textBox.Size = new System.Drawing.Size(233, 34);
            this.VigenereEncrypt_textBox.TabIndex = 1;
            // 
            // input_messagelabel
            // 
            this.input_messagelabel.AutoSize = true;
            this.input_messagelabel.Location = new System.Drawing.Point(4, 16);
            this.input_messagelabel.Name = "input_messagelabel";
            this.input_messagelabel.Size = new System.Drawing.Size(128, 13);
            this.input_messagelabel.TabIndex = 2;
            this.input_messagelabel.Text = "Type your message  :";
            // 
            // encrypt_label
            // 
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.Location = new System.Drawing.Point(3, 16);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(67, 13);
            this.encrypt_label.TabIndex = 3;
            this.encrypt_label.Text = "Encryption";
            // 
            // Vigenere_Button
            // 
            this.Vigenere_Button.AutoSize = true;
            this.Vigenere_Button.Location = new System.Drawing.Point(26, 19);
            this.Vigenere_Button.Name = "Vigenere_Button";
            this.Vigenere_Button.Size = new System.Drawing.Size(115, 17);
            this.Vigenere_Button.TabIndex = 7;
            this.Vigenere_Button.TabStop = true;
            this.Vigenere_Button.Text = "Vigenere Cipher";
            this.Vigenere_Button.UseVisualStyleBackColor = true;
            this.Vigenere_Button.CheckedChanged += new System.EventHandler(this.Vigenere_Button_CheckedChanged);
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(6, 66);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(318, 13);
            this.key_label.TabIndex = 9;
            this.key_label.Text = "Key(only required when executing vigenere algorithm) :";
            // 
            // Key_textBox
            // 
            this.Key_textBox.Location = new System.Drawing.Point(6, 84);
            this.Key_textBox.Multiline = true;
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(490, 27);
            this.Key_textBox.TabIndex = 10;
            // 
            // Vigeneredecrypt_textBox
            // 
            this.Vigeneredecrypt_textBox.Location = new System.Drawing.Point(9, 85);
            this.Vigeneredecrypt_textBox.Multiline = true;
            this.Vigeneredecrypt_textBox.Name = "Vigeneredecrypt_textBox";
            this.Vigeneredecrypt_textBox.Size = new System.Drawing.Size(233, 40);
            this.Vigeneredecrypt_textBox.TabIndex = 11;
            // 
            // decrypt_label
            // 
            this.decrypt_label.AutoSize = true;
            this.decrypt_label.Location = new System.Drawing.Point(3, 69);
            this.decrypt_label.Name = "decrypt_label";
            this.decrypt_label.Size = new System.Drawing.Size(68, 13);
            this.decrypt_label.TabIndex = 12;
            this.decrypt_label.Text = "Decryption";
            this.decrypt_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.portLabel1);
            this.groupBox1.Controls.Add(this.ipLabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(96, 62);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(180, 20);
            this.textLocalPort.TabIndex = 3;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(96, 30);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(180, 20);
            this.textLocalIp.TabIndex = 2;
            // 
            // portLabel1
            // 
            this.portLabel1.AutoSize = true;
            this.portLabel1.Location = new System.Drawing.Point(8, 69);
            this.portLabel1.Name = "portLabel1";
            this.portLabel1.Size = new System.Drawing.Size(30, 13);
            this.portLabel1.TabIndex = 1;
            this.portLabel1.Text = "Port";
            // 
            // ipLabel1
            // 
            this.ipLabel1.AutoSize = true;
            this.ipLabel1.Location = new System.Drawing.Point(8, 30);
            this.ipLabel1.Name = "ipLabel1";
            this.ipLabel1.Size = new System.Drawing.Size(19, 13);
            this.ipLabel1.TabIndex = 0;
            this.ipLabel1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textRemoteIP);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.iplabel2);
            this.groupBox2.Controls.Add(this.portlabel2);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 102);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Location = new System.Drawing.Point(92, 27);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.Size = new System.Drawing.Size(188, 20);
            this.textRemoteIP.TabIndex = 4;
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(92, 66);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(188, 20);
            this.textRemotePort.TabIndex = 5;
            // 
            // iplabel2
            // 
            this.iplabel2.AutoSize = true;
            this.iplabel2.Location = new System.Drawing.Point(7, 30);
            this.iplabel2.Name = "iplabel2";
            this.iplabel2.Size = new System.Drawing.Size(19, 13);
            this.iplabel2.TabIndex = 2;
            this.iplabel2.Text = "IP";
            // 
            // portlabel2
            // 
            this.portlabel2.AutoSize = true;
            this.portlabel2.Location = new System.Drawing.Point(7, 69);
            this.portlabel2.Name = "portlabel2";
            this.portlabel2.Size = new System.Drawing.Size(30, 13);
            this.portlabel2.TabIndex = 3;
            this.portlabel2.Text = "Port";
            // 
            // listMessages
            // 
            this.listMessages.BackColor = System.Drawing.SystemColors.Window;
            this.listMessages.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Location = new System.Drawing.Point(12, 146);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(298, 329);
            this.listMessages.TabIndex = 15;
            // 
            // VigenerebuttonSend
            // 
            this.VigenerebuttonSend.Location = new System.Drawing.Point(155, 136);
            this.VigenerebuttonSend.Name = "VigenerebuttonSend";
            this.VigenerebuttonSend.Size = new System.Drawing.Size(87, 23);
            this.VigenerebuttonSend.TabIndex = 16;
            this.VigenerebuttonSend.Text = "Send";
            this.VigenerebuttonSend.UseVisualStyleBackColor = true;
            this.VigenerebuttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(714, 54);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 23);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.input_textBox);
            this.groupBox3.Controls.Add(this.input_messagelabel);
            this.groupBox3.Controls.Add(this.Key_textBox);
            this.groupBox3.Controls.Add(this.key_label);
            this.groupBox3.Location = new System.Drawing.Point(330, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 117);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " (Use only characters \"a - z\")";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RSAButton);
            this.groupBox4.Controls.Add(this.Vigenere_Button);
            this.groupBox4.Location = new System.Drawing.Point(330, 246);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 58);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Choose Cryptography Algorithm for Chat";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // RSAButton
            // 
            this.RSAButton.AutoSize = true;
            this.RSAButton.Location = new System.Drawing.Point(169, 20);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(264, 17);
            this.RSAButton.TabIndex = 17;
            this.RSAButton.TabStop = true;
            this.RSAButton.Text = "RSA Cipher(Keys automatically generated)";
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.CheckedChanged += new System.EventHandler(this.RSAButton_CheckedChanged);
            // 
            // chatBoxLabel
            // 
            this.chatBoxLabel.AutoSize = true;
            this.chatBoxLabel.Location = new System.Drawing.Point(14, 127);
            this.chatBoxLabel.Name = "chatBoxLabel";
            this.chatBoxLabel.Size = new System.Drawing.Size(58, 13);
            this.chatBoxLabel.TabIndex = 20;
            this.chatBoxLabel.Text = "Chat Box";
            // 
            // encryptdecryptsendgroupBox
            // 
            this.encryptdecryptsendgroupBox.Controls.Add(this.Vigeneredecrypt_textBox);
            this.encryptdecryptsendgroupBox.Controls.Add(this.VigenereEncrypt_textBox);
            this.encryptdecryptsendgroupBox.Controls.Add(this.VigenerebuttonSend);
            this.encryptdecryptsendgroupBox.Controls.Add(this.decrypt_label);
            this.encryptdecryptsendgroupBox.Controls.Add(this.encrypt_label);
            this.encryptdecryptsendgroupBox.Location = new System.Drawing.Point(330, 310);
            this.encryptdecryptsendgroupBox.Name = "encryptdecryptsendgroupBox";
            this.encryptdecryptsendgroupBox.Size = new System.Drawing.Size(252, 165);
            this.encryptdecryptsendgroupBox.TabIndex = 22;
            this.encryptdecryptsendgroupBox.TabStop = false;
            this.encryptdecryptsendgroupBox.Text = "Vigenere (Encrypt --- Decrypt ---- Send)";
            this.encryptdecryptsendgroupBox.Visible = false;
            // 
            // RSAgroupBox
            // 
            this.RSAgroupBox.Controls.Add(this.RSADecryptbutton);
            this.RSAgroupBox.Controls.Add(this.RSAEncryptbutton);
            this.RSAgroupBox.Controls.Add(this.RSASendbutton);
            this.RSAgroupBox.Controls.Add(this.DecryptRSAtextBox);
            this.RSAgroupBox.Controls.Add(this.EncryptRSAtextBox);
            this.RSAgroupBox.Location = new System.Drawing.Point(588, 310);
            this.RSAgroupBox.Name = "RSAgroupBox";
            this.RSAgroupBox.Size = new System.Drawing.Size(252, 165);
            this.RSAgroupBox.TabIndex = 23;
            this.RSAgroupBox.TabStop = false;
            this.RSAgroupBox.Text = "RSA(Encrypt --- Decrypt ---- Send)";
            this.RSAgroupBox.Visible = false;
            this.RSAgroupBox.Enter += new System.EventHandler(this.RSAgroupBox_Enter);
            // 
            // RSADecryptbutton
            // 
            this.RSADecryptbutton.Location = new System.Drawing.Point(6, 83);
            this.RSADecryptbutton.Name = "RSADecryptbutton";
            this.RSADecryptbutton.Size = new System.Drawing.Size(60, 23);
            this.RSADecryptbutton.TabIndex = 25;
            this.RSADecryptbutton.Text = "Decrypt";
            this.RSADecryptbutton.UseVisualStyleBackColor = true;
            this.RSADecryptbutton.Click += new System.EventHandler(this.RSADecryptbutton_Click);
            // 
            // RSAEncryptbutton
            // 
            this.RSAEncryptbutton.Location = new System.Drawing.Point(6, 19);
            this.RSAEncryptbutton.Name = "RSAEncryptbutton";
            this.RSAEncryptbutton.Size = new System.Drawing.Size(60, 23);
            this.RSAEncryptbutton.TabIndex = 24;
            this.RSAEncryptbutton.Text = "Encrypt";
            this.RSAEncryptbutton.UseVisualStyleBackColor = true;
            this.RSAEncryptbutton.Click += new System.EventHandler(this.RSAEncryptbutton_Click);
            // 
            // RSASendbutton
            // 
            this.RSASendbutton.Location = new System.Drawing.Point(159, 136);
            this.RSASendbutton.Name = "RSASendbutton";
            this.RSASendbutton.Size = new System.Drawing.Size(87, 23);
            this.RSASendbutton.TabIndex = 16;
            this.RSASendbutton.Text = "Sending";
            this.RSASendbutton.UseVisualStyleBackColor = true;
            this.RSASendbutton.Visible = false;
            this.RSASendbutton.Click += new System.EventHandler(this.RSASendbutton_Click);
            // 
            // DecryptRSAtextBox
            // 
            this.DecryptRSAtextBox.Location = new System.Drawing.Point(70, 83);
            this.DecryptRSAtextBox.Multiline = true;
            this.DecryptRSAtextBox.Name = "DecryptRSAtextBox";
            this.DecryptRSAtextBox.Size = new System.Drawing.Size(179, 47);
            this.DecryptRSAtextBox.TabIndex = 11;
            this.DecryptRSAtextBox.Visible = false;
            this.DecryptRSAtextBox.TextChanged += new System.EventHandler(this.DecryptRSAtextBox_TextChanged);
            // 
            // EncryptRSAtextBox
            // 
            this.EncryptRSAtextBox.Location = new System.Drawing.Point(70, 21);
            this.EncryptRSAtextBox.Multiline = true;
            this.EncryptRSAtextBox.Name = "EncryptRSAtextBox";
            this.EncryptRSAtextBox.Size = new System.Drawing.Size(176, 56);
            this.EncryptRSAtextBox.TabIndex = 1;
            this.EncryptRSAtextBox.Visible = false;
            this.EncryptRSAtextBox.TextChanged += new System.EventHandler(this.EncryptRSAtextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(838, 487);
            this.Controls.Add(this.RSAgroupBox);
            this.Controls.Add(this.encryptdecryptsendgroupBox);
            this.Controls.Add(this.chatBoxLabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Hassan-Chat-Box";
            this.TransparencyKey = System.Drawing.Color.DarkGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.encryptdecryptsendgroupBox.ResumeLayout(false);
            this.encryptdecryptsendgroupBox.PerformLayout();
            this.RSAgroupBox.ResumeLayout(false);
            this.RSAgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox VigenereEncrypt_textBox;
        private System.Windows.Forms.Label input_messagelabel;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.RadioButton Vigenere_Button;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.TextBox Vigeneredecrypt_textBox;
        private System.Windows.Forms.Label decrypt_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label portLabel1;
        private System.Windows.Forms.Label ipLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRemoteIP;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.Label iplabel2;
        private System.Windows.Forms.Label portlabel2;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Button VigenerebuttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label chatBoxLabel;
        private System.Windows.Forms.RadioButton RSAButton;
        private System.Windows.Forms.GroupBox encryptdecryptsendgroupBox;
        private System.Windows.Forms.GroupBox RSAgroupBox;
        private System.Windows.Forms.Button RSADecryptbutton;
        private System.Windows.Forms.Button RSAEncryptbutton;
        private System.Windows.Forms.Button RSASendbutton;
        private System.Windows.Forms.TextBox DecryptRSAtextBox;
        private System.Windows.Forms.TextBox EncryptRSAtextBox;
    }
}

