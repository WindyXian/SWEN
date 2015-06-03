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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGetGuests_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(tbxDate.Text);
            ArrayList rms = HotelDB.GetAllGuestAndRoomFromDate(date.Date);

            StringBuilder list = new StringBuilder();
            dataGridView1.DataSource = rms;

            dataGridView1.Columns["Status"].Visible = false;
            dataGridView1.Columns["Floor"].Visible = false;



        }




    }
}
