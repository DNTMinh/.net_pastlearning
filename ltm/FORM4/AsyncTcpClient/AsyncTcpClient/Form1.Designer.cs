namespace AsyncTcpClient
{
    partial class client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.iptext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.porttext = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.discon = new System.Windows.Forms.Button();
            this.Txtbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Ip:";
            // 
            // iptext
            // 
            this.iptext.Location = new System.Drawing.Point(112, 23);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(125, 27);
            this.iptext.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Server Port:";
            // 
            // porttext
            // 
            this.porttext.Location = new System.Drawing.Point(368, 23);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(65, 27);
            this.porttext.TabIndex = 3;
            this.porttext.Text = "2008";
            this.porttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(664, 21);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(94, 29);
            this.connect.TabIndex = 4;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // discon
            // 
            this.discon.Location = new System.Drawing.Point(664, 80);
            this.discon.Name = "discon";
            this.discon.Size = new System.Drawing.Size(94, 29);
            this.discon.TabIndex = 5;
            this.discon.Text = "Disconnect";
            this.discon.UseVisualStyleBackColor = true;
            // 
            // Txtbox
            // 
            this.Txtbox.Location = new System.Drawing.Point(112, 70);
            this.Txtbox.Multiline = true;
            this.Txtbox.Name = "Txtbox";
            this.Txtbox.ReadOnly = true;
            this.Txtbox.Size = new System.Drawing.Size(510, 189);
            this.Txtbox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 27);
            this.textBox2.TabIndex = 7;
            // 
            // sendit
            // 
            this.sendit.Location = new System.Drawing.Point(528, 281);
            this.sendit.Name = "sendit";
            this.sendit.Size = new System.Drawing.Size(94, 29);
            this.sendit.TabIndex = 8;
            this.sendit.Text = "Send";
            this.sendit.UseVisualStyleBackColor = true;
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 333);
            this.Controls.Add(this.sendit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Txtbox);
            this.Controls.Add(this.discon);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.porttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.label1);
            this.Name = "client";
            this.Text = "Asynchronous TCP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox iptext;
        private Label label2;
        private TextBox porttext;
        private Button connect;
        private Button discon;
        private TextBox Txtbox;
        private TextBox textBox2;
        private Button sendit;
    }
}