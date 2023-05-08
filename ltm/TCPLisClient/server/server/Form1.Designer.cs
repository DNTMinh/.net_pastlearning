namespace server
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
            this.IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.KQ = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(150, 26);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(191, 31);
            this.IP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP";
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(413, 26);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(65, 31);
            this.PORT.TabIndex = 0;
            this.PORT.Text = "2008";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(44, 94);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 34);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // KQ
            // 
            this.KQ.Location = new System.Drawing.Point(34, 167);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(444, 230);
            this.KQ.TabIndex = 0;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(229, 94);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(112, 34);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IP;
        private Label label1;
        private TextBox PORT;
        private Label label2;
        private Button Start;
        private TextBox KQ;
        private Button Stop;
    }
}