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
    public partial class UpdateStaff : Form
    {
        public int StaffID ;
        public string staffname;
        public string dob;
        public int bankacc;
        public string addr;
        public int pn;
        public string duty;
        public int empid;

        public UpdateStaff(int staffid)
        {
            this.StaffID = staffid;
            InitializeComponent();
            
        }

        private void btnCancelUpdateStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff Update Cancelled");
            new RetrieveStaff().Show();
            this.Hide();
        }

        private void btnUpdatedStaff_Click(object sender, EventArgs e)
        {

            Staff s = new Staff();
            s.EmployeeID = StaffID;
            s.StaffName= tbxStaffName.Text ;
            s.DateOfBirth = (tbxStaffDOB.Text); 
            s.BankAccount = Convert.ToInt32(tbxBankAccount.Text) ;
            s.StaffAddress = tbxStaffAddress.Text ;
            s.StaffPhoneNumber = Convert.ToInt32(tbxStaffPhoneNumber.Text );
            s.Duty = cbbDuty.Text;
            
            StaffDBManager.UpdateStaff(s);
            MessageBox.Show("Staff Updated");
            new MainPage().Show();
            this.Hide();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            Staff updatest = new Staff();
            updatest = StaffDBManager.generateStafffromEmployeeID(StaffID);

            tbxStaffName.Text = Convert.ToString(updatest.StaffName);
            tbxStaffDOB.Text = updatest.DateOfBirth;
            tbxBankAccount.Text = Convert.ToString(updatest.BankAccount);
            tbxStaffAddress.Text = updatest.StaffAddress;
            tbxStaffPhoneNumber.Text = Convert.ToString(updatest.StaffPhoneNumber);
            cbbDuty.Text = updatest.Duty;
        }

        
        }


    }

