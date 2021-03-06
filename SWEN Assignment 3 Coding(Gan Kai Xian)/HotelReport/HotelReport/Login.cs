﻿using System;
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

namespace HotelReport
{
    public partial class Login : Form
    {
        public Login(string info)
        {
            InitializeComponent();
            label3.Text = info;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(tbxUser.Text);
            string info ="";

            ArrayList logInfo = HotelDB.GetLoginInfo(Convert.ToInt32(tbxUser.Text), tbxPass.Text);
            foreach(ReportLogin rl in logInfo)
            {
               info  = rl.Type;
            }
            if (label3.Text == "Get Occupancy Report")
            {
                if(info  =="Administrator")
                {
                    OccupancyReport f2 = new OccupancyReport();
                    f2.ShowDialog();
                }
                else if (info  =="Management")
                {
                    OccupancyReport f2 = new OccupancyReport();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not an Administrator or Management user, try again.");
                }
            }
            else if(label3.Text=="Get HouseKeeping Report")
            {
                if (info == "Administrator")
                {
                    HousekeepingReport f4 = new HousekeepingReport();
                    f4.ShowDialog();
                }
                else if (info == "Management")
                {
                    HousekeepingReport f4 = new HousekeepingReport();
                    f4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not an Administrator or Management user, try again.");
                }
            }

        }

        


    }
}
