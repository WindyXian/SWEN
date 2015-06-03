using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SWEN_Assignment_3.Classes;

namespace SWEN_Assignment_3
{
    public partial class AddBooking1 : Form
    {
        public AddBooking1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBooking1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Cancel!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.NumberOfChildren = Convert.ToInt32(comboBox1.SelectedIndex.ToString());
            b.NumberOfRooms = Convert.ToInt32(comboBox2.SelectedIndex.ToString());
            b.NumberOfAdults = Convert.ToInt32(comboBox3.SelectedIndex.ToString());
            b.PhoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            b.Country = tbxCountry.Text;
            b.Address = tbxAddress.Text;
            b.Email = tbxEmail.Text;
            b.Name = tbxGuestName.Text;
            b.PostalCode = Convert.ToInt32(tbxPostalCode.Text);
            b.AdditionalRemarks = tbxAdditionalRemark.Text;
            Payment p = new Payment();
            p.ExpiryDate = Convert.ToInt32(tbxExpiryDate.Text);
            p.CardHolderName = tbxCardholderName.Text;
            p.CreditCardNumber = Convert.ToInt32(tbxCreditCardNumber.Text);
            MessageBox.Show("Booking Created!");
            new CheckOut().Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
