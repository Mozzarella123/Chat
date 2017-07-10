namespace Chat
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_port_text = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClientBut = new System.Windows.Forms.Button();
            this.ServerBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendText = new System.Windows.Forms.TextBox();
            this.SendBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ip_port_text
            // 
            this.ip_port_text.Location = new System.Drawing.Point(112, 26);
            this.ip_port_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ip_port_text.Mask = "999\\.999\\.999\\.999:9999";
            this.ip_port_text.Name = "ip_port_text";
            this.ip_port_text.Size = new System.Drawing.Size(198, 26);
            this.ip_port_text.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 140);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 338);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 3;
            // 
            // ClientBut
            // 
            this.ClientBut.Location = new System.Drawing.Point(429, 23);
            this.ClientBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientBut.Name = "ClientBut";
            this.ClientBut.Size = new System.Drawing.Size(112, 35);
            this.ClientBut.TabIndex = 4;
            this.ClientBut.Text = "Client";
            this.ClientBut.UseVisualStyleBackColor = true;
            this.ClientBut.Click += new System.EventHandler(this.ClientBut_Click);
            // 
            // ServerBut
            // 
            this.ServerBut.Location = new System.Drawing.Point(429, 68);
            this.ServerBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerBut.Name = "ServerBut";
            this.ServerBut.Size = new System.Drawing.Size(112, 35);
            this.ServerBut.TabIndex = 5;
            this.ServerBut.Text = "Server";
            this.ServerBut.UseVisualStyleBackColor = true;
            this.ServerBut.Click += new System.EventHandler(this.ServerBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP:PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chat";
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(22, 521);
            this.SendText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(396, 26);
            this.SendText.TabIndex = 9;
            // 
            // SendBut
            // 
            this.SendBut.Location = new System.Drawing.Point(429, 512);
            this.SendBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendBut.Name = "SendBut";
            this.SendBut.Size = new System.Drawing.Size(112, 35);
            this.SendBut.TabIndex = 10;
            this.SendBut.Text = "Send";
            this.SendBut.UseVisualStyleBackColor = true;
            this.SendBut.Click += new System.EventHandler(this.SendBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 140);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(438, 182);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 26);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Your Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SendBut);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServerBut);
            this.Controls.Add(this.ClientBut);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ip_port_text);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox ip_port_text;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ClientBut;
        private System.Windows.Forms.Button ServerBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Button SendBut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

