using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swen_Assignment_3
{
    class Staff
    {
        public int EmployeeID { get; set; }
        public string StaffName { get; set; }
        public string DateOfBirth { get; set; }
        public int BankAccount { get; set; }
        public string StaffAddress { get; set; }
        public int StaffPhoneNumber { get; set; }
        public string Duty { get; set; }

        public Staff() { }

        public Staff (int EmployeeID, string StaffName, string DateOfBirth, int BankAccount, string StaffAddress, int StaffPhoneNumber, string Duty)
        {
            this.EmployeeID = EmployeeID;
            this.StaffName = StaffName;
            this.DateOfBirth = DateOfBirth;
            this.BankAccount = BankAccount;
            this.StaffAddress = StaffAddress;
            this.StaffPhoneNumber = StaffPhoneNumber;
            this.Duty = Duty;
        }
    }
}
