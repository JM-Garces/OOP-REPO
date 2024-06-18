using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class NavBarControl : UserControl
    {
        private bool roomExpand = false;
        private bool billingExpand = false;
        private bool reportExpand = false;
        private bool menuExpand = false;
        private const int maxHeight = 240;
        private const int minHeight = 80;
        private const int step = 20;

        public NavBarControl()
        {
            InitializeComponent();
        }

        private void NavBarFlow_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom paint logic here
        }

        private void room_button_Click(object sender, EventArgs e)
        {
            room_timer.Start();
            if (billingExpand)
                billing_timer.Start();
            if (reportExpand)
                report_timer.Start();
            if (!menuExpand)
                menu_timer.Start();
        }

        private void menu_width_timer_Tick(object sender, EventArgs e)
        {
            if (!roomExpand)
            {
                if (menu_3.Height < maxHeight)
                {
                    menu_3.Height += step;
                }
                else
                {
                    menu_3.Height = maxHeight; // Ensure it does not exceed maxHeight
                    room_timer.Stop();
                    roomExpand = true;
                }
            }
            else
            {
                if (menu_3.Height > minHeight)
                {
                    menu_3.Height -= step;
                }
                else
                {
                    menu_3.Height = minHeight; // Ensure it does not go below minHeight
                    room_timer.Stop();
                    roomExpand = false;
                }
            }
        }

        private void billing_button_Click(object sender, EventArgs e)
        {
            billing_timer.Start();
            if (roomExpand)
                room_timer.Start();
            if (reportExpand)
                report_timer.Start();
            if (!menuExpand)
                menu_timer.Start();
        }

        private void billing_timer_Tick(object sender, EventArgs e)
        {
            if (!billingExpand)
            {
                if (menu_4.Height < maxHeight)
                {
                    menu_4.Height += step;
                }
                else
                {
                    menu_4.Height = maxHeight; // Ensure it does not exceed maxHeight
                    billing_timer.Stop();
                    billingExpand = true;
                }
            }
            else
            {
                if (menu_4.Height > minHeight)
                {
                    menu_4.Height -= step;
                }
                else
                {
                    menu_4.Height = minHeight; // Ensure it does not go below minHeight
                    billing_timer.Stop();
                    billingExpand = false;
                }
            }
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            report_timer.Start();
            if (roomExpand)
                room_timer.Start();
            if (billingExpand)
                billing_timer.Start();
            if (!menuExpand)
                menu_timer.Start();
        }

        private void report_timer_Tick(object sender, EventArgs e)
        {
            if (!reportExpand)
            {
                if (menu_5.Height < maxHeight)
                {
                    menu_5.Height += step;
                }
                else
                {
                    menu_5.Height = maxHeight; // Ensure it does not exceed maxHeight
                    report_timer.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                if (menu_5.Height > minHeight)
                {
                    menu_5.Height -= step;
                }
                else
                {
                    menu_5.Height = minHeight; // Ensure it does not go below minHeight
                    report_timer.Stop();
                    reportExpand = false;
                }
            }
        }

        private void button_hamburger_Click(object sender, EventArgs e)
        {
            menu_timer.Start();
            if (roomExpand)
                room_timer.Start();
            if (billingExpand)
                billing_timer.Start();
            if (reportExpand)
                report_timer.Start();
            if (!menuExpand)
                menu_timer.Start();
        }

        private void menu_timer_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                if (NavBarFlow.Width < 345)
                {
                    NavBarFlow.Width += 50;
                }
                else
                {
                    NavBarFlow.Width = 345; // Ensure it does not exceed maxHeight
                    menu_timer.Stop();
                    menuExpand = true;
                }
            }

            else
            {
                if (NavBarFlow.Width > 100)
                {
                    NavBarFlow.Width -= 50;
                }
                else
                {
                    NavBarFlow.Width = 100; // Ensure it does not go below minHeight
                    menu_timer.Stop();
                    menuExpand = false;
                }
            }
        }
    }
}
