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
    public partial class RetrieveBooking : Form
    {
        public RetrieveBooking()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            new MainBookingPage().Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form n = new UpdateBooking(Convert.ToInt32(tbxRetrieveBookingID.Text));

            n.Show();
            this.Hide();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = BookingDBManager.getAllGuest();
            string output = "";

            foreach (Booking b in list)
            {
                if (b.BookingID == Convert.ToInt32(tbxRetrieveBookingID.Text))
                {
                    output += "Booking ID: " + b.BookingID + Environment.NewLine;
                    output += "Guest Name: " + b.GuestName + Environment.NewLine;
                    output += "Check In Date: " + b.CheckInDate + Environment.NewLine;
                    output += "Check Out Date: " + b.CheckOutDate + Environment.NewLine;
                    output += "Number Of Rooms: " + b.NumberOfRooms + Environment.NewLine;
                    output += "Number Of Adults: " + b.NumberOfAdults + Environment.NewLine;
                    output += "Number Of Children: " + b.NumberOfChildren + Environment.NewLine;
                    output += "Email: " + b.Email + Environment.NewLine;
                    output += "Address: " + b.Address + Environment.NewLine;    
                    output += "Postal Code: " + b.PostalCode + Environment.NewLine;
                    output += "Country: " + b.Country + Environment.NewLine;
                    output += "Phone Number: " + b.PhoneNumber + Environment.NewLine;
                    output += "Room Type: " + b.RoomType + Environment.NewLine;
                    output += "Bed Type: " + b.BedType + Environment.NewLine;
                    output += "Additional Remarks: " + b.AdditionalRemarks + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = BookingDBManager.getAllGuest();
            string output = "";

            foreach (Booking b in list)
            {
                {
                    output += "Booking ID: " + b.BookingID + Environment.NewLine;
                    output += "Guest Name: " + b.GuestName + Environment.NewLine;
                    output += "Check In Date: " + b.CheckInDate + Environment.NewLine;
                    output += "Check Out Date: " + b.CheckOutDate + Environment.NewLine;
                    output += "Number Of Rooms: " + b.NumberOfRooms + Environment.NewLine;
                    output += "Number Of Adults: " + b.NumberOfAdults + Environment.NewLine;
                    output += "Number Of Children: " + b.NumberOfChildren + Environment.NewLine;
                    output += "Email: " + b.Email + Environment.NewLine;
                    output += "Address: " + b.Address + Environment.NewLine;
                    output += "Postal Code: " + b.PostalCode + Environment.NewLine;
                    output += "Country: " + b.Country + Environment.NewLine;
                    output += "Phone Number: " + b.PhoneNumber + Environment.NewLine;
                    output += "Room Type: " + b.RoomType + Environment.NewLine;
                    output += "Bed Type: " + b.BedType + Environment.NewLine;
                    output += "Additional Remarks: " + b.AdditionalRemarks + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(BookingDBManager.DeleteBooking(Convert.ToInt32(tbxRetrieveBookingID.Text)))
            {
                MessageBox.Show("Booking Deleted!");
            }
            else
            {
                MessageBox.Show("Could Not Delete Staff!");
            }

            new MainBookingPage().Show();
            this.Hide();
        }
    }
}
