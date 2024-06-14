using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace HotelManagementSystem
{
    public partial class Account_Verification : Form
    {
        public Account_Verification()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form temp = new Form1();
            if (this.WindowState == FormWindowState.Maximized)
            {
                temp.WindowState = FormWindowState.Maximized;
            }

            temp.ShowDialog();
            this.Close();
        }
    }

}
