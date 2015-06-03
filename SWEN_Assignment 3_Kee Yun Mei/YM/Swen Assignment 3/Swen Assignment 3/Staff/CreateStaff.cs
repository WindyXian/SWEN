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
    public partial class CreateStaff : Form
    {
        public CreateStaff()
        {
            InitializeComponent();
        }

        private void lblStaffName_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateStaff_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.StaffName = tbxStaffName.Text;
            s.DateOfBirth = tbxStaffDOB.Text;
            s.BankAccount = Convert.ToInt32(tbxBankAccount.Text);
            s.StaffAddress = tbxStaffAddress.Text;
            s.StaffPhoneNumber = Convert.ToInt32(tbxStaffPhoneNumber.Text);
            s.Duty = cbbDuty.Text;
            StaffDBManager.AddStaff(s);
            MessageBox.Show("Staff Created");
            new MainPage().Show();
            this.Hide();
        }

        private void btnCancelStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel Create Staff");
            new MainPage().Show();
            this.Hide();
        }

        private void cbbDuty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
