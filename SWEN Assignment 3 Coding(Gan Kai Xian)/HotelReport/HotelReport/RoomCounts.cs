using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReport
{
    class RoomCounts
    {
        private int perFloorCount;
        private int totalCount;

        public int PerFloorCount
        {
            get { return perFloorCount; }
            set { perFloorCount = value; }
        }

        public int TotalCount
        {
            get { return totalCount; }
            set { totalCount = value; }
        }


    }
}
