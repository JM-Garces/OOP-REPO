using HotelManagement.Classes;
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
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);  // --|   
            this.SetStyle(ControlStyles.DoubleBuffer, true);           //   |--- taga reduce nung flicker na white
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   |
            this.SetStyle(ControlStyles.UserPaint, true);              //   |
            this.UpdateStyles();                                       // --|
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
                    menu_3.Height = maxHeight; // para di lagpas
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
                    menu_3.Height = minHeight; // para di lagpas
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
                    menu_4.Height = maxHeight; // para di lagpas
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
                    menu_4.Height = minHeight; // para di lagpas
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
                    menu_5.Height = maxHeight; // para di lagpas
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
                    menu_5.Height = minHeight; // para di lagpas
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
                    this.Width += 50;
                    NavBarFlow.Width += 50;
                }
                else
                {
                    NavBarFlow.Width = 345; // para di lagpas
                    this.Width = 345;
                    menu_timer.Stop();
                    menuExpand = true;
                }
            }

            else
            {
                if (NavBarFlow.Width > 100)
                {
                    this.Width -= 50;
                    NavBarFlow.Width -= 50;
                }
                else
                {
                    NavBarFlow.Width = 100; // para di lagpas
                    this.Width = 100;
                    menu_timer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the current form
            Form currentForm = this.FindForm();
            new NextForm(currentForm, new Booking());
        }
    }
}
