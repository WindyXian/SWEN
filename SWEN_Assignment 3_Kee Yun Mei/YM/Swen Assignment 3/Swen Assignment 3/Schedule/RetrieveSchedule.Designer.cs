namespace Swen_Assignment_3.Schedule
{
    partial class RetrieveSchedule
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
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.btnCancelScheduleRetrieve = new System.Windows.Forms.Button();
            this.btnUpdateSchedule = new System.Windows.Forms.Button();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.lblRoomID = new System.Windows.Forms.Label();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.tbxRetrieveRoomID = new System.Windows.Forms.TextBox();
            this.lblRetrieveSchedule = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Location = new System.Drawing.Point(316, 310);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSchedule.TabIndex = 17;
            this.btnDeleteSchedule.Text = "Delete";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // btnCancelScheduleRetrieve
            // 
            this.btnCancelScheduleRetrieve.Location = new System.Drawing.Point(171, 310);
            this.btnCancelScheduleRetrieve.Name = "btnCancelScheduleRetrieve";
            this.btnCancelScheduleRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnCancelScheduleRetrieve.TabIndex = 16;
            this.btnCancelScheduleRetrieve.Text = "Cancel";
            this.btnCancelScheduleRetrieve.UseVisualStyleBackColor = true;
            this.btnCancelScheduleRetrieve.Click += new System.EventHandler(this.btnCancelScheduleRetrieve_Click);
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.Location = new System.Drawing.Point(18, 310);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSchedule.TabIndex = 15;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.UseVisualStyleBackColor = true;
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(316, 90);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAll.TabIndex = 14;
            this.btnSearchAll.Text = "Search All";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(18, 126);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(373, 156);
            this.tbxOutput.TabIndex = 13;
            // 
            // lblRoomID
            // 
            this.lblRoomID.AutoSize = true;
            this.lblRoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomID.Location = new System.Drawing.Point(14, 64);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(124, 20);
            this.lblRoomID.TabIndex = 12;
            this.lblRoomID.Text = "Enter Room ID: ";
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(316, 61);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 11;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // tbxRetrieveRoomID
            // 
            this.tbxRetrieveRoomID.Location = new System.Drawing.Point(171, 64);
            this.tbxRetrieveRoomID.Name = "tbxRetrieveRoomID";
            this.tbxRetrieveRoomID.Size = new System.Drawing.Size(133, 20);
            this.tbxRetrieveRoomID.TabIndex = 10;
            // 
            // lblRetrieveSchedule
            // 
            this.lblRetrieveSchedule.AutoSize = true;
            this.lblRetrieveSchedule.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetrieveSchedule.Location = new System.Drawing.Point(12, 9);
            this.lblRetrieveSchedule.Name = "lblRetrieveSchedule";
            this.lblRetrieveSchedule.Size = new System.Drawing.Size(261, 31);
            this.lblRetrieveSchedule.TabIndex = 9;
            this.lblRetrieveSchedule.Text = "Retrieve Schedule";
            // 
            // RetrieveSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 349);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnCancelScheduleRetrieve);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.btnSearchAll);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.lblRoomID);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.tbxRetrieveRoomID);
            this.Controls.Add(this.lblRetrieveSchedule);
            this.Name = "RetrieveSchedule";
            this.Text = "RetrieveSchedule";
            this.Load += new System.EventHandler(this.RetrieveSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Button btnCancelScheduleRetrieve;
        private System.Windows.Forms.Button btnUpdateSchedule;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label lblRoomID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox tbxRetrieveRoomID;
        private System.Windows.Forms.Label lblRetrieveSchedule;
    }
}