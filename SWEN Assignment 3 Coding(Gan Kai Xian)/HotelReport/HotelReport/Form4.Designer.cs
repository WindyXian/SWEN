namespace HotelReport
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDailySchedule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWeeklySchedule = new System.Windows.Forms.Button();
            this.btnMonthlySchedule = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 170);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnDailySchedule
            // 
            this.btnDailySchedule.Location = new System.Drawing.Point(12, 248);
            this.btnDailySchedule.Name = "btnDailySchedule";
            this.btnDailySchedule.Size = new System.Drawing.Size(118, 39);
            this.btnDailySchedule.TabIndex = 21;
            this.btnDailySchedule.Text = "Get Daily Schedule";
            this.btnDailySchedule.UseVisualStyleBackColor = true;
            this.btnDailySchedule.Click += new System.EventHandler(this.btnDailySchedule_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Date:";
            // 
            // btnWeeklySchedule
            // 
            this.btnWeeklySchedule.Location = new System.Drawing.Point(158, 248);
            this.btnWeeklySchedule.Name = "btnWeeklySchedule";
            this.btnWeeklySchedule.Size = new System.Drawing.Size(118, 39);
            this.btnWeeklySchedule.TabIndex = 22;
            this.btnWeeklySchedule.Text = "Get Weekly Schedule";
            this.btnWeeklySchedule.UseVisualStyleBackColor = true;
            this.btnWeeklySchedule.Click += new System.EventHandler(this.btnWeeklySchedule_Click);
            // 
            // btnMonthlySchedule
            // 
            this.btnMonthlySchedule.Location = new System.Drawing.Point(305, 248);
            this.btnMonthlySchedule.Name = "btnMonthlySchedule";
            this.btnMonthlySchedule.Size = new System.Drawing.Size(118, 39);
            this.btnMonthlySchedule.TabIndex = 23;
            this.btnMonthlySchedule.Text = "Get Monthly Schedule";
            this.btnMonthlySchedule.UseVisualStyleBackColor = true;
            this.btnMonthlySchedule.Click += new System.EventHandler(this.btnMonthlySchedule_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "E.g. YYYY-MM-DD";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(76, 199);
            this.tbxDate.Mask = "0000-00-00";
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(135, 20);
            this.tbxDate.TabIndex = 25;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 360);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMonthlySchedule);
            this.Controls.Add(this.btnWeeklySchedule);
            this.Controls.Add(this.btnDailySchedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDailySchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeeklySchedule;
        private System.Windows.Forms.Button btnMonthlySchedule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbxDate;
    }
}