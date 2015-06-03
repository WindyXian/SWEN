namespace swen_assignment_3
{
    partial class RetrieveBooking
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
            this.lblRetrieveGuest = new System.Windows.Forms.Label();
            this.lblEnterBookingID = new System.Windows.Forms.Label();
            this.tbxRetrieveBookingID = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRetrieveGuest
            // 
            this.lblRetrieveGuest.AutoSize = true;
            this.lblRetrieveGuest.Location = new System.Drawing.Point(13, 13);
            this.lblRetrieveGuest.Name = "lblRetrieveGuest";
            this.lblRetrieveGuest.Size = new System.Drawing.Size(103, 17);
            this.lblRetrieveGuest.TabIndex = 0;
            this.lblRetrieveGuest.Text = "Retrieve Guest";
            // 
            // lblEnterBookingID
            // 
            this.lblEnterBookingID.AutoSize = true;
            this.lblEnterBookingID.Location = new System.Drawing.Point(13, 40);
            this.lblEnterBookingID.Name = "lblEnterBookingID";
            this.lblEnterBookingID.Size = new System.Drawing.Size(118, 17);
            this.lblEnterBookingID.TabIndex = 1;
            this.lblEnterBookingID.Text = "Enter Booking ID:";
            // 
            // tbxRetrieveBookingID
            // 
            this.tbxRetrieveBookingID.Location = new System.Drawing.Point(137, 37);
            this.tbxRetrieveBookingID.Name = "tbxRetrieveBookingID";
            this.tbxRetrieveBookingID.Size = new System.Drawing.Size(100, 22);
            this.tbxRetrieveBookingID.TabIndex = 2;
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(261, 37);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(117, 23);
            this.btnSearchID.TabIndex = 3;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(261, 67);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(117, 23);
            this.btnSearchAll.TabIndex = 4;
            this.btnSearchAll.Text = "Search All";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(16, 97);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(362, 191);
            this.tbxOutput.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(60, 325);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // RetrieveBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 386);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.tbxRetrieveBookingID);
            this.Controls.Add(this.lblEnterBookingID);
            this.Controls.Add(this.lblRetrieveGuest);
            this.Name = "RetrieveBooking";
            this.Text = "RetrieveGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetrieveGuest;
        private System.Windows.Forms.Label lblEnterBookingID;
        private System.Windows.Forms.TextBox tbxRetrieveBookingID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}