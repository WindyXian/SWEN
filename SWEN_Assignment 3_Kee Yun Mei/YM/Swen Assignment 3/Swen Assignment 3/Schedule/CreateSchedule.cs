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

namespace Swen_Assignment_3
{
    public partial class CreateSchedule : Form
    {
        public CreateSchedule()
        {
            InitializeComponent();
        }

        private void btnCreateSchedule_Click_1(object sender, EventArgs e)
        {
            ScheduleI sc = new ScheduleI();
            sc.EmployeeID = Convert.ToInt32(tbxEmployeeID.Text);
            sc.DateOfDuty = tbxDateOfDuty.Text;
            sc.Progress = lblInProgress.Text;
            ScheduleDBManager.AddSchedule(sc);
            MessageBox.Show("Schedule Created");
            new MainPage().Show();
            this.Hide();
        }

        private void btnCancelSchedule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel Create Schedule");
            new MainPage().Show();
            this.Hide();
        }
    }
}
