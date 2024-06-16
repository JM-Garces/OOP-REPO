using HotelManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Booking());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Booking());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new NextForm(this, new AddBooking());
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Report());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Report());
        }
    }
}
