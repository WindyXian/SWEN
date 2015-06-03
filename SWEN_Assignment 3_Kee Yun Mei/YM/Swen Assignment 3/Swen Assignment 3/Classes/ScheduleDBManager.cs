using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseHelper;
using System.Collections;
using Swen_Assignment_3.Classes;

namespace Swen_Assignment_3.Classes
{
    class ScheduleDBManager
    {
        //Create Schedule
        public static bool AddSchedule(ScheduleI sc)
        {
            DatabaseInsertQuery newSchedule = new DatabaseInsertQuery("Schedule");
            newSchedule.AddData("EmployeeID", Convert.ToString(sc.EmployeeID));
            newSchedule.AddData("DateOfDuty", sc.DateOfDuty);
            newSchedule.AddData("Progress", sc.Progress);

            if (newSchedule.RunQuery())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Retrieve Individual Schedule
        public static ScheduleI generateSchedulefromRoomID(int RoomID)
        {
            ScheduleI sc = new ScheduleI();

            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Schedule");
            r.AddRestriction("RoomID", "=", Convert.ToString(RoomID));
            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                sc.EmployeeID = (int)dr["Employeeid"];
                sc.DateOfDuty = (string)dr["DateOfDuty"];
                sc.Progress = (string)dr["Progress"];
            }
            return sc;
        }

        //Retrieve All Schedule
        public static ArrayList getAllSchedule()
        {
            ArrayList al = new ArrayList();
            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Schedule");

            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                ScheduleI sc = new ScheduleI();
                sc.RoomID= (int)dr["roomid"];
                sc.EmployeeID = (int)dr["employeeid"];
                sc.DateOfDuty = (string)dr["dateofduty"];
                sc.Progress = (string)dr["progress"];
                al.Add(sc);
            }
            return al;
        }

        //Update Schedule
        public static Boolean UpdateSchedule(ScheduleI cc)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Schedule", "RoomID=" + cc.RoomID);

            r.AddData("EmployeeID", Convert.ToString(cc.EmployeeID));
            r.AddData("DateOfDuty", Convert.ToString(cc.DateOfDuty));
            r.AddData("Progress", Convert.ToString(cc.Progress));
            return r.RunQuery();
        }

        //Delete Schedule
        public static Boolean DeleteSchedule(int RoomID)
        {
            DatabaseDeleteQuery gudigudi = new DatabaseDeleteQuery("Schedule", "RoomID= " + RoomID);
            return gudigudi.RunQuery();

        }
    }
}
