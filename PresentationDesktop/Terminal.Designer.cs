namespace PresentationDesktop
{
    partial class Terminal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terminal));
            this.Panel2Dolasci = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnPersonalTraining = new System.Windows.Forms.Button();
            this.btnMemberInfo = new System.Windows.Forms.Button();
            this.Panel1Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Panel2Dolasci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel2Dolasci
            // 
            this.Panel2Dolasci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.Panel2Dolasci.Controls.Add(this.dataGridView1);
            this.Panel2Dolasci.Location = new System.Drawing.Point(0, 238);
            this.Panel2Dolasci.Name = "Panel2Dolasci";
            this.Panel2Dolasci.Size = new System.Drawing.Size(802, 562);
            this.Panel2Dolasci.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNewMember
            // 
            this.btnNewMember.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNewMember.Location = new System.Drawing.Point(22, 12);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(222, 53);
            this.btnNewMember.TabIndex = 0;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnMembership
            // 
            this.btnMembership.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnMembership.Location = new System.Drawing.Point(22, 71);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(222, 53);
            this.btnMembership.TabIndex = 1;
            this.btnMembership.Text = "Membership";
            this.btnMembership.UseVisualStyleBackColor = true;
            this.btnMembership.Click += new System.EventHandler(this.btnMembership_Click);
            // 
            // btnPersonalTraining
            // 
            this.btnPersonalTraining.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnPersonalTraining.Location = new System.Drawing.Point(250, 12);
            this.btnPersonalTraining.Name = "btnPersonalTraining";
            this.btnPersonalTraining.Size = new System.Drawing.Size(250, 53);
            this.btnPersonalTraining.TabIndex = 2;
            this.btnPersonalTraining.Text = "Personal training";
            this.btnPersonalTraining.UseVisualStyleBackColor = true;
            this.btnPersonalTraining.Click += new System.EventHandler(this.btnPersonalTraining_Click);
            // 
            // btnMemberInfo
            // 
            this.btnMemberInfo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnMemberInfo.Location = new System.Drawing.Point(250, 71);
            this.btnMemberInfo.Name = "btnMemberInfo";
            this.btnMemberInfo.Size = new System.Drawing.Size(250, 53);
            this.btnMemberInfo.TabIndex = 3;
            this.btnMemberInfo.Text = "Member Info";
            this.btnMemberInfo.UseVisualStyleBackColor = true;
            this.btnMemberInfo.Click += new System.EventHandler(this.btnMemberInfo_Click);
            // 
            // Panel1Header
            // 
            this.Panel1Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(102)))), ((int)(((byte)(156)))));
            this.Panel1Header.Controls.Add(this.pictureBox1);
            this.Panel1Header.Controls.Add(this.btnMemberInfo);
            this.Panel1Header.Controls.Add(this.btnPersonalTraining);
            this.Panel1Header.Controls.Add(this.btnMembership);
            this.Panel1Header.Controls.Add(this.btnNewMember);
            this.Panel1Header.Location = new System.Drawing.Point(177, 0);
            this.Panel1Header.Name = "Panel1Header";
            this.Panel1Header.Size = new System.Drawing.Size(622, 143);
            this.Panel1Header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::PresentationDesktop.Properties.Resources.Exit;
            this.pictureBox1.InitialImage = global::PresentationDesktop.Properties.Resources.Exit;
            this.pictureBox1.Location = new System.Drawing.Point(532, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(513, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Location = new System.Drawing.Point(177, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 83);
            this.panel1.TabIndex = 2;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(21, 10);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(478, 20);
            this.txtUserID.TabIndex = 9;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(22, 36);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(478, 31);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Image = global::PresentationDesktop.Properties.Resources.LP_Header;
            this.pictureBox2.InitialImage = global::PresentationDesktop.Properties.Resources.LP_Header;
            this.pictureBox2.Location = new System.Drawing.Point(12, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 212);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Panel2Dolasci);
            this.Controls.Add(this.Panel1Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Terminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lightweight Terminal";
            this.Load += new System.EventHandler(this.Terminal_Load);
            this.Panel2Dolasci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Panel2Dolasci;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnPersonalTraining;
        private System.Windows.Forms.Button btnMemberInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel1Header;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtUserID;
    }
}

