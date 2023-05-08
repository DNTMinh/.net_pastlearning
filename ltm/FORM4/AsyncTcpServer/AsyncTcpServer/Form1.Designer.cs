namespace AsyncTcpServer
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
            this.porttext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iptext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartServer = new System.Windows.Forms.Button();
            this.StopServer = new System.Windows.Forms.Button();
            this.Txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // porttext
            // 
            this.porttext.Location = new System.Drawing.Point(420, 36);
            this.porttext.Name = "porttext";
            this.porttext.Size = new System.Drawing.Size(65, 27);
            this.porttext.TabIndex = 7;
            this.porttext.Text = "2008";
            this.porttext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server Port:";
            // 
            // iptext
            // 
            this.iptext.Location = new System.Drawing.Point(139, 36);
            this.iptext.Name = "iptext";
            this.iptext.Size = new System.Drawing.Size(125, 27);
            this.iptext.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Ip:";
            // 
            // StartServer
            // 
            this.StartServer.Location = new System.Drawing.Point(157, 89);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(94, 29);
            this.StartServer.TabIndex = 8;
            this.StartServer.Text = "Start";
            this.StartServer.UseVisualStyleBackColor = true;
            // 
            // StopServer
            // 
            this.StopServer.Location = new System.Drawing.Point(311, 89);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(94, 29);
            this.StopServer.TabIndex = 9;
            this.StopServer.Text = "Stop";
            this.StopServer.UseVisualStyleBackColor = true;
            // 
            // Txtbox
            // 
            this.Txtbox.Location = new System.Drawing.Point(63, 143);
            this.Txtbox.Multiline = true;
            this.Txtbox.Name = "Txtbox";
            this.Txtbox.ReadOnly = true;
            this.Txtbox.Size = new System.Drawing.Size(422, 182);
            this.Txtbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 351);
            this.Controls.Add(this.Txtbox);
            this.Controls.Add(this.StopServer);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.porttext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptext);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Asynchronous TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox porttext;
        private Label label2;
        private TextBox iptext;
        private Label label1;
        private Button StartServer;
        private Button StopServer;
        private TextBox Txtbox;
    }
}