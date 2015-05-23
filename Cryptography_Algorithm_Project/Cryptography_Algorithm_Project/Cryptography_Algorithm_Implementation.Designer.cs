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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input_textBox = new System.Windows.Forms.TextBox();
            this.VigenereEncrypt_textBox = new System.Windows.Forms.TextBox();
            this.input_messagelabel = new System.Windows.Forms.Label();
            this.encrypt_label = new System.Windows.Forms.Label();
            this.Vigenere_Button = new System.Windows.Forms.RadioButton();
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
            this.CHAT_HISTORY = new System.Windows.Forms.ListBox();
            this.VigenerebuttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectalgorithmgroupBox = new System.Windows.Forms.GroupBox();
            this.RSAButton = new System.Windows.Forms.RadioButton();
            this.encryptdecryptsendgroupBox = new System.Windows.Forms.GroupBox();
            this.RSAgroupBox = new System.Windows.Forms.GroupBox();
            this.RSADecryptbutton = new System.Windows.Forms.Button();
            this.RSAEncryptbutton = new System.Windows.Forms.Button();
            this.RSASendbutton = new System.Windows.Forms.Button();
            this.DecryptRSAtextBox = new System.Windows.Forms.TextBox();
            this.EncryptRSAtextBox = new System.Windows.Forms.TextBox();
            this.Create_label = new System.Windows.Forms.Label();
            this.Connect_panel = new System.Windows.Forms.Panel();
            this.Login_panel = new System.Windows.Forms.Panel();
            this.logingroupBox = new System.Windows.Forms.GroupBox();
            this.password_label = new System.Windows.Forms.Label();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.selectalgorithmgroupBox.SuspendLayout();
            this.encryptdecryptsendgroupBox.SuspendLayout();
            this.RSAgroupBox.SuspendLayout();
            this.Connect_panel.SuspendLayout();
            this.Login_panel.SuspendLayout();
            this.logingroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.ForeColor = System.Drawing.Color.Purple;
            this.input_textBox.Location = new System.Drawing.Point(12, 53);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(486, 82);
            this.input_textBox.TabIndex = 0;
            // 
            // VigenereEncrypt_textBox
            // 
            this.VigenereEncrypt_textBox.Location = new System.Drawing.Point(9, 32);
            this.VigenereEncrypt_textBox.Multiline = true;
            this.VigenereEncrypt_textBox.Name = "VigenereEncrypt_textBox";
            this.VigenereEncrypt_textBox.Size = new System.Drawing.Size(229, 34);
            this.VigenereEncrypt_textBox.TabIndex = 1;
            // 
            // input_messagelabel
            // 
            this.input_messagelabel.AutoSize = true;
            this.input_messagelabel.BackColor = System.Drawing.Color.Crimson;
            this.input_messagelabel.ForeColor = System.Drawing.Color.Yellow;
            this.input_messagelabel.Location = new System.Drawing.Point(6, 27);
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
            this.Vigenere_Button.Location = new System.Drawing.Point(26, 35);
            this.Vigenere_Button.Name = "Vigenere_Button";
            this.Vigenere_Button.Size = new System.Drawing.Size(115, 17);
            this.Vigenere_Button.TabIndex = 7;
            this.Vigenere_Button.TabStop = true;
            this.Vigenere_Button.Text = "Vigenere Cipher";
            this.Vigenere_Button.UseVisualStyleBackColor = true;
            this.Vigenere_Button.CheckedChanged += new System.EventHandler(this.Vigenere_Button_CheckedChanged);
            // 
            // Vigeneredecrypt_textBox
            // 
            this.Vigeneredecrypt_textBox.Location = new System.Drawing.Point(9, 85);
            this.Vigeneredecrypt_textBox.Multiline = true;
            this.Vigeneredecrypt_textBox.Name = "Vigeneredecrypt_textBox";
            this.Vigeneredecrypt_textBox.Size = new System.Drawing.Size(229, 40);
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
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(52, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 114);
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
            this.groupBox2.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox2.Location = new System.Drawing.Point(427, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 114);
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
            // CHAT_HISTORY
            // 
            this.CHAT_HISTORY.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.CHAT_HISTORY.ForeColor = System.Drawing.Color.Blue;
            this.CHAT_HISTORY.FormattingEnabled = true;
            this.CHAT_HISTORY.Location = new System.Drawing.Point(510, 16);
            this.CHAT_HISTORY.Name = "CHAT_HISTORY";
            this.CHAT_HISTORY.Size = new System.Drawing.Size(329, 459);
            this.CHAT_HISTORY.TabIndex = 15;
            // 
            // VigenerebuttonSend
            // 
            this.VigenerebuttonSend.Location = new System.Drawing.Point(183, 136);
            this.VigenerebuttonSend.Name = "VigenerebuttonSend";
            this.VigenerebuttonSend.Size = new System.Drawing.Size(55, 23);
            this.VigenerebuttonSend.TabIndex = 16;
            this.VigenerebuttonSend.Text = "Send";
            this.VigenerebuttonSend.UseVisualStyleBackColor = true;
            this.VigenerebuttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.DarkRed;
            this.buttonConnect.ForeColor = System.Drawing.Color.Yellow;
            this.buttonConnect.Location = new System.Drawing.Point(358, 381);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(114, 36);
            this.buttonConnect.TabIndex = 17;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Crimson;
            this.groupBox3.Controls.Add(this.input_textBox);
            this.groupBox3.Controls.Add(this.input_messagelabel);
            this.groupBox3.Location = new System.Drawing.Point(0, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 155);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " (Use only characters \"a - z\")";
            // 
            // selectalgorithmgroupBox
            // 
            this.selectalgorithmgroupBox.BackColor = System.Drawing.Color.Crimson;
            this.selectalgorithmgroupBox.Controls.Add(this.RSAButton);
            this.selectalgorithmgroupBox.Controls.Add(this.Vigenere_Button);
            this.selectalgorithmgroupBox.ForeColor = System.Drawing.Color.GreenYellow;
            this.selectalgorithmgroupBox.Location = new System.Drawing.Point(0, 177);
            this.selectalgorithmgroupBox.Name = "selectalgorithmgroupBox";
            this.selectalgorithmgroupBox.Size = new System.Drawing.Size(504, 91);
            this.selectalgorithmgroupBox.TabIndex = 19;
            this.selectalgorithmgroupBox.TabStop = false;
            this.selectalgorithmgroupBox.Text = "Choose Cryptography Algorithm for Chat";
            this.selectalgorithmgroupBox.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // RSAButton
            // 
            this.RSAButton.AutoSize = true;
            this.RSAButton.Location = new System.Drawing.Point(234, 35);
            this.RSAButton.Name = "RSAButton";
            this.RSAButton.Size = new System.Drawing.Size(264, 17);
            this.RSAButton.TabIndex = 17;
            this.RSAButton.TabStop = true;
            this.RSAButton.Text = "RSA Cipher(Keys automatically generated)";
            this.RSAButton.UseVisualStyleBackColor = true;
            this.RSAButton.CheckedChanged += new System.EventHandler(this.RSAButton_CheckedChanged);
            // 
            // encryptdecryptsendgroupBox
            // 
            this.encryptdecryptsendgroupBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.encryptdecryptsendgroupBox.Controls.Add(this.Vigeneredecrypt_textBox);
            this.encryptdecryptsendgroupBox.Controls.Add(this.VigenereEncrypt_textBox);
            this.encryptdecryptsendgroupBox.Controls.Add(this.VigenerebuttonSend);
            this.encryptdecryptsendgroupBox.Controls.Add(this.decrypt_label);
            this.encryptdecryptsendgroupBox.Controls.Add(this.encrypt_label);
            this.encryptdecryptsendgroupBox.Location = new System.Drawing.Point(0, 274);
            this.encryptdecryptsendgroupBox.Name = "encryptdecryptsendgroupBox";
            this.encryptdecryptsendgroupBox.Size = new System.Drawing.Size(244, 195);
            this.encryptdecryptsendgroupBox.TabIndex = 22;
            this.encryptdecryptsendgroupBox.TabStop = false;
            this.encryptdecryptsendgroupBox.Text = "Vigenere (Encrypt --- Decrypt ---- Send)";
            this.encryptdecryptsendgroupBox.Visible = false;
            // 
            // RSAgroupBox
            // 
            this.RSAgroupBox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RSAgroupBox.Controls.Add(this.RSADecryptbutton);
            this.RSAgroupBox.Controls.Add(this.RSAEncryptbutton);
            this.RSAgroupBox.Controls.Add(this.RSASendbutton);
            this.RSAgroupBox.Controls.Add(this.DecryptRSAtextBox);
            this.RSAgroupBox.Controls.Add(this.EncryptRSAtextBox);
            this.RSAgroupBox.Location = new System.Drawing.Point(244, 274);
            this.RSAgroupBox.Name = "RSAgroupBox";
            this.RSAgroupBox.Size = new System.Drawing.Size(260, 195);
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
            this.RSASendbutton.Location = new System.Drawing.Point(200, 136);
            this.RSASendbutton.Name = "RSASendbutton";
            this.RSASendbutton.Size = new System.Drawing.Size(48, 23);
            this.RSASendbutton.TabIndex = 16;
            this.RSASendbutton.Text = "Send_Message";
            this.RSASendbutton.UseVisualStyleBackColor = true;
            this.RSASendbutton.Visible = false;
            this.RSASendbutton.Click += new System.EventHandler(this.RSASendbutton_Click);
            // 
            // DecryptRSAtextBox
            // 
            this.DecryptRSAtextBox.Location = new System.Drawing.Point(70, 83);
            this.DecryptRSAtextBox.Multiline = true;
            this.DecryptRSAtextBox.Name = "DecryptRSAtextBox";
            this.DecryptRSAtextBox.Size = new System.Drawing.Size(184, 47);
            this.DecryptRSAtextBox.TabIndex = 11;
            this.DecryptRSAtextBox.Visible = false;
            this.DecryptRSAtextBox.TextChanged += new System.EventHandler(this.DecryptRSAtextBox_TextChanged);
            // 
            // EncryptRSAtextBox
            // 
            this.EncryptRSAtextBox.Location = new System.Drawing.Point(70, 21);
            this.EncryptRSAtextBox.Multiline = true;
            this.EncryptRSAtextBox.Name = "EncryptRSAtextBox";
            this.EncryptRSAtextBox.Size = new System.Drawing.Size(184, 56);
            this.EncryptRSAtextBox.TabIndex = 1;
            this.EncryptRSAtextBox.Visible = false;
            this.EncryptRSAtextBox.TextChanged += new System.EventHandler(this.EncryptRSAtextBox_TextChanged);
            // 
            // Create_label
            // 
            this.Create_label.AutoSize = true;
            this.Create_label.ForeColor = System.Drawing.Color.Orchid;
            this.Create_label.Location = new System.Drawing.Point(261, 186);
            this.Create_label.Name = "Create_label";
            this.Create_label.Size = new System.Drawing.Size(305, 13);
            this.Create_label.TabIndex = 24;
            this.Create_label.Text = "Create Connection  for conersation over the network";
            this.Create_label.Click += new System.EventHandler(this.Create_label_Click);
            // 
            // Connect_panel
            // 
            this.Connect_panel.AutoSize = true;
            this.Connect_panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.Connect_panel.Controls.Add(this.Login_panel);
            this.Connect_panel.Controls.Add(this.Create_label);
            this.Connect_panel.Controls.Add(this.buttonConnect);
            this.Connect_panel.Controls.Add(this.groupBox1);
            this.Connect_panel.Controls.Add(this.groupBox2);
            this.Connect_panel.Controls.Add(this.pictureBox2);
            this.Connect_panel.ForeColor = System.Drawing.Color.Salmon;
            this.Connect_panel.Location = new System.Drawing.Point(0, 0);
            this.Connect_panel.Name = "Connect_panel";
            this.Connect_panel.Size = new System.Drawing.Size(1070, 921);
            this.Connect_panel.TabIndex = 3;
            this.Connect_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Connect_panel_Paint);
            // 
            // Login_panel
            // 
            this.Login_panel.AutoSize = true;
            this.Login_panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.Login_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login_panel.Controls.Add(this.pictureBox1);
            this.Login_panel.Controls.Add(this.logingroupBox);
            this.Login_panel.Location = new System.Drawing.Point(0, 0);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(839, 485);
            this.Login_panel.TabIndex = 25;
            this.Login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_panel_Paint);
            // 
            // logingroupBox
            // 
            this.logingroupBox.BackColor = System.Drawing.Color.Black;
            this.logingroupBox.Controls.Add(this.password_label);
            this.logingroupBox.Controls.Add(this.user_textBox);
            this.logingroupBox.Controls.Add(this.label);
            this.logingroupBox.Controls.Add(this.pass_textBox);
            this.logingroupBox.Controls.Add(this.Loginbutton);
            this.logingroupBox.ForeColor = System.Drawing.Color.IndianRed;
            this.logingroupBox.Location = new System.Drawing.Point(151, 166);
            this.logingroupBox.Name = "logingroupBox";
            this.logingroupBox.Size = new System.Drawing.Size(508, 224);
            this.logingroupBox.TabIndex = 0;
            this.logingroupBox.TabStop = false;
            this.logingroupBox.Text = "Enter user-name and password to login into chat-server";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(26, 119);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(135, 13);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "PIN NO / PASSWORD";
            // 
            // pass_textBox
            // 
            this.pass_textBox.Location = new System.Drawing.Point(191, 112);
            this.pass_textBox.Multiline = true;
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(297, 37);
            this.pass_textBox.TabIndex = 3;
            // 
            // user_textBox
            // 
            this.user_textBox.BackColor = System.Drawing.Color.White;
            this.user_textBox.Location = new System.Drawing.Point(189, 53);
            this.user_textBox.Multiline = true;
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(299, 40);
            this.user_textBox.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(26, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 13);
            this.label.TabIndex = 1;
            this.label.Text = "USER NAME";
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.Maroon;
            this.Loginbutton.ForeColor = System.Drawing.Color.Yellow;
            this.Loginbutton.Location = new System.Drawing.Point(381, 159);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(107, 38);
            this.Loginbutton.TabIndex = 0;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Cryptography_Algorithm_Project.Properties.Resources.lo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(246, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 116);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Cryptography_Algorithm_Project.Properties.Resources.download1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(264, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 156);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(838, 479);
            this.Controls.Add(this.Connect_panel);
            this.Controls.Add(this.RSAgroupBox);
            this.Controls.Add(this.encryptdecryptsendgroupBox);
            this.Controls.Add(this.selectalgorithmgroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CHAT_HISTORY);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SMART-CHAT";
            this.TransparencyKey = System.Drawing.Color.DarkGreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.selectalgorithmgroupBox.ResumeLayout(false);
            this.selectalgorithmgroupBox.PerformLayout();
            this.encryptdecryptsendgroupBox.ResumeLayout(false);
            this.encryptdecryptsendgroupBox.PerformLayout();
            this.RSAgroupBox.ResumeLayout(false);
            this.RSAgroupBox.PerformLayout();
            this.Connect_panel.ResumeLayout(false);
            this.Connect_panel.PerformLayout();
            this.Login_panel.ResumeLayout(false);
            this.logingroupBox.ResumeLayout(false);
            this.logingroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox VigenereEncrypt_textBox;
        private System.Windows.Forms.Label input_messagelabel;
        private System.Windows.Forms.Label encrypt_label;
        private System.Windows.Forms.RadioButton Vigenere_Button;
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
        private System.Windows.Forms.ListBox CHAT_HISTORY;
        private System.Windows.Forms.Button VigenerebuttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox selectalgorithmgroupBox;
        private System.Windows.Forms.RadioButton RSAButton;
        private System.Windows.Forms.GroupBox encryptdecryptsendgroupBox;
        private System.Windows.Forms.GroupBox RSAgroupBox;
        private System.Windows.Forms.Button RSADecryptbutton;
        private System.Windows.Forms.Button RSAEncryptbutton;
        private System.Windows.Forms.Button RSASendbutton;
        private System.Windows.Forms.TextBox DecryptRSAtextBox;
        private System.Windows.Forms.TextBox EncryptRSAtextBox;
        private System.Windows.Forms.Label Create_label;
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.GroupBox logingroupBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Panel Connect_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

