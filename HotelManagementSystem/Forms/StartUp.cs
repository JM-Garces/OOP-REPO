using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SQLite;
using HotelManagementSystem.Classes;

namespace HotelManagementSystem
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Loggin in...");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/jm.a.garces");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/richardjason.aquino.1");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/dungeonhotel/home");
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Hotel Database.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                bool isValid = true;

                if (string.IsNullOrWhiteSpace(textBox_username.Text))
                {
                    errorProviderusername.SetError(textBox_username, "Username is Required");
                }
                else
                {
                    errorProviderusername.SetError(textBox_username, string.Empty);
                }

                if (string.IsNullOrWhiteSpace(textBox_password.Text))
                {
                    errorProviderpass.SetError(textBox_password, "Password is Required");
                }
                else
                {
                    errorProviderpass.SetError(textBox_password, string.Empty);
                }

                if (isValid)
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM STAFF WHERE Username=@username AND Password=@password";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBox_password.Text.Trim());
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            conn.Close();
                            new NextForm(this, new MainMenu());
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
    }

}
