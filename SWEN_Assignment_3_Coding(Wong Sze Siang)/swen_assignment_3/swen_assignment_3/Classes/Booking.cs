using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swen_assignment_3.Classes
{
    class Booking
    {
        public int BookingID { get; set; }
        public int PaymentID { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string GuestName { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string AdditionalRemarks { get; set; }
        public string RoomType { get; set; }
        public string BedType { get; set; }

        public Booking() { }

        public Booking(int BookingID, int PaymentID, string CheckInDate, string CheckOutDate, string GuestName, int NumberOfRooms, int NumberOfAdults, int NumberofChildren, int PhoneNumber, string Email, string Address, int PostalCode, string Country, string AdditionalRemarks, string RoomType, string BedType)
        {
            this.BookingID = BookingID;
            this.PaymentID = PaymentID;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
            this.GuestName = GuestName;
            this.NumberOfRooms = NumberOfRooms;
            this.NumberOfAdults = NumberOfAdults;
            this.NumberOfChildren = NumberOfChildren;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.AdditionalRemarks = AdditionalRemarks;
            this.RoomType = RoomType;
            this.BedType = BedType;
        }
    }
}
