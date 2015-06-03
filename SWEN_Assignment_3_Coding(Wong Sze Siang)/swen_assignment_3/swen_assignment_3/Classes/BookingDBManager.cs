using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using DatabaseHelper;

namespace swen_assignment_3.Classes
{
    class BookingDBManager
    {
        //Create Booking
        public static bool AddBooking(Booking b)
        {
            DatabaseInsertQuery newBooking = new DatabaseInsertQuery("Booking");
            newBooking.AddData("CheckInDate", b.CheckInDate);
            newBooking.AddData("CheckOutDate", b.CheckOutDate);
            newBooking.AddData("GuestName", b.GuestName);
            newBooking.AddData("NumberOfRooms", Convert.ToString(b.NumberOfRooms));
            newBooking.AddData("NumberOfAdults", Convert.ToString(b.NumberOfAdults));
            newBooking.AddData("NumberOfChildren", Convert.ToString(b.NumberOfChildren));
            newBooking.AddData("PhoneNumber", Convert.ToString(b.PhoneNumber));
            newBooking.AddData("Email", b.Email);
            newBooking.AddData("Address", b.Address);
            newBooking.AddData("PostalCode", Convert.ToString(b.PostalCode));
            newBooking.AddData("Country", b.Country);
            newBooking.AddData("AdditionalRemarks", b.AdditionalRemarks);
            newBooking.AddData("RoomType", b.RoomType);
            newBooking.AddData("BedType", b.BedType);

            if (newBooking.RunQuery())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Retrieve Individual Guest
        public static Booking getGuestfromBookingID(int BookingID)
        {
            Booking b = new Booking();

            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Booking");
            r.AddRestriction("BookingID", "=", Convert.ToString(BookingID));
            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                b.BookingID = (int)dr["BookingID"];
                b.GuestName = (string)dr["GuestName"];
                b.CheckInDate = (string)dr["CheckInDate"];
                b.CheckOutDate = (string)dr["CheckOutDate"];
                b.NumberOfChildren = (int)dr["NumberOfChildren"];
                b.NumberOfAdults = (int)dr["NumberOfAdults"];
                b.NumberOfRooms = (int)dr["NumberOfRooms"];
                b.PhoneNumber = (int)dr["PhoneNumber"];
                b.Email = (string)dr["Email"];
                b.Address = (string)dr["Address"];
                b.PostalCode = (int)dr["PostalCde"];
                b.Country = (string)dr["Country"];
                b.AdditionalRemarks = (string)dr["AdditionalRemarks"];
                b.RoomType = (string)dr["RoomType"];
                b.BedType = (string)dr["BedType"];
            }
            return b;
        }

        //Retrieve All Staff
        public static ArrayList getAllGuest()
        {
            ArrayList sa = new ArrayList();
            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Booking");

            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                Booking b = new Booking();
                b.BookingID = (int)dr["BookingID"];
                b.GuestName = (string)dr["GuestName"];
                b.CheckInDate = (string)dr["CheckInDate"];
                b.CheckOutDate = (string)dr["CheckOutDate"];
                b.NumberOfChildren = (int)dr["NumberOfChildren"];
                b.NumberOfAdults = (int)dr["NumberOfAdults"];
                b.NumberOfRooms = (int)dr["NumberOfRooms"];
                b.PhoneNumber = (int)dr["PhoneNumber"];
                b.Email = (string)dr["Email"];
                b.Address = (string)dr["Address"];
                b.PostalCode = (int)dr["PostalCode"];
                b.Country = (string)dr["Country"];
                b.AdditionalRemarks = (string)dr["AdditionalRemarks"];
                b.RoomType = (string)dr["RoomType"];
                b.BedType = (string)dr["BedType"];
                sa.Add(b);
            }
            return sa;
        }

        //Update Booking
        public static Boolean UpdateBooking(Booking ub)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Booking", "BookingID=" + ub.BookingID);

            r.AddData("GuestName", Convert.ToString(ub.GuestName));
            r.AddData("CheckInDate", Convert.ToString(ub.CheckInDate));
            r.AddData("CheckOutDate", Convert.ToString(ub.CheckOutDate));
            r.AddData("NumberOfRooms", Convert.ToString(ub.NumberOfRooms));
            r.AddData("NumberOfAdults", Convert.ToString(ub.NumberOfAdults));
            r.AddData("NumberOfChildren", Convert.ToString(ub.NumberOfChildren));
            r.AddData("Email", Convert.ToString(ub.Email));
            r.AddData("Address", Convert.ToString(ub.Address));
            r.AddData("PostalCode", Convert.ToString(ub.PostalCode));
            r.AddData("Country", Convert.ToString(ub.Country));
            r.AddData("AdditionalRemarks", Convert.ToString(ub.AdditionalRemarks));
            r.AddData("RoomType", Convert.ToString(ub.RoomType));
            r.AddData("BedType", Convert.ToString(ub.BedType));
            return r.RunQuery();
        }

        //Delete Booking
        public static Boolean DeleteBooking(int BookingID)
        {
            DatabaseDeleteQuery r = new DatabaseDeleteQuery("Booking", "BookingID= " + BookingID);
            return r.RunQuery();
        }

    }
}
