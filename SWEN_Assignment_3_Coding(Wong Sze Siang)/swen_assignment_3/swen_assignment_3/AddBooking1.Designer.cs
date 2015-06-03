namespace SWEN_Assignment_3
{
    partial class AddBooking1
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
            this.components = new System.ComponentModel.Container();
            this.addBooking = new System.Windows.Forms.Label();
            this.checkInDate = new System.Windows.Forms.Label();
            this.checkOutDate = new System.Windows.Forms.Label();
            this.rooms = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adults = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.children = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.roomType = new System.Windows.Forms.Label();
            this.bedType = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.guestName = new System.Windows.Forms.Label();
            this.tbxGuestName = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxPostalCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.paymentType = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cardholderName = new System.Windows.Forms.Label();
            this.tbxCardholderName = new System.Windows.Forms.TextBox();
            this.creditcardNumber = new System.Windows.Forms.Label();
            this.tbxCreditCardNumber = new System.Windows.Forms.TextBox();
            this.expiryDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tbxCheckInDate = new System.Windows.Forms.TextBox();
            this.tbxCheckOutDate = new System.Windows.Forms.TextBox();
            this.additionalRemark = new System.Windows.Forms.Label();
            this.tbxAdditionalRemark = new System.Windows.Forms.TextBox();
            this.tbxExpiryDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBooking
            // 
            this.addBooking.AutoSize = true;
            this.addBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooking.Location = new System.Drawing.Point(13, 13);
            this.addBooking.Name = "addBooking";
            this.addBooking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addBooking.Size = new System.Drawing.Size(213, 38);
            this.addBooking.TabIndex = 0;
            this.addBooking.Text = "Add Booking";
            // 
            // checkInDate
            // 
            this.checkInDate.AutoSize = true;
            this.checkInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDate.Location = new System.Drawing.Point(20, 83);
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.Size = new System.Drawing.Size(129, 20);
            this.checkInDate.TabIndex = 1;
            this.checkInDate.Text = "Check-in Date";
            this.checkInDate.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkOutDate
            // 
            this.checkOutDate.AutoSize = true;
            this.checkOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutDate.Location = new System.Drawing.Point(229, 83);
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.Size = new System.Drawing.Size(140, 20);
            this.checkOutDate.TabIndex = 3;
            this.checkOutDate.Text = "Check-out Date";
            // 
            // rooms
            // 
            this.rooms.AutoSize = true;
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.Location = new System.Drawing.Point(20, 185);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(67, 20);
            this.rooms.TabIndex = 5;
            this.rooms.Text = "Rooms";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(24, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(51, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // adults
            // 
            this.adults.AutoSize = true;
            this.adults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adults.Location = new System.Drawing.Point(129, 185);
            this.adults.Name = "adults";
            this.adults.Size = new System.Drawing.Size(62, 20);
            this.adults.TabIndex = 7;
            this.adults.Text = "Adults";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(133, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(51, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // children
            // 
            this.children.AutoSize = true;
            this.children.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.children.Location = new System.Drawing.Point(238, 185);
            this.children.Name = "children";
            this.children.Size = new System.Drawing.Size(79, 20);
            this.children.TabIndex = 9;
            this.children.Text = "Children";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox3.Location = new System.Drawing.Point(242, 218);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 24);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType.Location = new System.Drawing.Point(20, 281);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(103, 20);
            this.roomType.TabIndex = 11;
            this.roomType.Text = "Room Type";
            this.roomType.Click += new System.EventHandler(this.label7_Click);
            // 
            // bedType
            // 
            this.bedType.AutoSize = true;
            this.bedType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedType.Location = new System.Drawing.Point(242, 281);
            this.bedType.Name = "bedType";
            this.bedType.Size = new System.Drawing.Size(88, 20);
            this.bedType.TabIndex = 14;
            this.bedType.Text = "Bed Type";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Double",
            "Single"});
            this.comboBox4.Location = new System.Drawing.Point(242, 314);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(88, 24);
            this.comboBox4.TabIndex = 15;
            // 
            // guestName
            // 
            this.guestName.AutoSize = true;
            this.guestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestName.Location = new System.Drawing.Point(21, 403);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(113, 20);
            this.guestName.TabIndex = 16;
            this.guestName.Text = "Guest Name";
            this.guestName.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbxGuestName
            // 
            this.tbxGuestName.Location = new System.Drawing.Point(24, 426);
            this.tbxGuestName.Name = "tbxGuestName";
            this.tbxGuestName.Size = new System.Drawing.Size(166, 22);
            this.tbxGuestName.TabIndex = 17;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(21, 464);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(132, 20);
            this.phoneNumber.TabIndex = 18;
            this.phoneNumber.Text = "Phone Number";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(24, 487);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(166, 22);
            this.tbxPhoneNumber.TabIndex = 19;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(21, 521);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(56, 20);
            this.email.TabIndex = 20;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(24, 544);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(167, 22);
            this.tbxEmail.TabIndex = 21;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(21, 580);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(78, 20);
            this.address.TabIndex = 22;
            this.address.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(24, 603);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(270, 109);
            this.tbxAddress.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 725);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Postal Code";
            // 
            // tbxPostalCode
            // 
            this.tbxPostalCode.Location = new System.Drawing.Point(24, 749);
            this.tbxPostalCode.Name = "tbxPostalCode";
            this.tbxPostalCode.Size = new System.Drawing.Size(166, 22);
            this.tbxPostalCode.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 790);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Country";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(25, 813);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.Size = new System.Drawing.Size(166, 22);
            this.tbxCountry.TabIndex = 27;
            // 
            // paymentType
            // 
            this.paymentType.AutoSize = true;
            this.paymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentType.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.paymentType.Location = new System.Drawing.Point(376, 403);
            this.paymentType.Name = "paymentType";
            this.paymentType.Size = new System.Drawing.Size(127, 20);
            this.paymentType.TabIndex = 28;
            this.paymentType.Text = "Payment Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(380, 440);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 21);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cash";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(380, 468);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(100, 21);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Credit Card";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cardholderName
            // 
            this.cardholderName.AutoSize = true;
            this.cardholderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardholderName.Location = new System.Drawing.Point(377, 506);
            this.cardholderName.Name = "cardholderName";
            this.cardholderName.Size = new System.Drawing.Size(155, 20);
            this.cardholderName.TabIndex = 31;
            this.cardholderName.Text = "Cardholder Name";
            // 
            // tbxCardholderName
            // 
            this.tbxCardholderName.Location = new System.Drawing.Point(380, 529);
            this.tbxCardholderName.Name = "tbxCardholderName";
            this.tbxCardholderName.Size = new System.Drawing.Size(166, 22);
            this.tbxCardholderName.TabIndex = 32;
            // 
            // creditcardNumber
            // 
            this.creditcardNumber.AutoSize = true;
            this.creditcardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditcardNumber.Location = new System.Drawing.Point(376, 569);
            this.creditcardNumber.Name = "creditcardNumber";
            this.creditcardNumber.Size = new System.Drawing.Size(177, 20);
            this.creditcardNumber.TabIndex = 33;
            this.creditcardNumber.Text = "Credit Card Number";
            // 
            // tbxCreditCardNumber
            // 
            this.tbxCreditCardNumber.Location = new System.Drawing.Point(380, 592);
            this.tbxCreditCardNumber.Name = "tbxCreditCardNumber";
            this.tbxCreditCardNumber.Size = new System.Drawing.Size(166, 22);
            this.tbxCreditCardNumber.TabIndex = 34;
            // 
            // expiryDate
            // 
            this.expiryDate.AutoSize = true;
            this.expiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryDate.Location = new System.Drawing.Point(378, 630);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(107, 20);
            this.expiryDate.TabIndex = 35;
            this.expiryDate.Text = "Expiry Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(185, 872);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 34);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(380, 872);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 34);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Smoking",
            "Non-smoking"});
            this.checkedListBox1.Location = new System.Drawing.Point(24, 314);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(160, 48);
            this.checkedListBox1.TabIndex = 39;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // tbxCheckInDate
            // 
            this.tbxCheckInDate.Location = new System.Drawing.Point(24, 122);
            this.tbxCheckInDate.Name = "tbxCheckInDate";
            this.tbxCheckInDate.Size = new System.Drawing.Size(125, 22);
            this.tbxCheckInDate.TabIndex = 40;
            // 
            // tbxCheckOutDate
            // 
            this.tbxCheckOutDate.Location = new System.Drawing.Point(233, 122);
            this.tbxCheckOutDate.Name = "tbxCheckOutDate";
            this.tbxCheckOutDate.Size = new System.Drawing.Size(124, 22);
            this.tbxCheckOutDate.TabIndex = 41;
            // 
            // additionalRemark
            // 
            this.additionalRemark.AutoSize = true;
            this.additionalRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalRemark.Location = new System.Drawing.Point(377, 708);
            this.additionalRemark.Name = "additionalRemark";
            this.additionalRemark.Size = new System.Drawing.Size(162, 20);
            this.additionalRemark.TabIndex = 42;
            this.additionalRemark.Text = "Additional Remark";
            // 
            // tbxAdditionalRemark
            // 
            this.tbxAdditionalRemark.Location = new System.Drawing.Point(380, 731);
            this.tbxAdditionalRemark.Multiline = true;
            this.tbxAdditionalRemark.Name = "tbxAdditionalRemark";
            this.tbxAdditionalRemark.Size = new System.Drawing.Size(269, 109);
            this.tbxAdditionalRemark.TabIndex = 43;
            // 
            // tbxExpiryDate
            // 
            this.tbxExpiryDate.Location = new System.Drawing.Point(382, 653);
            this.tbxExpiryDate.Name = "tbxExpiryDate";
            this.tbxExpiryDate.Size = new System.Drawing.Size(164, 22);
            this.tbxExpiryDate.TabIndex = 44;
            this.tbxExpiryDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AddBooking1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 918);
            this.Controls.Add(this.tbxExpiryDate);
            this.Controls.Add(this.tbxAdditionalRemark);
            this.Controls.Add(this.additionalRemark);
            this.Controls.Add(this.tbxCheckOutDate);
            this.Controls.Add(this.tbxCheckInDate);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.tbxCreditCardNumber);
            this.Controls.Add(this.creditcardNumber);
            this.Controls.Add(this.tbxCardholderName);
            this.Controls.Add(this.cardholderName);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.tbxCountry);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxPostalCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.address);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.tbxGuestName);
            this.Controls.Add(this.guestName);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.bedType);
            this.Controls.Add(this.roomType);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.children);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.adults);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.checkOutDate);
            this.Controls.Add(this.checkInDate);
            this.Controls.Add(this.addBooking);
            this.Name = "AddBooking1";
            this.Text = "AddBooking1";
            this.Load += new System.EventHandler(this.AddBooking1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addBooking;
        private System.Windows.Forms.Label checkInDate;
        private System.Windows.Forms.Label checkOutDate;
        private System.Windows.Forms.Label rooms;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label adults;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label children;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Label bedType;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label guestName;
        private System.Windows.Forms.TextBox tbxGuestName;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxPostalCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label paymentType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label cardholderName;
        private System.Windows.Forms.TextBox tbxCardholderName;
        private System.Windows.Forms.Label creditcardNumber;
        private System.Windows.Forms.TextBox tbxCreditCardNumber;
        private System.Windows.Forms.Label expiryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox tbxCheckInDate;
        private System.Windows.Forms.TextBox tbxCheckOutDate;
        private System.Windows.Forms.Label additionalRemark;
        private System.Windows.Forms.TextBox tbxAdditionalRemark;
        private System.Windows.Forms.TextBox tbxExpiryDate;
    }
}