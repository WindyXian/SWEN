using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;

namespace HotelReport
{
    public partial class OccupancyReport : Form
    {
        public OccupancyReport()
        {
            InitializeComponent();
        }

        

        //Get Stats by day
        private void btnDay_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxStrtDate.Text);
            double totalPercentage;
            double totalCount =0;
            int flr2Count = 0;
            int flr3Count = 0;

            //Retrieve all the data
            ArrayList rmC = HotelDB.GetStatsByDay(date.Date);
            ArrayList rmByFlr2 = HotelDB.GetFloor2StatsByDay(date.Date);
            ArrayList rmByFlr3 = HotelDB.GetFloor3StatsByDay(date.Date);

            //Store for total room count
            foreach (RoomCounts rc in rmC)
            {
                totalCount = rc.TotalCount;
            }
            //Store for total floor count on 2nd floor
            foreach (RoomCounts rc in rmByFlr2)
            {
                flr2Count = rc.PerFloorCount;
            }
            //Store for total floor count on 3nd floor
            foreach (RoomCounts rc in rmByFlr3)
            {
                flr3Count = rc.PerFloorCount;
            }
            //Calculate percentage of total room occupied
            totalPercentage = ((totalCount/20)*100);
            //Display report
            tbxOutput.Text = "Total Room Count: " + totalCount + Environment.NewLine 
                + "Total Percentage of Rooms Occupied: " + totalPercentage +"%"+Environment.NewLine
                + "Total Number of Guests in 2nd Floor: "+flr2Count +Environment.NewLine
                +"Total Number of Guests in 3rd Floor: "+ flr3Count;
        }

        //Get Stats by week
        private void btnWeek_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxStrtDate.Text);
            double totalPercentage;
            double totalCount = 0;
            int flr2Count = 0;
            int flr3Count = 0;

            CultureInfo cul = CultureInfo.CurrentCulture;
            //int num = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
            int num = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

            //Retrieve all the data
            ArrayList rmC = HotelDB.GetStatsByWeek(num, date.Year);
            ArrayList rmByFlr2 = HotelDB.GetFloor2StatsByWeek(num, date.Year);
            ArrayList rmByFlr3 = HotelDB.GetFloor3StatsByWeek(num, date.Year);

            //Store for total room count
            foreach (RoomCounts rc in rmC)
            {
                totalCount = rc.TotalCount;
            }
            //Store for total floor count on 2nd floor
            foreach (RoomCounts rc in rmByFlr2)
            {
                flr2Count = rc.PerFloorCount;
            }
            //Store for total floor count on 3nd floor
            foreach (RoomCounts rc in rmByFlr3)
            {
                flr3Count = rc.PerFloorCount;
            }
            //Calculate percentage of total room occupied
            totalPercentage = ((totalCount / 20) * 100);
            //Display report
            tbxOutput.Text = "Total Room Count: " + totalCount + Environment.NewLine
                + "Total Percentage of Rooms Occupied: " + totalPercentage + "%" + Environment.NewLine
                + "Total Number of Guests in 2nd Floor: " + flr2Count + Environment.NewLine
                + "Total Number of Guests in 3rd Floor: " + flr3Count;
        }

        //Get Stats by month
        private void btnMonth_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxStrtDate.Text);
            double totalPercentage;
            double totalCount = 0;
            int flr2Count = 0;
            int flr3Count = 0;

            //Retrieve all the data
            ArrayList rmC = HotelDB.GetStatsByMonth(date);
            ArrayList rmByFlr2 = HotelDB.GetFloor2StatsByMonth(date);
            ArrayList rmByFlr3 = HotelDB.GetFloor3StatsByMonth(date);

            //Store for total room count
            foreach (RoomCounts rc in rmC)
            {
                totalCount = rc.TotalCount;
            }
            //Store for total floor count on 2nd floor
            foreach (RoomCounts rc in rmByFlr2)
            {
                flr2Count = rc.PerFloorCount;
            }
            //Store for total floor count on 3nd floor
            foreach (RoomCounts rc in rmByFlr3)
            {
                flr3Count = rc.PerFloorCount;
            }
            //Calculate percentage of total room occupied
            totalPercentage = ((totalCount / 20) * 100);
            //Display report
            tbxOutput.Text = "Total Room Count: " + totalCount + Environment.NewLine
                + "Total Percentage of Rooms Occupied: " + totalPercentage + "%" + Environment.NewLine
                + "Total Number of Guests in 2nd Floor: " + flr2Count + Environment.NewLine
                + "Total Number of Guests in 3rd Floor: " + flr3Count;
        }

        //Get Stats by year
        private void btnYear_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxStrtDate.Text);
            double totalPercentage;
            double totalCount = 0;
            int flr2Count = 0;
            int flr3Count = 0;

            //Retrieve all the data
            ArrayList rmC = HotelDB.GetStatsByYear(date);
            ArrayList rmByFlr2 = HotelDB.GetFloor2StatsByYear(date);
            ArrayList rmByFlr3 = HotelDB.GetFloor3StatsByYear(date);

            //Store for total room count
            foreach (RoomCounts rc in rmC)
            {
                totalCount = rc.TotalCount;
            }
            //Store for total floor count on 2nd floor
            foreach (RoomCounts rc in rmByFlr2)
            {
                flr2Count = rc.PerFloorCount;
            }
            //Store for total floor count on 3nd floor
            foreach (RoomCounts rc in rmByFlr3)
            {
                flr3Count = rc.PerFloorCount;
            }
            //Calculate percentage of total room occupied
            totalPercentage = ((totalCount / 20) * 100);
            //Display report
            tbxOutput.Text = "Total Room Count: " + totalCount + Environment.NewLine
                + "Total Percentage of Rooms Occupied: " + totalPercentage + "%" + Environment.NewLine
                + "Total Number of Guests in 2nd Floor: " + flr2Count + Environment.NewLine
                + "Total Number of Guests in 3rd Floor: " + flr3Count;
        }

        






    }
}
