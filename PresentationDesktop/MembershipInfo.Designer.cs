namespace PresentationDesktop
{
    partial class MembershipInfo
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
            this.button1Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1LastName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(509, 21);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(419, 26);
            this.button1Search.TabIndex = 0;
            this.button1Search.Text = "🔎";
            this.button1Search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last name:";
            // 
            // textBox1LastName
            // 
            this.textBox1LastName.Location = new System.Drawing.Point(127, 21);
            this.textBox1LastName.Name = "textBox1LastName";
            this.textBox1LastName.Size = new System.Drawing.Size(376, 26);
            this.textBox1LastName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(916, 676);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(301, 53);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(419, 53);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Show employees";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(796, 53);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(61, 26);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MembershipInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(940, 800);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1LastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1Search);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MembershipInfo";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MembershipInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1LastName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonBack;
    }
}