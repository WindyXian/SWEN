using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Swen_Assignment_3.Classes;
using System.Collections;

namespace Swen_Assignment_3.Schedule
{
    public partial class UpdateSchedule : Form
    {
        int schduleID;
        public UpdateSchedule(int scID)
        {
            InitializeComponent();
            schduleID = scID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScheduleI sc = new ScheduleI();
            sc.RoomID = schduleID;
            sc.EmployeeID = Convert.ToInt32(tbxEmployeeID.Text);
            sc.DateOfDuty = tbxDateOfDuty.Text;
            sc.Progress = tbxProgress.Text;

            ScheduleDBManager.UpdateSchedule(sc);
            MessageBox.Show("Schedule Updated");
            new MainPage().Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Schedule Update Cancelled");
            new RetrieveSchedule().Show();
            this.Hide();
        }

        private void UpdateSchedule_Load(object sender, EventArgs e)
        {

        }
    }
}
