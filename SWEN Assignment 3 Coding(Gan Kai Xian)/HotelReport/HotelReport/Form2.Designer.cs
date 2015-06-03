namespace HotelReport
{
    partial class Form2
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
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxStrtDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(15, 154);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(566, 213);
            this.tbxOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter Date:";
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(15, 92);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(118, 39);
            this.btnDay.TabIndex = 13;
            this.btnDay.Text = "Get Statistics by Day";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(297, 92);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(118, 39);
            this.btnMonth.TabIndex = 16;
            this.btnMonth.Text = "Get Statistics by Month";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(439, 92);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(118, 39);
            this.btnYear.TabIndex = 17;
            this.btnYear.Text = "Get Statistics by Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(157, 92);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(118, 39);
            this.btnWeek.TabIndex = 18;
            this.btnWeek.Text = "Get Statistics by Week";
            this.btnWeek.UseVisualStyleBackColor = true;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "E.g. YYYY-MM-DD";
            // 
            // tbxStrtDate
            // 
            this.tbxStrtDate.Location = new System.Drawing.Point(73, 15);
            this.tbxStrtDate.Mask = "0000-00-00";
            this.tbxStrtDate.Name = "tbxStrtDate";
            this.tbxStrtDate.Size = new System.Drawing.Size(135, 20);
            this.tbxStrtDate.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 379);
            this.Controls.Add(this.tbxStrtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOutput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tbxStrtDate;
    }
}