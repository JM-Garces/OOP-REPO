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
    public partial class AddBooking : Form
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Booking());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 80);
            listView1.Columns.Add("Last Name", 100);
            listView1.Columns.Add("Middle Name", 100);
            listView1.Columns.Add("Suffix", 100);
            listView1.Columns.Add("E-Mail", 100);
            listView1.Columns.Add("Phone Number", 100);
            listView1.Columns.Add("Street Address", 100);
            listView1.Columns.Add("City", 100);
            listView1.Columns.Add("Province", 100);
            listView1.Columns.Add("Check-In Date", 100);
            listView1.Columns.Add("Check-Out Date",100);
            listView1.Columns.Add("Room Type", 100);
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            ListViewItem newitem = new ListViewItem(textBox_FirstName.Text);
            newitem.SubItems.Add(textBox_MiddleName.Text);
            newitem.SubItems.Add(textBox_LastName.Text);
            newitem.SubItems.Add(textBox_Suffix.Text);
            newitem.SubItems.Add(textBox_Email.Text);
            newitem.SubItems.Add(textBox_PhoneNumber.Text);
            newitem.SubItems.Add(textBox_StreetAddress.Text);
            newitem.SubItems.Add(textBox_City.Text);
            newitem.SubItems.Add(textBox_Province.Text);

            string CheckIn = $"{textBox_CheckInDate.Text} {ComboBoxStart.Text}";
            string CheckOut = $"{textBox_CheckOutDate.Text} {ComboBoxEnd.Text}";

            newitem.SubItems.Add(CheckIn);
            newitem.SubItems.Add(CheckOut);

            newitem.SubItems.Add(comboBox_RoomType.Text);

            listView1.Items.Add(newitem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_FirstName.Text = "";
            textBox_MiddleName.Text = "";
            textBox_LastName.Text = "";
            textBox_Suffix.Text = "";
            textBox_Email.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_StreetAddress.Text = "";
            textBox_City.Text = "";
            textBox_Province.Text = "";
            textBox_CheckInDate.Text = "";
            textBox_CheckOutDate.Text = "";
            comboBox_RoomType.Text = "";
            ComboBoxStart.Text = "";
            ComboBoxEnd.Text = "";
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox_FirstName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox_MiddleName.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox_LastName.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox_Suffix.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox_Email.Text = listView1.SelectedItems[0].SubItems[4].Text;
                textBox_PhoneNumber.Text = listView1.SelectedItems[0].SubItems[5].Text;
                textBox_StreetAddress.Text = listView1.SelectedItems[0].SubItems[6].Text;
                textBox_City.Text = listView1.SelectedItems[0].SubItems[7].Text;
                textBox_Province.Text = listView1.SelectedItems[0].SubItems[8].Text;
                textBox_CheckInDate.Text = listView1.SelectedItems[0].SubItems[9].Text;
                textBox_CheckOutDate.Text = listView1.SelectedItems[0].SubItems[10].Text;
                comboBox_RoomType.Text = listView1.SelectedItems[0].SubItems[11].Text;
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = textBox_FirstName.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox_MiddleName.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox_LastName.Text;
            listView1.SelectedItems[0].SubItems[3].Text = textBox_Suffix.Text;
            listView1.SelectedItems[0].SubItems[4].Text = textBox_Email.Text;
            listView1.SelectedItems[0].SubItems[5].Text = textBox_PhoneNumber.Text;
            listView1.SelectedItems[0].SubItems[6].Text = textBox_StreetAddress.Text;
            listView1.SelectedItems[0].SubItems[7].Text = textBox_City.Text;
            listView1.SelectedItems[0].SubItems[8].Text = textBox_Province.Text;
            listView1.SelectedItems[0].SubItems[9].Text = textBox_CheckInDate.Text;
            listView1.SelectedItems[0].SubItems[10].Text = textBox_CheckOutDate.Text;
            listView1.SelectedItems[0].SubItems[11].Text = comboBox_RoomType.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Booking());
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
            new NextForm(this, new Report());
        }

        // !!!
        // COPY START
        // !!!

        bool menuExpand_1 = false;
        bool menuExpand_2 = false;
        bool menuExpand_3 = false;
        bool menuExpand_4 = false;
        bool menuwidthexpand = false;

        private void menutransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand_1 == false)
            {
                menucontainer_booking.Height += 10;
                if (menucontainer_booking.Height >= 284)
                {
                    menutransition_1.Stop();
                    menuExpand_1 = true;
                }
            }
            else
            {
                menucontainer_booking.Height -= 15;
                if (menucontainer_booking.Height <= 123)
                {
                    menutransition_1.Stop();
                    menuExpand_1 = false;
                }
            }
        }

        private void menutransition_2_Tick(object sender, EventArgs e)
        {
            if (menuExpand_2 == false)
            {
                menucontainer_room.Height += 10;
                if (menucontainer_room.Height >= 284)
                {
                    menutransition_2.Stop();
                    menuExpand_2 = true;
                }
            }
            else
            {
                menucontainer_room.Height -= 15;
                if (menucontainer_room.Height <= 123)
                {
                    menutransition_2.Stop();
                    menuExpand_2 = false;
                }
            }
        }

        private void menutransition_3_Tick(object sender, EventArgs e)
        {
            if (menuExpand_3 == false)
            {
                menucontainer_billing.Height += 10;
                if (menucontainer_billing.Height >= 284)
                {
                    menutransition_3.Stop();
                    menuExpand_3 = true;
                }
            }
            else
            {
                menucontainer_billing.Height -= 15;
                if (menucontainer_billing.Height <= 123)
                {
                    menutransition_3.Stop();
                    menuExpand_3 = false;
                }
            }
        }

        private void menutransition_4_Tick(object sender, EventArgs e)
        {
            if (menuExpand_4 == false)
            {
                menucontainer_report.Height += 10;
                if (menucontainer_report.Height >= 284)
                {
                    menutransition_4.Stop();
                    menuExpand_4 = true;
                }
            }
            else
            {
                menucontainer_report.Height -= 15;
                if (menucontainer_report.Height <= 123)
                {
                    menutransition_4.Stop();
                    menuExpand_4 = false;
                }
            }
        }

        private void menuwidth_Tick(object sender, EventArgs e)
        {
            if (menuwidthexpand == false)
            {
                menu.Width += 30;
                if (menu.Width >= 345)
                {
                    menuwidth.Stop();
                    menuwidthexpand = true;
                }
            }
            else
            {
                menu.Width -= 30;
                if (menu.Width <= 105)
                {
                    menuwidth.Stop();
                    menuwidthexpand = false;
                }
            }
        }

        private void button_reports_Click(object sender, EventArgs e)
        {

        }

        private void room_Click(object sender, EventArgs e)
        {
            menutransition_2.Start();
            if (menuExpand_3 == true)
                menutransition_3.Start();
            if (menuExpand_4 == true)
                menutransition_4.Start();
            if (menuwidthexpand == false)
                menuwidth.Start();
        }

        private void billing_Click(object sender, EventArgs e)
        {
            menutransition_3.Start();
            if (menuExpand_2 == true)
                menutransition_2.Start();
            if (menuExpand_4 == true)
                menutransition_4.Start();
            if (menuwidthexpand == false)
                menuwidth.Start();
        }

        private void report_Click(object sender, EventArgs e)
        {
            menutransition_4.Start();
            if (menuExpand_2 == true)
                menutransition_2.Start();
            if (menuExpand_3 == true)
                menutransition_3.Start();
            if (menuwidthexpand == false)
                menuwidth.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (menuExpand_2 == true)
                menutransition_2.Start();
            if (menuExpand_3 == true)
                menutransition_3.Start();
            if (menuExpand_4 == true)
                menutransition_4.Start();
            menuwidth.Start();
        }
        private void NavBar_Load_1(object sender, EventArgs e)
        {

        }
        // !!!!
        //COPY END
        // !!!!
    }
}
