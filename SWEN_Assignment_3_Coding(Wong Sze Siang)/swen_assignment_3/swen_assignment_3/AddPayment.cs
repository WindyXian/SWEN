using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using swen_assignment_3.Classes;

namespace swen_assignment_3
{
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.PaymentType = cbxPaymentType.Text;
            p.CreditCardNumber = Convert.ToInt32(tbxCreditCardNumber.Text);
            p.CardHolderName = tbxCardHolderName.Text;
            p.ExpiryDate = tbxExpiryDate.Text;
            p.Price = Convert.ToInt32(cbxPrice.Text);
            PaymentDBMananger.AddPayment(p);
            MessageBox.Show("Payment Successful!");
            new MainBookingPage().Show();
            this.Hide();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Unsuccessful!");
            new MainBookingPage().Show();
            this.Hide();
        }

        private void AddPaymentCC_Load(object sender, EventArgs e)
        {

        }

        private void lblCreditCardAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
