namespace SimpleChatApp
{
    partial class Server
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.startBtn = new System.Windows.Forms.Button();
            this.portTxtBox = new System.Windows.Forms.TextBox();
            this.ipTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.logTxtBox = new System.Windows.Forms.TextBox();
            this.disconClientBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AllowUserToAddRows = false;
            this.clientDataGridView.AllowUserToDeleteRows = false;
            this.clientDataGridView.AllowUserToResizeColumns = false;
            this.clientDataGridView.AllowUserToResizeRows = false;
            this.clientDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clientDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clientDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.clientDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientDataGridView.ColumnHeadersHeight = 24;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clientDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientDataGridView.EnableHeadersVisualStyles = false;
            this.clientDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clientDataGridView.Location = new System.Drawing.Point(587, 13);
            this.clientDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.clientDataGridView.MultiSelect = false;
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.ReadOnly = true;
            this.clientDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clientDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientDataGridView.RowHeadersVisible = false;
            this.clientDataGridView.RowHeadersWidth = 40;
            this.clientDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.clientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.clientDataGridView.RowTemplate.Height = 29;
            this.clientDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGridView.ShowCellErrors = false;
            this.clientDataGridView.ShowCellToolTips = false;
            this.clientDataGridView.ShowEditingIcon = false;
            this.clientDataGridView.ShowRowErrors = false;
            this.clientDataGridView.Size = new System.Drawing.Size(304, 495);
            this.clientDataGridView.TabIndex = 30;
            this.clientDataGridView.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(13, 13);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(116, 28);
            this.startBtn.TabIndex = 23;
            this.startBtn.TabStop = false;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // portTxtBox
            // 
            this.portTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.portTxtBox.Location = new System.Drawing.Point(447, 13);
            this.portTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTxtBox.MaxLength = 10;
            this.portTxtBox.Name = "portTxtBox";
            this.portTxtBox.Size = new System.Drawing.Size(132, 22);
            this.portTxtBox.TabIndex = 20;
            this.portTxtBox.TabStop = false;
            this.portTxtBox.Text = "2008";
            this.portTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ipTxtBox
            // 
            this.ipTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipTxtBox.Location = new System.Drawing.Point(255, 13);
            this.ipTxtBox.MaxLength = 200;
            this.ipTxtBox.Name = "ipTxtBox";
            this.ipTxtBox.Size = new System.Drawing.Size(132, 22);
            this.ipTxtBox.TabIndex = 37;
            this.ipTxtBox.TabStop = false;
            this.ipTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(410, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(173, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "IP Address:";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Total.Location = new System.Drawing.Point(489, 102);
            this.Total.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(90, 13);
            this.Total.TabIndex = 31;
            this.Total.Text = "Total Client: 0";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logTxtBox
            // 
            this.logTxtBox.Enabled = false;
            this.logTxtBox.Location = new System.Drawing.Point(13, 159);
            this.logTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.logTxtBox.Multiline = true;
            this.logTxtBox.Name = "logTxtBox";
            this.logTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTxtBox.Size = new System.Drawing.Size(566, 300);
            this.logTxtBox.TabIndex = 24;
            this.logTxtBox.TabStop = false;
            // 
            // disconClientBtn
            // 
            this.disconClientBtn.Location = new System.Drawing.Point(463, 123);
            this.disconClientBtn.Margin = new System.Windows.Forms.Padding(4);
            this.disconClientBtn.Name = "disconClientBtn";
            this.disconClientBtn.Size = new System.Drawing.Size(116, 28);
            this.disconClientBtn.TabIndex = 26;
            this.disconClientBtn.TabStop = false;
            this.disconClientBtn.Text = "Disconnect All";
            this.disconClientBtn.UseVisualStyleBackColor = true;
            this.disconClientBtn.Click += new System.EventHandler(this.disconClientBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(13, 123);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(116, 28);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.TabStop = false;
            this.clearBtn.Text = "Clear Log";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 521);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.disconClientBtn);
            this.Controls.Add(this.logTxtBox);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTxtBox);
            this.Controls.Add(this.portTxtBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.clientDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView clientDataGridView;
        private Button startBtn;
        private TextBox portTxtBox;
        private TextBox ipTxtBox;
        private Label label1;
        private Label label2;
        private Label Total;
        private TextBox logTxtBox;
        private Button disconClientBtn;
        private Button clearBtn;
    }
}