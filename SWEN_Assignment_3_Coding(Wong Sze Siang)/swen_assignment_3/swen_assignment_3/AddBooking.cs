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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxGuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.CheckInDate = tbxCheckInDate.Text;
            b.CheckOutDate = tbxCheckOutDate.Text;
            b.NumberOfChildren = Convert.ToInt32(cbxChildren.SelectedIndex.ToString());
            b.NumberOfRooms = Convert.ToInt32(cbxRooms.SelectedIndex.ToString());
            b.NumberOfAdults = Convert.ToInt32(cbxAdults.SelectedIndex.ToString());
            b.PhoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            b.Country = tbxCountry.Text;
            b.Address = tbxAddress.Text;
            b.Email = tbxEmail.Text;
            b.GuestName = tbxGuestName.Text;
            b.PostalCode = Convert.ToInt32(tbxPostalCode.Text);
            b.AdditionalRemarks = tbxAdditionalRemarks.Text;
            b.RoomType = cbxRoomType.Text;
            b.BedType = cbxBedType.Text;
            BookingDBManager.AddBooking(b);
            MessageBox.Show("Booking Created! :)");
            new MainBookingPage().Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Cancelled! :(");
            new MainBookingPage().Show();
            this.Hide();
        }
    }
}
