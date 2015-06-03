using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swen_assignment_3
{
    public partial class MainBookingPage : Form
    {
        public MainBookingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddBooking().Show();
            this.Hide();
        }

        private void btnRetrieveBooking_Click(object sender, EventArgs e)
        {
            new RetrieveBooking().Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new AddPayment().Show();
            this.Hide();
        }
    }
}
