﻿namespace Swen_Assignment_3
{
    partial class CreateStaff
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
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffDOB = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblStaffAddress = new System.Windows.Forms.Label();
            this.lblStaffPhoneNumber = new System.Windows.Forms.Label();
            this.lblDuty = new System.Windows.Forms.Label();
            this.tbxStaffName = new System.Windows.Forms.TextBox();
            this.tbxStaffDOB = new System.Windows.Forms.TextBox();
            this.tbxBankAccount = new System.Windows.Forms.TextBox();
            this.tbxStaffAddress = new System.Windows.Forms.TextBox();
            this.tbxStaffPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbbDuty = new System.Windows.Forms.ComboBox();
            this.btnCreateStaff = new System.Windows.Forms.Button();
            this.btnCancelCreateStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Controls.Add(this.lblStaffName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStaffDOB, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBankAccount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblStaffAddress, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblStaffPhoneNumber, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDuty, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbxStaffName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxStaffDOB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxBankAccount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxStaffAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxStaffPhoneNumber, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbbDuty, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 264);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(3, 35);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(139, 38);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name: ";
            this.lblStaffName.Click += new System.EventHandler(this.lblStaffName_Click);
            // 
            // lblStaffDOB
            // 
            this.lblStaffDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffDOB.AutoSize = true;
            this.lblStaffDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDOB.Location = new System.Drawing.Point(3, 73);
            this.lblStaffDOB.Name = "lblStaffDOB";
            this.lblStaffDOB.Size = new System.Drawing.Size(139, 34);
            this.lblStaffDOB.TabIndex = 2;
            this.lblStaffDOB.Text = "Date Of Birth: ";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccount.Location = new System.Drawing.Point(3, 107);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(139, 37);
            this.lblBankAccount.TabIndex = 3;
            this.lblBankAccount.Text = "Bank Account: ";
            // 
            // lblStaffAddress
            // 
            this.lblStaffAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffAddress.AutoSize = true;
            this.lblStaffAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffAddress.Location = new System.Drawing.Point(3, 144);
            this.lblStaffAddress.Name = "lblStaffAddress";
            this.lblStaffAddress.Size = new System.Drawing.Size(139, 38);
            this.lblStaffAddress.TabIndex = 4;
            this.lblStaffAddress.Text = "Address: ";
            // 
            // lblStaffPhoneNumber
            // 
            this.lblStaffPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffPhoneNumber.AutoSize = true;
            this.lblStaffPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPhoneNumber.Location = new System.Drawing.Point(3, 182);
            this.lblStaffPhoneNumber.Name = "lblStaffPhoneNumber";
            this.lblStaffPhoneNumber.Size = new System.Drawing.Size(139, 40);
            this.lblStaffPhoneNumber.TabIndex = 5;
            this.lblStaffPhoneNumber.Text = "Phone Number:";
            // 
            // lblDuty
            // 
            this.lblDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDuty.AutoSize = true;
            this.lblDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuty.Location = new System.Drawing.Point(3, 222);
            this.lblDuty.Name = "lblDuty";
            this.lblDuty.Size = new System.Drawing.Size(139, 42);
            this.lblDuty.TabIndex = 6;
            this.lblDuty.Text = "Duty:";
            // 
            // tbxStaffName
            // 
            this.tbxStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffName.Location = new System.Drawing.Point(148, 38);
            this.tbxStaffName.Name = "tbxStaffName";
            this.tbxStaffName.Size = new System.Drawing.Size(139, 26);
            this.tbxStaffName.TabIndex = 8;
            // 
            // tbxStaffDOB
            // 
            this.tbxStaffDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStaffDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffDOB.Location = new System.Drawing.Point(148, 76);
            this.tbxStaffDOB.Name = "tbxStaffDOB";
            this.tbxStaffDOB.Size = new System.Drawing.Size(139, 26);
            this.tbxStaffDOB.TabIndex = 9;
            // 
            // tbxBankAccount
            // 
            this.tbxBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBankAccount.Location = new System.Drawing.Point(148, 110);
            this.tbxBankAccount.Name = "tbxBankAccount";
            this.tbxBankAccount.Size = new System.Drawing.Size(139, 26);
            this.tbxBankAccount.TabIndex = 10;
            // 
            // tbxStaffAddress
            // 
            this.tbxStaffAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStaffAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffAddress.Location = new System.Drawing.Point(148, 147);
            this.tbxStaffAddress.Name = "tbxStaffAddress";
            this.tbxStaffAddress.Size = new System.Drawing.Size(139, 26);
            this.tbxStaffAddress.TabIndex = 11;
            // 
            // tbxStaffPhoneNumber
            // 
            this.tbxStaffPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStaffPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStaffPhoneNumber.Location = new System.Drawing.Point(148, 185);
            this.tbxStaffPhoneNumber.Name = "tbxStaffPhoneNumber";
            this.tbxStaffPhoneNumber.Size = new System.Drawing.Size(139, 26);
            this.tbxStaffPhoneNumber.TabIndex = 12;
            // 
            // cbbDuty
            // 
            this.cbbDuty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDuty.FormattingEnabled = true;
            this.cbbDuty.Items.AddRange(new object[] {
            "General Maintenance",
            "Estate Maintenance",
            "Room Maintenance"});
            this.cbbDuty.Location = new System.Drawing.Point(148, 225);
            this.cbbDuty.Name = "cbbDuty";
            this.cbbDuty.Size = new System.Drawing.Size(139, 28);
            this.cbbDuty.TabIndex = 13;
            this.cbbDuty.SelectedIndexChanged += new System.EventHandler(this.cbbDuty_SelectedIndexChanged);
            // 
            // btnCreateStaff
            // 
            this.btnCreateStaff.Location = new System.Drawing.Point(158, 371);
            this.btnCreateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateStaff.Name = "btnCreateStaff";
            this.btnCreateStaff.Size = new System.Drawing.Size(64, 19);
            this.btnCreateStaff.TabIndex = 3;
            this.btnCreateStaff.Text = "Create";
            this.btnCreateStaff.UseVisualStyleBackColor = true;
            this.btnCreateStaff.Click += new System.EventHandler(this.btnCreateStaff_Click);
            // 
            // btnCancelCreateStaff
            // 
            this.btnCancelCreateStaff.Location = new System.Drawing.Point(290, 370);
            this.btnCancelCreateStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCreateStaff.Name = "btnCancelCreateStaff";
            this.btnCancelCreateStaff.Size = new System.Drawing.Size(68, 20);
            this.btnCancelCreateStaff.TabIndex = 4;
            this.btnCancelCreateStaff.Text = "Cancel";
            this.btnCancelCreateStaff.UseVisualStyleBackColor = true;
            this.btnCancelCreateStaff.Click += new System.EventHandler(this.btnCancelStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Staff";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelCreateStaff);
            this.Controls.Add(this.btnCreateStaff);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateStaff";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffDOB;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblStaffAddress;
        private System.Windows.Forms.Label lblStaffPhoneNumber;
        private System.Windows.Forms.Label lblDuty;
        private System.Windows.Forms.TextBox tbxStaffName;
        private System.Windows.Forms.TextBox tbxStaffDOB;
        private System.Windows.Forms.TextBox tbxBankAccount;
        private System.Windows.Forms.TextBox tbxStaffAddress;
        private System.Windows.Forms.TextBox tbxStaffPhoneNumber;
        private System.Windows.Forms.Button btnCreateStaff;
        private System.Windows.Forms.Button btnCancelCreateStaff;
        private System.Windows.Forms.ComboBox cbbDuty;
        private System.Windows.Forms.Label label1;
    }
}

