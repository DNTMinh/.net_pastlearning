namespace client
{
    partial class Form1
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
            this.Connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PORT = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.KQ = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(970, 24);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(112, 34);
            this.Connect.TabIndex = 7;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP";
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(774, 24);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(150, 31);
            this.PORT.TabIndex = 3;
            this.PORT.Text = "2008";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(129, 24);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(472, 31);
            this.IP.TabIndex = 4;
            this.IP.Text = "192.168.185.253";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(33, 138);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(472, 31);
            this.message.TabIndex = 4;
            this.message.Text = "fgdgfd";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(668, 135);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(112, 34);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // KQ
            // 
            this.KQ.Location = new System.Drawing.Point(33, 216);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(779, 230);
            this.KQ.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(932, 88);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(150, 31);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "A";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(932, 137);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(150, 31);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(832, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(832, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pass";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(512, 138);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(150, 31);
            this.receiver.TabIndex = 3;
            this.receiver.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.message);
            this.Controls.Add(this.IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Connect;
        private Label label2;
        private Label label1;
        private TextBox PORT;
        private TextBox IP;
        private TextBox message;
        private Button Send;
        private TextBox KQ;
        private TextBox UserName;
        private TextBox Pass;
        private Label label3;
        private Label label4;
        private TextBox receiver;
    }
}