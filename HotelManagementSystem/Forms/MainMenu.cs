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
    public partial class MainMenu : Form
    {
        public MainMenu()
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
