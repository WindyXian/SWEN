using Swen_Assignment_3.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swen_Assignment_3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new CreateSchedule().Show();
            this.Hide();
        }

        private void btnRetrieveSchedule_Click(object sender, EventArgs e)
        {
            new RetrieveSchedule().Show();
            this.Hide();
        }

        private void btnCreateStaffMain_Click(object sender, EventArgs e)
        {
            new CreateStaff().Show();
            this.Hide();
        }

        private void btnRetrieveStaffMain_Click(object sender, EventArgs e)
        {
            new RetrieveStaff().Show();
            this.Hide();
        }
    }
}
