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
            this.Encrypt_textBox = new System.Windows.Forms.TextBox();
            this.input_message = new System.Windows.Forms.Label();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.Vigenere_Button = new System.Windows.Forms.RadioButton();
            this.key_label = new System.Windows.Forms.Label();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.decrypt_textBox = new System.Windows.Forms.TextBox();
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chatBoxLabel = new System.Windows.Forms.Label();
            this.RSAButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(68, 19);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(309, 67);
            this.input_textBox.TabIndex = 0;
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(16, 55);
            this.Encrypt_textBox.Multiline = true;
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(363, 41);
            this.Encrypt_textBox.TabIndex = 1;
            this.Encrypt_textBox.Visible = false;
            // 
            // input_message
            // 
            this.input_message.AutoSize = true;
            this.input_message.Location = new System.Drawing.Point(-3, 22);
            this.input_message.Name = "input_message";
            this.input_message.Size = new System.Drawing.Size(65, 13);
            this.input_message.TabIndex = 2;
            this.input_message.Text = "Message :";
            // 
            // encrypt_label
            // 
            this.encrypt_label.AutoSize = true;
            this.encrypt_label.Location = new System.Drawing.Point(3, 39);
            this.encrypt_label.Name = "encrypt_label";
            this.encrypt_label.Size = new System.Drawing.Size(67, 13);
            this.encrypt_label.TabIndex = 3;
            this.encrypt_label.Text = "Encryption";
            this.encrypt_label.Visible = false;
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
            this.key_label.Location = new System.Drawing.Point(6, 99);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(36, 13);
            this.key_label.TabIndex = 9;
            this.key_label.Text = "Key :";
            // 
            // Key_textBox
            // 
            this.Key_textBox.Location = new System.Drawing.Point(68, 99);
            this.Key_textBox.Multiline = true;
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(200, 27);
            this.Key_textBox.TabIndex = 10;
            // 
            // decrypt_textBox
            // 
            this.decrypt_textBox.Location = new System.Drawing.Point(16, 143);
            this.decrypt_textBox.Multiline = true;
            this.decrypt_textBox.Name = "decrypt_textBox";
            this.decrypt_textBox.Size = new System.Drawing.Size(361, 36);
            this.decrypt_textBox.TabIndex = 11;
            this.decrypt_textBox.Visible = false;
            // 
            // decrypt_label
            // 
            this.decrypt_label.AutoSize = true;
            this.decrypt_label.Location = new System.Drawing.Point(6, 127);
            this.decrypt_label.Name = "decrypt_label";
            this.decrypt_label.Size = new System.Drawing.Size(68, 13);
            this.decrypt_label.TabIndex = 12;
            this.decrypt_label.Text = "Decryption";
            this.decrypt_label.Visible = false;
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
            this.groupBox1.Size = new System.Drawing.Size(300, 102);
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
            this.groupBox2.Location = new System.Drawing.Point(320, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 102);
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
            this.listMessages.Location = new System.Drawing.Point(14, 146);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(333, 329);
            this.listMessages.TabIndex = 15;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(290, 102);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(87, 23);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Visible = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(644, 55);
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
            this.groupBox3.Controls.Add(this.input_message);
            this.groupBox3.Controls.Add(this.key_label);
            this.groupBox3.Controls.Add(this.Key_textBox);
            this.groupBox3.Location = new System.Drawing.Point(357, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 140);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " (Use only characters \"a - z\")";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RSAButton);
            this.groupBox4.Controls.Add(this.Vigenere_Button);
            this.groupBox4.Controls.Add(this.Encrypt_textBox);
            this.groupBox4.Controls.Add(this.encrypt_label);
            this.groupBox4.Controls.Add(this.decrypt_label);
            this.groupBox4.Controls.Add(this.buttonSend);
            this.groupBox4.Controls.Add(this.decrypt_textBox);
            this.groupBox4.Location = new System.Drawing.Point(357, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 185);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encrypt Message using Cryptography Algorithm";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            // RSAButton
            // 
            this.RSAButton.AutoSize = true;
            this.RSAButton.Location = new System.Drawing.Point(169, 20);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(50, 17);
            this.RSAButton.TabIndex = 17;
            this.RSAButton.TabStop = true;
            this.RSAButton.Text = "RSA";
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.CheckedChanged += new System.EventHandler(this.RSAButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(756, 487);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox Encrypt_textBox;
        private System.Windows.Forms.Label input_message;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.RadioButton Vigenere_Button;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.TextBox Key_textBox;
        private System.Windows.Forms.TextBox decrypt_textBox;
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
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label chatBoxLabel;
        private System.Windows.Forms.RadioButton RSAButton;
    }
}

