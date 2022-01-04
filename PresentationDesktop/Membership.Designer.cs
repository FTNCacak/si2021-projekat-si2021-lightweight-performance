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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox2Expiration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3Cost = new System.Windows.Forms.TextBox();
            this.checkBox1Personal = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2Confirm = new System.Windows.Forms.Button();
            this.button3Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(273, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 26);
            this.textBoxSearch.TabIndex = 1;
            // 
            // textBox2Expiration
            // 
            this.textBox2Expiration.Location = new System.Drawing.Point(273, 49);
            this.textBox2Expiration.Name = "textBox2Expiration";
            this.textBox2Expiration.Size = new System.Drawing.Size(192, 26);
            this.textBox2Expiration.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "EXPIRATION DATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(79, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "MEMBERSHIP\r\nCOST:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3Cost
            // 
            this.textBox3Cost.Location = new System.Drawing.Point(273, 86);
            this.textBox3Cost.Multiline = true;
            this.textBox3Cost.Name = "textBox3Cost";
            this.textBox3Cost.Size = new System.Drawing.Size(192, 40);
            this.textBox3Cost.TabIndex = 5;
            this.textBox3Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1Personal
            // 
            this.checkBox1Personal.AutoSize = true;
            this.checkBox1Personal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1Personal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1Personal.Location = new System.Drawing.Point(273, 141);
            this.checkBox1Personal.Name = "checkBox1Personal";
            this.checkBox1Personal.Size = new System.Drawing.Size(47, 20);
            this.checkBox1Personal.TabIndex = 6;
            this.checkBox1Personal.Text = "YES";
            this.checkBox1Personal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(79, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "PERSONAL TRAINING?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2Confirm
            // 
            this.button2Confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2Confirm.Location = new System.Drawing.Point(273, 195);
            this.button2Confirm.Name = "button2Confirm";
            this.button2Confirm.Size = new System.Drawing.Size(192, 94);
            this.button2Confirm.TabIndex = 8;
            this.button2Confirm.Text = "Confirm";
            this.button2Confirm.UseVisualStyleBackColor = true;
            // 
            // button3Back
            // 
            this.button3Back.Location = new System.Drawing.Point(413, 315);
            this.button3Back.Name = "button3Back";
            this.button3Back.Size = new System.Drawing.Size(61, 26);
            this.button3Back.TabIndex = 11;
            this.button3Back.Text = "BACK";
            this.button3Back.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationDesktop.Properties.Resources.Termini;
            this.pictureBox1.Location = new System.Drawing.Point(75, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Membership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(495, 353);
            this.Controls.Add(this.button3Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1Personal);
            this.Controls.Add(this.textBox3Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2Expiration);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Membership";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox2Expiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3Cost;
        private System.Windows.Forms.CheckBox checkBox1Personal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2Confirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3Back;
    }
}