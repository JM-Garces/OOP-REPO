using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class NavBar : Form
    {
        
        public NavBar()
        {
            InitializeComponent();
        }

        private void NavBar_Load(object sender, EventArgs e)
        {

        }

        private void NavBar_Load_1(object sender, EventArgs e)
        {
 
        }

        private void NavBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.dbContext?.Dispose();
            //this.dbContext = null;
        }
    }
}
