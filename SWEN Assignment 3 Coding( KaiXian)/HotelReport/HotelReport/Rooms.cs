using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelReport
{
    class Rooms
    {
        private int roomNum;
        private string roomType;
        private int floor;
        private string status;
        private int bookingID;
        private int adult;
        private int children;

        public int RoomNum
        {
            get { return roomNum; }
            set { roomNum = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public int Adult
        {
            get { return adult; }
            set { adult = value; }
        }

        public int Children
        {
            get { return children; }
            set { children = value; }
        }


    }
}
