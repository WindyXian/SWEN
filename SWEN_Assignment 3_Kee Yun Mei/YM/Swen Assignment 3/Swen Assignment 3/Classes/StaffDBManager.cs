using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseHelper;
using System.Collections;

namespace Swen_Assignment_3.Classes
{
    class StaffDBManager
    {
        //Create Staff
        public static bool AddStaff(Staff s)
        {
            DatabaseInsertQuery newStaff = new DatabaseInsertQuery("staff");
            newStaff.AddData("StaffName", s.StaffName);
            newStaff.AddData("DOB", s.DateOfBirth);
            newStaff.AddData("BankAccount", Convert.ToString(s.BankAccount));
            newStaff.AddData("StaffAddress", s.StaffAddress);
            newStaff.AddData("StaffPhoneNumber", Convert.ToString(s.StaffPhoneNumber));
            newStaff.AddData("Duty", s.Duty);

            if (newStaff.RunQuery())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Retrieve Individual Staff
        public static Staff generateStafffromEmployeeID(int EmployeeID)
        {
            Staff s = new Staff();

            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Staff");
            r.AddRestriction("employeeid", "=", Convert.ToString(EmployeeID));
            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                s.StaffName = (string)dr["staffname"];
                s.DateOfBirth = (string)dr["DOB"];
                s.BankAccount = (int)dr["bankaccount"];
                s.StaffAddress = (string)dr["staffaddress"];
                s.StaffPhoneNumber = (int)dr["staffphonenumber"];
                s.Duty = (string)dr["duty"];
            }
            return s;
        }

        //Retrieve All Staff
        public static ArrayList getAllStaff()
        {
            ArrayList sa = new ArrayList();
            DatabaseRetriveQuery r = new DatabaseRetriveQuery("Staff");
            
            SqlDataReader dr = r.RunQuery();
            while (dr.Read())
            {
                Staff s = new Staff();
                s.EmployeeID = (int)dr["employeeid"];
                s.StaffName = (string)dr["staffname"];
                s.DateOfBirth = (string)dr["DOB"];
                s.BankAccount = (int)dr["bankaccount"];
                s.StaffAddress = (string)dr["staffaddress"];
                s.StaffPhoneNumber = (int)dr["staffphonenumber"];
                s.Duty = (string)dr["duty"];
                sa.Add(s);
            }
            return sa;
        }

        //Update Staff
        public static Boolean UpdateStaff(Staff cb)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Staff", "EmployeeID="+cb.EmployeeID);
            
            r.AddData("StaffName", Convert.ToString(cb.StaffName));
            r.AddData("DOB", Convert.ToString(cb.DateOfBirth));
            r.AddData("BankAccount", Convert.ToString(cb.BankAccount));
            r.AddData("StaffAddress", Convert.ToString(cb.StaffAddress));
            r.AddData("StaffPhoneNumber", Convert.ToString(cb.StaffPhoneNumber));
            r.AddData("Duty", Convert.ToString(cb.Duty));
            return r.RunQuery();
        }

        //Delete Staff
        public static Boolean DeleteStaff(int employeeid)
        {
            DatabaseDeleteQuery gudigudi = new DatabaseDeleteQuery("Staff","EmployeeID= "+employeeid);
            return gudigudi.RunQuery();

        }
    }
}
