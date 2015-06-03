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
    public partial class RetrieveSchedule : Form
    {
        public RetrieveSchedule()
        {
            InitializeComponent();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = ScheduleDBManager.getAllSchedule();
            string output = "";

            foreach (ScheduleI sc in list)
            {
                if (sc.RoomID == Convert.ToInt32(tbxRetrieveRoomID.Text))
                {
                    output += "Room ID: " + sc.RoomID + Environment.NewLine;
                    output += "Employee ID: " + sc.EmployeeID + Environment.NewLine;
                    output += "Date Of Duty: " + sc.DateOfDuty + Environment.NewLine;
                    output += "Progress: " + sc.Progress + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = ScheduleDBManager.getAllSchedule();
            string output = "";

            foreach (ScheduleI sc in list)
            {
                {
                    output += "Room ID: " + sc.RoomID + Environment.NewLine;
                    output += "Employee ID: " + sc.EmployeeID + Environment.NewLine;
                    output += "Date Of Duty: " + sc.DateOfDuty + Environment.NewLine;
                    output += "Progress: " + sc.Progress + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
             if(ScheduleDBManager.DeleteSchedule(Convert.ToInt32(tbxRetrieveRoomID.Text)))
            {
                MessageBox.Show("Schedule Deleted");
            }
            else
            {
                MessageBox.Show("Could Not Delete Schedule");
            }

            new MainPage().Show();
            this.Hide();
        }

        private void btnCancelScheduleRetrieve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Back to mainpage");
            new MainPage().Show();
            this.Hide();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            new UpdateSchedule(Convert.ToInt32(tbxRetrieveRoomID.Text)).Show();
            this.Hide();
        }

        private void RetrieveSchedule_Load(object sender, EventArgs e)
        {

        }
     }
}
