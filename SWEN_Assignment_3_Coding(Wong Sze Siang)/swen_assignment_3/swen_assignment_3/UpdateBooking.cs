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
using System.Collections;

namespace swen_assignment_3
{
    public partial class UpdateBooking : Form
    {
        public int BookingID;
        public string GuestName;
        public string CheckInDate;
        public string CheckOutDate;
        public int NumberOfRooms;
        public int NumberOfAdults;
        public int NumberOfChildren;
        public int PhoneNumber;
        public string Email;
        public string Address;
        public int Postalcode;
        public string Country;
        public string AdditionalRemarks;
        public string RoomType;
        public string BedType;


        public UpdateBooking(int BookingID)
        {
            this.BookingID = BookingID; 
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Booking b = new Booking();
            b.BookingID = BookingID;
            b.GuestName = tbxGuestName.Text;
            b.CheckInDate = tbxUpdateCheckInDate.Text;
            b.CheckOutDate = tbxUpdateCheckOutDate.Text;
            b.NumberOfChildren = Convert.ToInt32(tbxUpdateNumberOfChildren.Text);
            b.NumberOfRooms = Convert.ToInt32(tbxUpdateRooms.Text);
            b.NumberOfAdults = Convert.ToInt32(tbxUpdateAdults.Text);
            b.PhoneNumber = Convert.ToInt32(tbxPhoneNumber.Text);
            b.Email = tbxEmail.Text;
            b.Address = tbxAddress.Text;
            b.PostalCode = Convert.ToInt32(tbxPostalCode.Text);
            b.Country = tbxCountry.Text;
            b.AdditionalRemarks = tbxAdditionalRemarks.Text;
            b.BedType = tbxBedType.Text;
            b.RoomType = tbxRoomType.Text;
          

            BookingDBManager.UpdateBooking(b);
            MessageBox.Show("Booking Updated");
            new MainBookingPage().Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Update Cancelled");
            new RetrieveBooking().Show();
            this.Hide();
        }

        private void UpdateBooking_Load(object sender, EventArgs e)
        {
            Booking updatest = new Booking();
            updatest = BookingDBManager.getGuestfromBookingID(BookingID);

            tbxUpdateCheckInDate.Text = Convert.ToString(updatest.CheckInDate);
            tbxUpdateCheckOutDate.Text = Convert.ToString(updatest.CheckOutDate);
            tbxUpdateRooms.Text = Convert.ToString(updatest.NumberOfRooms);
            tbxUpdateNumberOfChildren.Text = Convert.ToString(updatest.NumberOfChildren);
            tbxUpdateAdults.Text = Convert.ToString(updatest.NumberOfAdults);
            tbxPhoneNumber.Text = Convert.ToString(updatest.PhoneNumber);
            tbxCountry.Text = updatest.Country;
            tbxAddress.Text = updatest.Address;
            tbxEmail.Text = updatest.Email;
            tbxGuestName.Text = updatest.GuestName;
            tbxPostalCode.Text = Convert.ToString(updatest.PostalCode);
            tbxAdditionalRemarks.Text = updatest.AdditionalRemarks;
            tbxRoomType.Text = updatest.RoomType;
            tbxBedType.Text = updatest.BedType;
        }
    }
}
