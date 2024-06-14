using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Verification : Form
    {
        int[] POSSIBLE_VALUES = { 10, 20, 30 };
        Random rand = new Random();

        public Verification()
        {
            InitializeComponent();

        }

        private void Verification_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                
                int temp = progressBar1.Value + POSSIBLE_VALUES[rand.Next(0, POSSIBLE_VALUES.Length)];

                if (temp > 100)
                    progressBar1.Value = 100;
                else
                    progressBar1.Value = temp;

            }
            else
            {
                timer1.Stop();

                this.Hide();

                Form temp = new Account_Verification();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    temp.WindowState = FormWindowState.Maximized;
                }

                temp.ShowDialog();
                this.Close();
            }

        }

    }

}