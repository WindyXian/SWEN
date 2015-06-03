namespace Swen_Assignment_3
{
    partial class CreateSchedule
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
            this.btnCancelSchedule = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateOfDuty = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbxEmployeeID = new System.Windows.Forms.TextBox();
            this.tbxDateOfDuty = new System.Windows.Forms.TextBox();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblCreateScheduleTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelSchedule
            // 
            this.btnCancelSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSchedule.Location = new System.Drawing.Point(306, 286);
            this.btnCancelSchedule.Name = "btnCancelSchedule";
            this.btnCancelSchedule.Size = new System.Drawing.Size(80, 29);
            this.btnCancelSchedule.TabIndex = 7;
            this.btnCancelSchedule.Text = "Cancel";
            this.btnCancelSchedule.UseVisualStyleBackColor = true;
            this.btnCancelSchedule.Click += new System.EventHandler(this.btnCancelSchedule_Click);
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSchedule.Location = new System.Drawing.Point(120, 286);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(85, 29);
            this.btnCreateSchedule.TabIndex = 6;
            this.btnCreateSchedule.Text = "Create";
            this.btnCreateSchedule.UseVisualStyleBackColor = true;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateOfDuty, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblProgress, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxEmployeeID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxDateOfDuty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblInProgress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeID, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 173);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblDateOfDuty
            // 
            this.lblDateOfDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfDuty.AutoSize = true;
            this.lblDateOfDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfDuty.Location = new System.Drawing.Point(3, 87);
            this.lblDateOfDuty.Name = "lblDateOfDuty";
            this.lblDateOfDuty.Size = new System.Drawing.Size(99, 44);
            this.lblDateOfDuty.TabIndex = 3;
            this.lblDateOfDuty.Text = "Date Of Duty: ";
            this.lblDateOfDuty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(3, 131);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(99, 42);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Progress: ";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmployeeID
            // 
            this.tbxEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeID.Location = new System.Drawing.Point(108, 47);
            this.tbxEmployeeID.Name = "tbxEmployeeID";
            this.tbxEmployeeID.Size = new System.Drawing.Size(147, 26);
            this.tbxEmployeeID.TabIndex = 6;
            // 
            // tbxDateOfDuty
            // 
            this.tbxDateOfDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDateOfDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDateOfDuty.Location = new System.Drawing.Point(108, 90);
            this.tbxDateOfDuty.Name = "tbxDateOfDuty";
            this.tbxDateOfDuty.Size = new System.Drawing.Size(147, 26);
            this.tbxDateOfDuty.TabIndex = 7;
            // 
            // lblInProgress
            // 
            this.lblInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(108, 131);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(147, 42);
            this.lblInProgress.TabIndex = 10;
            this.lblInProgress.Text = "In Progress";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.Location = new System.Drawing.Point(3, 44);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(99, 43);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID: ";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateScheduleTitle
            // 
            this.lblCreateScheduleTitle.AutoSize = true;
            this.lblCreateScheduleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateScheduleTitle.Location = new System.Drawing.Point(12, 9);
            this.lblCreateScheduleTitle.Name = "lblCreateScheduleTitle";
            this.lblCreateScheduleTitle.Size = new System.Drawing.Size(231, 31);
            this.lblCreateScheduleTitle.TabIndex = 4;
            this.lblCreateScheduleTitle.Text = "Create Schedule";
            // 
            // CreateSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 420);
            this.Controls.Add(this.btnCancelSchedule);
            this.Controls.Add(this.btnCreateSchedule);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCreateScheduleTitle);
            this.Name = "CreateSchedule";
            this.Text = "CreateSchedule";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSchedule;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDateOfDuty;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TextBox tbxEmployeeID;
        private System.Windows.Forms.TextBox tbxDateOfDuty;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblCreateScheduleTitle;
    }
}