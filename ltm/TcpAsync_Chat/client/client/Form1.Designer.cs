using System.Windows.Forms;
namespace client
{
    partial class Form1 : Form
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
            this.PORT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KQ = new System.Windows.Forms.TextBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbReceiver = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(305, 25);
            this.Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(90, 22);
            this.Connect.TabIndex = 10;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PORT
            // 
            this.PORT.Location = new System.Drawing.Point(138, 25);
            this.PORT.Margin = new System.Windows.Forms.Padding(2);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(132, 22);
            this.PORT.TabIndex = 2;
            this.PORT.Text = "2008";
            this.PORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server Port";
            // 
            // KQ
            // 
            this.KQ.BackColor = System.Drawing.Color.White;
            this.KQ.Location = new System.Drawing.Point(60, 357);
            this.KQ.Margin = new System.Windows.Forms.Padding(2);
            this.KQ.Multiline = true;
            this.KQ.Name = "KQ";
            this.KQ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KQ.Size = new System.Drawing.Size(638, 109);
            this.KQ.TabIndex = 100;
            this.KQ.TabStop = false;
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(138, 60);
            this.IP.Margin = new System.Windows.Forms.Padding(2);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(275, 22);
            this.IP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Server";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(140, 305);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(275, 22);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.Text = "Hello";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(455, 279);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 36);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(57, 156);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 9;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(57, 201);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 153);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(275, 22);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "A";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 198);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 22);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123";
            // 
            // lbReceiver
            // 
            this.lbReceiver.AutoSize = true;
            this.lbReceiver.Location = new System.Drawing.Point(57, 263);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(62, 16);
            this.lbReceiver.TabIndex = 10;
            this.lbReceiver.Text = "Receiver";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(140, 260);
            this.txtReceiver.Margin = new System.Windows.Forms.Padding(2);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(275, 22);
            this.txtReceiver.TabIndex = 11;
            this.txtReceiver.Text = "B";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(57, 308);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(64, 16);
            this.lbMessage.TabIndex = 10;
            this.lbMessage.Text = "Message";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(455, 146);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 26);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(454, 176);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 26);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Group name";
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(623, 88);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 30;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(538, 22);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(160, 22);
            this.txtGroupName.TabIndex = 21;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(538, 60);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(160, 22);
            this.txtMemberName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "Member";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(455, 207);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 26);
            this.btnLogout.TabIndex = 106;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 500);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbReceiver);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KQ);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Connect;
        private TextBox PORT;
        private Label label2;
        private TextBox KQ;
        private TextBox IP;
        private Label label1;
        private TextBox txtMessage;
        private Button btnSend;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbReceiver;
        private TextBox txtReceiver;
        private Label lbMessage;
        private Button btnRegister;
        private Button btnLogin;
        private Label label3;
        private Button btnAddGroup;
        private TextBox txtGroupName;
        private TextBox txtMemberName;
        private Label label4;
        private Button btnLogout;
    }
}