namespace swen_assignment_3
{
    partial class MainBookingPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBooking = new System.Windows.Forms.Label();
            this.btnCreateBooking = new System.Windows.Forms.Button();
            this.btnRetrieveBooking = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreateBooking, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRetrieveBooking, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPayment, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(91, 28);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(173, 46);
            this.lblBooking.TabIndex = 1;
            this.lblBooking.Text = "Booking";
            // 
            // btnCreateBooking
            // 
            this.btnCreateBooking.Location = new System.Drawing.Point(3, 3);
            this.btnCreateBooking.Name = "btnCreateBooking";
            this.btnCreateBooking.Size = new System.Drawing.Size(194, 40);
            this.btnCreateBooking.TabIndex = 0;
            this.btnCreateBooking.Text = "Create Booking";
            this.btnCreateBooking.UseVisualStyleBackColor = true;
            this.btnCreateBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRetrieveBooking
            // 
            this.btnRetrieveBooking.Location = new System.Drawing.Point(3, 49);
            this.btnRetrieveBooking.Name = "btnRetrieveBooking";
            this.btnRetrieveBooking.Size = new System.Drawing.Size(194, 40);
            this.btnRetrieveBooking.TabIndex = 1;
            this.btnRetrieveBooking.Text = "Retrieve Booking";
            this.btnRetrieveBooking.UseVisualStyleBackColor = true;
            this.btnRetrieveBooking.Click += new System.EventHandler(this.btnRetrieveBooking_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(3, 95);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(194, 42);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // MainBookingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 281);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainBookingPage";
            this.Text = "MainBookingPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreateBooking;
        private System.Windows.Forms.Button btnRetrieveBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Button btnPayment;
    }
}