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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Daily
        private void btnDailySchedule_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxDate.Text);

            //Retrieve all the data
            ArrayList dutySche = HotelDB.GetScheduleDaily(date.Date);

            //Display
            StringBuilder list = new StringBuilder();
            dataGridView1.DataSource = dutySche;
        }

        //Weekly
        private void btnWeeklySchedule_Click(object sender, EventArgs e)
        {
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxDate.Text);

            CultureInfo cul = CultureInfo.CurrentCulture;
            int num = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

            //Retrieve all the data
            ArrayList dutySche = HotelDB.GetScheduleWeekly(num, date.Year);

            //Display
            StringBuilder list = new StringBuilder();
            dataGridView1.DataSource = dutySche;


        }

        private void btnMonthlySchedule_Click(object sender, EventArgs e)
        {
            
            //State all the varieables
            DateTime date = Convert.ToDateTime(tbxDate.Text);

            //Retrieve all the data
            ArrayList dutySche = HotelDB.GetScheduleMonthly(date);

            //Display
            StringBuilder list = new StringBuilder();
            dataGridView1.DataSource = dutySche;
        }





    }
}
