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

namespace Swen_Assignment_3
{
    public partial class RetrieveStaff : Form
    {
        public RetrieveStaff()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form n = new UpdateStaff(Convert.ToInt32(tbxRetrieveEmployeeID.Text));
           
            n.Show();
            this.Hide();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = StaffDBManager.getAllStaff();
            string output = "";

            foreach (Staff s in list)
            {
                if (s.EmployeeID == Convert.ToInt32(tbxRetrieveEmployeeID.Text))
                {
                    output += "Employee ID: " + s.EmployeeID + Environment.NewLine;
                    output += "Staff Name: " + s.StaffName + Environment.NewLine;
                    output += "Date Of Birth: " + s.DateOfBirth + Environment.NewLine;
                    output += "Bank Account: " + s.BankAccount + Environment.NewLine;
                    output += "Address: " + s.StaffAddress + Environment.NewLine;
                    output += "Phone Number: " + s.StaffPhoneNumber + Environment.NewLine;
                    output += "Duty: " + s.Duty + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = StaffDBManager.getAllStaff();
            string output = "";

            foreach (Staff s in list)
            {                
                {
                    output += "Employee ID: " + s.EmployeeID + Environment.NewLine;
                    output += "Staff Name: " + s.StaffName + Environment.NewLine;
                    output += "Date Of Birth: " + s.DateOfBirth + Environment.NewLine;
                    output += "Bank Account: " + s.BankAccount + Environment.NewLine;
                    output += "Address: " + s.StaffAddress + Environment.NewLine;
                    output += "Phone Number: " + s.StaffPhoneNumber + Environment.NewLine;
                    output += "Duty: " + s.Duty + Environment.NewLine + Environment.NewLine;
                }
                tbxOutput.Clear();
                tbxOutput.Text += output;
            }
        }

        private void btnCancelStaffRetrieve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Retrieval Cancelled");
            new MainPage().Show();
            this.Hide();
        }

        private void tbxRetrieveEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void RetrieveStaff_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if(StaffDBManager.DeleteStaff(Convert.ToInt32(tbxRetrieveEmployeeID.Text)))
            {
                MessageBox.Show("Staff Deleted");
            }
            else
            {
                MessageBox.Show("Could Not Delete Staff");
            }

            new MainPage().Show();
            this.Hide();
        }
    }
}
