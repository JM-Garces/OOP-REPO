using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Classes
{
    internal class NextForm
    {

        public NextForm(Form Current, Form NextForm)
        {
            Current.Hide();

            if (Current.WindowState == FormWindowState.Maximized)
            {
                NextForm.WindowState = FormWindowState.Maximized;
            }

            NextForm.ShowDialog();
            Current.Close();
        }
       
    }
}
