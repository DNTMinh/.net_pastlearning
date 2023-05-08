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
            this.Logout = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.CreateGroup = new System.Windows.Forms.Button();
            this.Members = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GRP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(275, 42);
            this.Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(79, 20);
            this.Connect.TabIndex = 7;
            this.Connect.Text = "Login";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server IP";
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(289, 14);
            this.PORT.Margin = new System.Windows.Forms.Padding(2);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(65, 23);
            this.PORT.TabIndex = 3;
            this.PORT.Text = "2008";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(90, 14);
            this.IP.Margin = new System.Windows.Forms.Padding(2);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(149, 23);
            this.IP.TabIndex = 4;
            this.IP.Text = "192.168.27.231";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(23, 92);
            this.message.Margin = new System.Windows.Forms.Padding(2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(331, 23);
            this.message.TabIndex = 4;
            this.message.Text = "fgdgfd";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(275, 117);
            this.Send.Margin = new System.Windows.Forms.Padding(2);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(79, 20);
            this.Send.TabIndex = 8;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // KQ
            // 
            this.KQ.Location = new System.Drawing.Point(23, 139);
            this.KQ.Margin = new System.Windows.Forms.Padding(2);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.Size = new System.Drawing.Size(331, 140);
            this.KQ.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(133, 40);
            this.UserName.Margin = new System.Windows.Forms.Padding(2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(106, 23);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "C";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(133, 70);
            this.Pass.Margin = new System.Windows.Forms.Padding(2);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(106, 23);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pass";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(134, 114);
            this.receiver.Margin = new System.Windows.Forms.Padding(2);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(106, 23);
            this.receiver.TabIndex = 3;
            this.receiver.Text = "B";
            // 
            // Logout
            // 
            this.Logout.Enabled = false;
            this.Logout.Location = new System.Drawing.Point(276, 69);
            this.Logout.Margin = new System.Windows.Forms.Padding(2);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(79, 20);
            this.Logout.TabIndex = 10;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(374, 42);
            this.Register.Margin = new System.Windows.Forms.Padding(2);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(79, 20);
            this.Register.TabIndex = 11;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // CreateGroup
            // 
            this.CreateGroup.Location = new System.Drawing.Point(374, 114);
            this.CreateGroup.Margin = new System.Windows.Forms.Padding(2);
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.Size = new System.Drawing.Size(110, 20);
            this.CreateGroup.TabIndex = 12;
            this.CreateGroup.Text = "Create Group";
            this.CreateGroup.UseVisualStyleBackColor = true;
            this.CreateGroup.Click += new System.EventHandler(this.CreateGroup_Click);
            // 
            // Members
            // 
            this.Members.Location = new System.Drawing.Point(424, 168);
            this.Members.Margin = new System.Windows.Forms.Padding(2);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(76, 23);
            this.Members.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Group";
            // 
            // GRP
            // 
            this.GRP.Location = new System.Drawing.Point(427, 140);
            this.GRP.Margin = new System.Windows.Forms.Padding(2);
            this.GRP.Name = "GRP";
            this.GRP.Size = new System.Drawing.Size(72, 23);
            this.GRP.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Members";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(420, 200);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 20);
            this.Add.TabIndex = 13;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 292);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.CreateGroup);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GRP);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.message);
            this.Controls.Add(this.IP);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private Button Logout;
        private Button Register;
        private Button CreateGroup;
        private TextBox Members;
        private Label label5;
        private TextBox GRP;
        private Label label6;
        private Button Add;
    }
}