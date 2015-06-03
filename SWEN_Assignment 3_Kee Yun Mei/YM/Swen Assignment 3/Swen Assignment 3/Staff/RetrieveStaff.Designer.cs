namespace Swen_Assignment_3
{
    partial class RetrieveStaff
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
            this.lblRetrieveStaff = new System.Windows.Forms.Label();
            this.tbxRetrieveEmployeeID = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnCancelStaffRetrieve = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRetrieveStaff
            // 
            this.lblRetrieveStaff.AutoSize = true;
            this.lblRetrieveStaff.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetrieveStaff.Location = new System.Drawing.Point(12, 9);
            this.lblRetrieveStaff.Name = "lblRetrieveStaff";
            this.lblRetrieveStaff.Size = new System.Drawing.Size(205, 31);
            this.lblRetrieveStaff.TabIndex = 0;
            this.lblRetrieveStaff.Text = "Retrieve Staff";
            // 
            // tbxRetrieveEmployeeID
            // 
            this.tbxRetrieveEmployeeID.Location = new System.Drawing.Point(171, 64);
            this.tbxRetrieveEmployeeID.Name = "tbxRetrieveEmployeeID";
            this.tbxRetrieveEmployeeID.Size = new System.Drawing.Size(133, 20);
            this.tbxRetrieveEmployeeID.TabIndex = 1;
            this.tbxRetrieveEmployeeID.TextChanged += new System.EventHandler(this.tbxRetrieveEmployeeID_TextChanged);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(316, 61);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(14, 64);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(151, 20);
            this.lblEmployeeID.TabIndex = 3;
            this.lblEmployeeID.Text = "Enter Employee ID: ";
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(18, 126);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(373, 156);
            this.tbxOutput.TabIndex = 4;
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(316, 90);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAll.TabIndex = 5;
            this.btnSearchAll.Text = "Search All";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(18, 310);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStaff.TabIndex = 6;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancelStaffRetrieve
            // 
            this.btnCancelStaffRetrieve.Location = new System.Drawing.Point(171, 310);
            this.btnCancelStaffRetrieve.Name = "btnCancelStaffRetrieve";
            this.btnCancelStaffRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStaffRetrieve.TabIndex = 7;
            this.btnCancelStaffRetrieve.Text = "Cancel";
            this.btnCancelStaffRetrieve.UseVisualStyleBackColor = true;
            this.btnCancelStaffRetrieve.Click += new System.EventHandler(this.btnCancelStaffRetrieve_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(316, 310);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 8;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // RetrieveStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 361);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnCancelStaffRetrieve);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.tbxRetrieveEmployeeID);
            this.Controls.Add(this.lblRetrieveStaff);
            this.Name = "RetrieveStaff";
            this.Text = "RetrieveStaff";
            this.Load += new System.EventHandler(this.RetrieveStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetrieveStaff;
        private System.Windows.Forms.TextBox tbxRetrieveEmployeeID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnCancelStaffRetrieve;
        private System.Windows.Forms.Button btnDeleteStaff;
    }
}