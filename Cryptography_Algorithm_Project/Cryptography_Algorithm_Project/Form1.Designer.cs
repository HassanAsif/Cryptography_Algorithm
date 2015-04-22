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
            this.send_message = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_textBox
            // 
            this.input_textBox.Location = new System.Drawing.Point(25, 54);
            this.input_textBox.Multiline = true;
            this.input_textBox.Name = "input_textBox";
            this.input_textBox.Size = new System.Drawing.Size(238, 69);
            this.input_textBox.TabIndex = 0;
            // 
            // Encrypt_textBox
            // 
            this.Encrypt_textBox.Location = new System.Drawing.Point(25, 189);
            this.Encrypt_textBox.Multiline = true;
            this.Encrypt_textBox.Name = "Encrypt_textBox";
            this.Encrypt_textBox.Size = new System.Drawing.Size(238, 60);
            this.Encrypt_textBox.TabIndex = 1;
            this.Encrypt_textBox.Visible = false;
            // 
            // input_message
            // 
            this.input_message.AutoSize = true;
            this.input_message.Location = new System.Drawing.Point(12, 24);
            this.input_message.Name = "input_message";
            this.input_message.Size = new System.Drawing.Size(124, 13);
            this.input_message.TabIndex = 2;
            this.input_message.Text = "Enter your message here";
            // 
            // text_encrypt
            // 
            this.text_encrypt.AutoSize = true;
            this.text_encrypt.Location = new System.Drawing.Point(12, 161);
            this.text_encrypt.Name = "text_encrypt";
            this.text_encrypt.Size = new System.Drawing.Size(57, 13);
            this.text_encrypt.TabIndex = 3;
            this.text_encrypt.Text = "Encryption";
            this.text_encrypt.Visible = false;
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(188, 129);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(75, 23);
            this.send_message.TabIndex = 4;
            this.send_message.Text = "Encrypt";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.send_message);
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
        private System.Windows.Forms.Button send_message;
    }
}

