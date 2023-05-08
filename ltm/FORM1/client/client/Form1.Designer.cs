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
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(129, 85);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(472, 31);
            this.message.TabIndex = 4;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(668, 82);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(112, 34);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // KQ
            // 
            this.KQ.Location = new System.Drawing.Point(33, 163);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(779, 230);
            this.KQ.TabIndex = 9;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.message);
            this.Controls.Add(this.IP);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}