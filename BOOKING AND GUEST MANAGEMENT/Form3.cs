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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
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
            newitem.SubItems.Add(textBox_CheckInDate.Text);
            newitem.SubItems.Add(textBox_CheckOutDate.Text);
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
    }
}
