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
            this.text_encrypt = new System.Windows.Forms.Label();
            this.Choosealgorithm_label = new System.Windows.Forms.Label();
            this.Play_Fair_Button = new System.Windows.Forms.RadioButton();
            this.Vigenere_Button = new System.Windows.Forms.RadioButton();
            this.Exit_button = new System.Windows.Forms.Button();
            this.key_label = new System.Windows.Forms.Label();
            this.Key_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(24, 25);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(483, 68);
            this.input_textBox.TabIndex = 0;
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(24, 251);
            this.Encrypt_textBox.Multiline = true;
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(484, 54);
            this.Encrypt_textBox.TabIndex = 1;
            this.Encrypt_textBox.Visible = false;
            // 
            // input_message
            // 
            this.input_message.AutoSize = true;
            this.input_message.Location = new System.Drawing.Point(12, 9);
            this.input_message.Name = "input_message";
            this.input_message.Size = new System.Drawing.Size(127, 13);
            this.input_message.TabIndex = 2;
            this.input_message.Text = "Enter your message here:";
            // 
            // text_encrypt
            // 
            this.text_encrypt.AutoSize = true;
            this.text_encrypt.Location = new System.Drawing.Point(12, 225);
            this.text_encrypt.Name = "text_encrypt";
            this.text_encrypt.Size = new System.Drawing.Size(57, 13);
            this.text_encrypt.TabIndex = 3;
            this.text_encrypt.Text = "Encryption";
            this.text_encrypt.Visible = false;
            // 
            // Choosealgorithm_label
            // 
            this.Choosealgorithm_label.AutoSize = true;
            this.Choosealgorithm_label.Location = new System.Drawing.Point(12, 162);
            this.Choosealgorithm_label.Name = "Choosealgorithm_label";
            this.Choosealgorithm_label.Size = new System.Drawing.Size(257, 13);
            this.Choosealgorithm_label.TabIndex = 5;
            this.Choosealgorithm_label.Text = "Choose an algorithm you want to used for encryption.";
            // 
            // Play_Fair_Button
            // 
            this.Play_Fair_Button.AutoSize = true;
            this.Play_Fair_Button.Location = new System.Drawing.Point(179, 201);
            this.Play_Fair_Button.Name = "Play_Fair_Button";
            this.Play_Fair_Button.Size = new System.Drawing.Size(98, 17);
            this.Play_Fair_Button.TabIndex = 6;
            this.Play_Fair_Button.TabStop = true;
            this.Play_Fair_Button.Text = "Play Fair Cipher";
            this.Play_Fair_Button.UseVisualStyleBackColor = true;
            this.Play_Fair_Button.CheckedChanged += new System.EventHandler(this.Play_Fair_Button_CheckedChanged);
            // 
            // Vigenere_Button
            // 
            this.Vigenere_Button.AutoSize = true;
            this.Vigenere_Button.Location = new System.Drawing.Point(179, 178);
            this.Vigenere_Button.Name = "Vigenere_Button";
            this.Vigenere_Button.Size = new System.Drawing.Size(100, 17);
            this.Vigenere_Button.TabIndex = 7;
            this.Vigenere_Button.TabStop = true;
            this.Vigenere_Button.Text = "Vigenere Cipher";
            this.Vigenere_Button.UseVisualStyleBackColor = true;
            this.Vigenere_Button.CheckedChanged += new System.EventHandler(this.Vigenere_Button_CheckedChanged);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(433, 322);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 8;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // key_label
            // 
            this.key_label.AutoSize = true;
            this.key_label.Location = new System.Drawing.Point(12, 96);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(80, 13);
            this.key_label.TabIndex = 9;
            this.key_label.Text = "Enter Key here:";
            // 
            // Key_textBox
            // 
            this.Key_textBox.Location = new System.Drawing.Point(24, 112);
            this.Key_textBox.Multiline = true;
            this.Key_textBox.Name = "Key_textBox";
            this.Key_textBox.Size = new System.Drawing.Size(483, 35);
            this.Key_textBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 357);
            this.Controls.Add(this.Key_textBox);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Vigenere_Button);
            this.Controls.Add(this.Play_Fair_Button);
            this.Controls.Add(this.Choosealgorithm_label);
            this.Controls.Add(this.text_encrypt);
            this.Controls.Add(this.input_message);
            this.Controls.Add(this.Encrypt_textBox);
            this.Controls.Add(this.input_textBox);
            this.Name = "Form1";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_textBox;
        private System.Windows.Forms.TextBox Encrypt_textBox;
        private System.Windows.Forms.Label input_message;
        private System.Windows.Forms.Label text_encrypt;
        private System.Windows.Forms.Label Choosealgorithm_label;
        private System.Windows.Forms.RadioButton Play_Fair_Button;
        private System.Windows.Forms.RadioButton Vigenere_Button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label key_label;
        private System.Windows.Forms.TextBox Key_textBox;
    }
}

