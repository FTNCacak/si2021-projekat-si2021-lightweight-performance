namespace PresentationDesktop
{
    partial class PersonalTraining
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1Search = new System.Windows.Forms.Button();
            this.textBox1Member = new System.Windows.Forms.TextBox();
            this.dataGridView1Personal = new System.Windows.Forms.DataGridView();
            this.button2AddTraining = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2Plan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3Trainer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Personal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(98, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training plan:";
            // 
            // button1Search
            // 
            this.button1Search.Location = new System.Drawing.Point(534, 47);
            this.button1Search.Name = "button1Search";
            this.button1Search.Size = new System.Drawing.Size(57, 33);
            this.button1Search.TabIndex = 1;
            this.button1Search.Text = " 🔍";
            this.button1Search.UseVisualStyleBackColor = true;
            // 
            // textBox1Member
            // 
            this.textBox1Member.Location = new System.Drawing.Point(226, 47);
            this.textBox1Member.Multiline = true;
            this.textBox1Member.Name = "textBox1Member";
            this.textBox1Member.Size = new System.Drawing.Size(302, 33);
            this.textBox1Member.TabIndex = 2;
            // 
            // dataGridView1Personal
            // 
            this.dataGridView1Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Personal.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1Personal.Name = "dataGridView1Personal";
            this.dataGridView1Personal.Size = new System.Drawing.Size(623, 347);
            this.dataGridView1Personal.TabIndex = 3;
            // 
            // button2AddTraining
            // 
            this.button2AddTraining.Location = new System.Drawing.Point(55, 178);
            this.button2AddTraining.Name = "button2AddTraining";
            this.button2AddTraining.Size = new System.Drawing.Size(167, 26);
            this.button2AddTraining.TabIndex = 4;
            this.button2AddTraining.Text = "Add Personal Training";
            this.button2AddTraining.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox2Plan
            // 
            this.textBox2Plan.Location = new System.Drawing.Point(226, 95);
            this.textBox2Plan.Name = "textBox2Plan";
            this.textBox2Plan.Size = new System.Drawing.Size(302, 26);
            this.textBox2Plan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(90, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Personal trainer:";
            // 
            // textBox3Trainer
            // 
            this.textBox3Trainer.Location = new System.Drawing.Point(227, 136);
            this.textBox3Trainer.Name = "textBox3Trainer";
            this.textBox3Trainer.Size = new System.Drawing.Size(302, 26);
            this.textBox3Trainer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(109, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Member:";
            // 
            // button3Back
            // 
            this.button3Back.Location = new System.Drawing.Point(588, 12);
            this.button3Back.Name = "button3Back";
            this.button3Back.Size = new System.Drawing.Size(61, 26);
            this.button3Back.TabIndex = 10;
            this.button3Back.Text = "BACK";
            this.button3Back.UseVisualStyleBackColor = true;
            // 
            // PersonalTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(661, 621);
            this.Controls.Add(this.button3Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3Trainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2Plan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2AddTraining);
            this.Controls.Add(this.dataGridView1Personal);
            this.Controls.Add(this.textBox1Member);
            this.Controls.Add(this.button1Search);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonalTraining";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Personal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Search;
        private System.Windows.Forms.TextBox textBox1Member;
        private System.Windows.Forms.DataGridView dataGridView1Personal;
        private System.Windows.Forms.Button button2AddTraining;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2Plan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3Trainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3Back;
    }
}