namespace PresentationDesktop
{
    partial class Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membership));
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox2Expiration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3Cost = new System.Windows.Forms.TextBox();
            this.checkBox1Personal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxSearch.Location = new System.Drawing.Point(44, 56);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(129, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Enter member ID";
            this.textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2Expiration
            // 
            this.textBox2Expiration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBox2Expiration.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox2Expiration.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2Expiration.Location = new System.Drawing.Point(44, 89);
            this.textBox2Expiration.Name = "textBox2Expiration";
            this.textBox2Expiration.Size = new System.Drawing.Size(129, 22);
            this.textBox2Expiration.TabIndex = 2;
            this.textBox2Expiration.Text = "Insert # months";
            this.textBox2Expiration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(29, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Membership\r\nCost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3Cost
            // 
            this.textBox3Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.textBox3Cost.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.textBox3Cost.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3Cost.Location = new System.Drawing.Point(44, 153);
            this.textBox3Cost.Multiline = true;
            this.textBox3Cost.Name = "textBox3Cost";
            this.textBox3Cost.Size = new System.Drawing.Size(129, 40);
            this.textBox3Cost.TabIndex = 5;
            this.textBox3Cost.Text = "Total sum";
            this.textBox3Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1Personal
            // 
            this.checkBox1Personal.AutoSize = true;
            this.checkBox1Personal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1Personal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1Personal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1Personal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.checkBox1Personal.Location = new System.Drawing.Point(44, 123);
            this.checkBox1Personal.Name = "checkBox1Personal";
            this.checkBox1Personal.Size = new System.Drawing.Size(49, 20);
            this.checkBox1Personal.TabIndex = 6;
            this.checkBox1Personal.Text = "YES";
            this.checkBox1Personal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Personal Training:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::PresentationDesktop.Properties.Resources.BackButton;
            this.pictureBox2.Location = new System.Drawing.Point(89, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(51)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.btnConfirm.Location = new System.Drawing.Point(44, 207);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(129, 53);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 273);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(211)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(29, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Update membership";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox3Cost);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.textBox2Expiration);
            this.panel2.Controls.Add(this.checkBox1Personal);
            this.panel2.Location = new System.Drawing.Point(250, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 273);
            this.panel2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(211)))), ((int)(((byte)(234)))));
            this.label8.Location = new System.Drawing.Point(42, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter membership\r\ndetails\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(161)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(29, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Member ID:";
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.BackgroundImage = global::PresentationDesktop.Properties.Resources.Background_Dark;
            this.ClientSize = new System.Drawing.Size(464, 302);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Membership";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Membership_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox2Expiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3Cost;
        private System.Windows.Forms.CheckBox checkBox1Personal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}