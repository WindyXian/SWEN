namespace swen_assignment_3
{
    partial class AddPayment
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.tbxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardHolderName = new System.Windows.Forms.Label();
            this.tbxCardHolderName = new System.Windows.Forms.TextBox();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.tbxExpiryDate = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.cbxPaymentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPrice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(13, 13);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(63, 17);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment";
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(16, 135);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(133, 17);
            this.lblCreditCardNumber.TabIndex = 3;
            this.lblCreditCardNumber.Text = "Credit Card Number";
            // 
            // tbxCreditCardNumber
            // 
            this.tbxCreditCardNumber.Location = new System.Drawing.Point(19, 156);
            this.tbxCreditCardNumber.Name = "tbxCreditCardNumber";
            this.tbxCreditCardNumber.Size = new System.Drawing.Size(130, 22);
            this.tbxCreditCardNumber.TabIndex = 4;
            // 
            // lblCardHolderName
            // 
            this.lblCardHolderName.AutoSize = true;
            this.lblCardHolderName.Location = new System.Drawing.Point(16, 199);
            this.lblCardHolderName.Name = "lblCardHolderName";
            this.lblCardHolderName.Size = new System.Drawing.Size(125, 17);
            this.lblCardHolderName.TabIndex = 5;
            this.lblCardHolderName.Text = "Card Holder Name";
            // 
            // tbxCardHolderName
            // 
            this.tbxCardHolderName.Location = new System.Drawing.Point(19, 219);
            this.tbxCardHolderName.Name = "tbxCardHolderName";
            this.tbxCardHolderName.Size = new System.Drawing.Size(130, 22);
            this.tbxCardHolderName.TabIndex = 6;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(16, 266);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(80, 17);
            this.lblExpiryDate.TabIndex = 7;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // tbxExpiryDate
            // 
            this.tbxExpiryDate.Location = new System.Drawing.Point(22, 286);
            this.tbxExpiryDate.Name = "tbxExpiryDate";
            this.tbxExpiryDate.Size = new System.Drawing.Size(127, 22);
            this.tbxExpiryDate.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(19, 386);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 17);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.lblCreditCardAmount_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(19, 433);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(126, 433);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 12;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Location = new System.Drawing.Point(13, 58);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(99, 17);
            this.lblPaymentType.TabIndex = 1;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.Items.AddRange(new object[] {
            "Credit Card"});
            this.cbxPaymentType.Location = new System.Drawing.Point(16, 88);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(121, 24);
            this.cbxPaymentType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Price";
            // 
            // cbxPrice
            // 
            this.cbxPrice.FormattingEnabled = true;
            this.cbxPrice.Items.AddRange(new object[] {
            "60",
            "120",
            "180",
            "240"});
            this.cbxPrice.Location = new System.Drawing.Point(22, 343);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(121, 24);
            this.cbxPrice.TabIndex = 14;
            this.cbxPrice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 507);
            this.Controls.Add(this.cbxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.tbxExpiryDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.tbxCardHolderName);
            this.Controls.Add(this.lblCardHolderName);
            this.Controls.Add(this.tbxCreditCardNumber);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.cbxPaymentType);
            this.Controls.Add(this.lblPaymentType);
            this.Controls.Add(this.lblPayment);
            this.Name = "AddPayment";
            this.Text = "AddPayment";
            this.Load += new System.EventHandler(this.AddPaymentCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.TextBox tbxCreditCardNumber;
        private System.Windows.Forms.Label lblCardHolderName;
        private System.Windows.Forms.TextBox tbxCardHolderName;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox tbxExpiryDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.ComboBox cbxPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrice;
    }
}