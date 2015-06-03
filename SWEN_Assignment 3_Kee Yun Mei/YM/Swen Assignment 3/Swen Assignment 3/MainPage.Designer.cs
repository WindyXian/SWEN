namespace Swen_Assignment_3
{
    partial class MainPage
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
            this.lblMainPageTitle = new System.Windows.Forms.Label();
            this.btnCreateScheduleMain = new System.Windows.Forms.Button();
            this.btnRetrieveScheduleMain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScheduleManagement = new System.Windows.Forms.Label();
            this.lblStaffManagement = new System.Windows.Forms.Label();
            this.btnCreateStaffMain = new System.Windows.Forms.Button();
            this.btnRetrieveStaffMain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainPageTitle
            // 
            this.lblMainPageTitle.AutoSize = true;
            this.lblMainPageTitle.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPageTitle.Location = new System.Drawing.Point(13, 13);
            this.lblMainPageTitle.Name = "lblMainPageTitle";
            this.lblMainPageTitle.Size = new System.Drawing.Size(151, 31);
            this.lblMainPageTitle.TabIndex = 0;
            this.lblMainPageTitle.Text = "Main Page";
            // 
            // btnCreateScheduleMain
            // 
            this.btnCreateScheduleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateScheduleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateScheduleMain.Location = new System.Drawing.Point(3, 115);
            this.btnCreateScheduleMain.Name = "btnCreateScheduleMain";
            this.btnCreateScheduleMain.Size = new System.Drawing.Size(232, 34);
            this.btnCreateScheduleMain.TabIndex = 1;
            this.btnCreateScheduleMain.Text = "Create Schedule";
            this.btnCreateScheduleMain.UseVisualStyleBackColor = true;
            this.btnCreateScheduleMain.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRetrieveScheduleMain
            // 
            this.btnRetrieveScheduleMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieveScheduleMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveScheduleMain.Location = new System.Drawing.Point(3, 155);
            this.btnRetrieveScheduleMain.Name = "btnRetrieveScheduleMain";
            this.btnRetrieveScheduleMain.Size = new System.Drawing.Size(232, 33);
            this.btnRetrieveScheduleMain.TabIndex = 2;
            this.btnRetrieveScheduleMain.Text = "Retrieve Schedule";
            this.btnRetrieveScheduleMain.UseVisualStyleBackColor = true;
            this.btnRetrieveScheduleMain.Click += new System.EventHandler(this.btnRetrieveSchedule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRetrieveScheduleMain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateScheduleMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblScheduleManagement, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStaffManagement, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCreateStaffMain, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRetrieveStaffMain, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.80952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.19048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 191);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblScheduleManagement
            // 
            this.lblScheduleManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScheduleManagement.AutoSize = true;
            this.lblScheduleManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleManagement.Location = new System.Drawing.Point(3, 0);
            this.lblScheduleManagement.Name = "lblScheduleManagement";
            this.lblScheduleManagement.Size = new System.Drawing.Size(232, 112);
            this.lblScheduleManagement.TabIndex = 3;
            this.lblScheduleManagement.Text = "Schedule Management";
            this.lblScheduleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStaffManagement
            // 
            this.lblStaffManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffManagement.AutoSize = true;
            this.lblStaffManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffManagement.Location = new System.Drawing.Point(241, 0);
            this.lblStaffManagement.Name = "lblStaffManagement";
            this.lblStaffManagement.Size = new System.Drawing.Size(233, 112);
            this.lblStaffManagement.TabIndex = 4;
            this.lblStaffManagement.Text = "Staff Management";
            this.lblStaffManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateStaffMain
            // 
            this.btnCreateStaffMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateStaffMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStaffMain.Location = new System.Drawing.Point(241, 115);
            this.btnCreateStaffMain.Name = "btnCreateStaffMain";
            this.btnCreateStaffMain.Size = new System.Drawing.Size(233, 34);
            this.btnCreateStaffMain.TabIndex = 5;
            this.btnCreateStaffMain.Text = "Create Staff";
            this.btnCreateStaffMain.UseVisualStyleBackColor = true;
            this.btnCreateStaffMain.Click += new System.EventHandler(this.btnCreateStaffMain_Click);
            // 
            // btnRetrieveStaffMain
            // 
            this.btnRetrieveStaffMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetrieveStaffMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveStaffMain.Location = new System.Drawing.Point(241, 155);
            this.btnRetrieveStaffMain.Name = "btnRetrieveStaffMain";
            this.btnRetrieveStaffMain.Size = new System.Drawing.Size(233, 33);
            this.btnRetrieveStaffMain.TabIndex = 6;
            this.btnRetrieveStaffMain.Text = "Retrieve Staff";
            this.btnRetrieveStaffMain.UseVisualStyleBackColor = true;
            this.btnRetrieveStaffMain.Click += new System.EventHandler(this.btnRetrieveStaffMain_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblMainPageTitle);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainPageTitle;
        private System.Windows.Forms.Button btnCreateScheduleMain;
        private System.Windows.Forms.Button btnRetrieveScheduleMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblScheduleManagement;
        private System.Windows.Forms.Label lblStaffManagement;
        private System.Windows.Forms.Button btnCreateStaffMain;
        private System.Windows.Forms.Button btnRetrieveStaffMain;
    }
}