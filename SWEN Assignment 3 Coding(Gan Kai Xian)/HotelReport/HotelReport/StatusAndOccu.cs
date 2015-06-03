using System;
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
    public partial class StatusAndOccu : Form
    {
        public StatusAndOccu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList al = HotelDB.GetAllRoomStatus();
            StringBuilder list = new StringBuilder();
            dataGridView1.DataSource = al;

            dataGridView1.Columns["Adult"].Visible = false;
            dataGridView1.Columns["Children"].Visible = false;
            dataGridView1.Columns["BookingID"].Visible = false;
            
        }

        private void btnOccupany_Click(object sender, EventArgs e)
        {
            tbxOutput.Clear();
            ArrayList rmOccu = new ArrayList();

            if (!string.IsNullOrWhiteSpace(tbxRmNum.Text))
            {
                rmOccu = HotelDB.GetOccupantNumbers(Convert.ToInt32(tbxRmNum.Text));
            }
            else if (!string.IsNullOrWhiteSpace(tbxBookingID.Text))
            {
                rmOccu = HotelDB.GetOccupantNumbersByID(Convert.ToInt32(tbxBookingID.Text));
            }
            
            foreach(Rooms rms in rmOccu)
            {
                tbxOutput.Text = "Number of Adults: "+ Convert.ToString(rms.Adult) +Environment.NewLine+"Number Children: " +rms.Children;
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllGuestsDate f3 = new AllGuestsDate();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f5 = new Login("Get Occupancy Report");
            f5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f5 = new Login("Get HouseKeeping Report");
            f5.ShowDialog();
        }

    }
}
