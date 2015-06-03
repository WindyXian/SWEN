using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swen_Assignment_3.Classes
{
    class ScheduleI
    {
        public int RoomID { get; set; }
        public int EmployeeID { get; set; }
        public string DateOfDuty { get; set; }
        public string Progress { get; set; }

        public ScheduleI() { }

        public ScheduleI(int RoomID, int EmployeeID, string DateOfDuty, string Progress)
        {
            this.RoomID = RoomID;
            this.EmployeeID = EmployeeID;
            this.DateOfDuty = DateOfDuty;
            this.Progress = Progress;
        }
    }
}
