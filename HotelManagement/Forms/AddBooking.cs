using HotelManagement.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelManagement
{
    public partial class AddBooking : Form
    {
        private ErrorProvider errorProvider;
        public AddBooking()
        {
            InitializeComponent();
            InitializeValidation();
            errorProvider = new ErrorProvider();
        }

        private void InitializeValidation()
        {
            textBox_GRF.KeyPress += NumericTextBox_KeyPress;
            textBox_ContactNo.KeyPress += NumericTextBox_KeyPress;
            textBox_Age.KeyPress += NumericTextBox_KeyPress;
            textBox_ContactNoInCaseOfEmEmergency.KeyPress += NumericTextBox_KeyPress;
            textBox_No_Of_Days.KeyPress += NumericTextBox_KeyPress;
            textBox_Room_Number.KeyPress += NumericTextBox_KeyPress;
            textBox_Room_Rate.KeyPress += NumericTextBox_KeyPress;
            textBox_No_of_Guest.KeyPress += NumericTextBox_KeyPress;
            textBox_Amount.KeyPress += NumericTextBox_KeyPress;
            textBox_Discount.KeyPress += NumericTextBox_KeyPress;
            textBox_EmailAdd.Leave += TextBox_EmailAdd_Leave;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_EmailAdd_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox emailTextBox = sender as System.Windows.Forms.TextBox;
            if (emailTextBox != null)
            {
                if (!IsValidEmail(emailTextBox.Text))
                {
                    ShowValidationError(emailTextBox, "Please enter a valid email address.");
                }
                else
                {
                    errorProvider.SetError(emailTextBox, null);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidateInputs()
        {
            bool isValid = true;

            // Validate GRF No.
            if (!Regex.IsMatch(textBox_GRF.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_GRF, "GRF No. should only contain numbers.");
                isValid = false;
            }

            // Validate Contact No.
            if (!Regex.IsMatch(textBox_ContactNo.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_ContactNo, "Contact No. should only contain numbers.");
                isValid = false;
            }

            // Validate Email
            if (!Regex.IsMatch(textBox_EmailAdd.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ShowValidationError(textBox_EmailAdd, "Please enter a valid email address.");
                isValid = false;
            }

            // Validate Age
            if (!Regex.IsMatch(textBox_Age.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_Age, "Age should only contain numbers.");
                isValid = false;
            }

            // Validate Contact No. in Case of Emergency
            if (!Regex.IsMatch(textBox_ContactNoInCaseOfEmEmergency.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_ContactNoInCaseOfEmEmergency, "Contact No. in case of emergency should only contain numbers.");
                isValid = false;
            }

            // Validate No. of Days
            if (!Regex.IsMatch(textBox_No_Of_Days.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_No_Of_Days, "No. of Days should only contain numbers.");
                isValid = false;
            }

            // Validate Room No.
            if (!Regex.IsMatch(textBox_Room_Number.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_Room_Number, "Room No. should only contain numbers.");
                isValid = false;
            }

            // Validate Room Rate
            if (!Regex.IsMatch(textBox_Room_Rate.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_Room_Rate, "Room Rate should only contain numbers.");
                isValid = false;
            }

            // Validate No. of Guests
            if (!Regex.IsMatch(textBox_No_of_Guest.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_No_of_Guest, "No. of Guests should only contain numbers.");
                isValid = false;
            }

            // Validate Amount
            if (!Regex.IsMatch(textBox_Amount.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_Amount, "Amount should only contain numbers.");
                isValid = false;
            }

            // Validate Discount
            if (!Regex.IsMatch(textBox_Discount.Text, @"^\d+$"))
            {
                ShowValidationError(textBox_Discount, "Discount should only contain numbers.");
                isValid = false;
            }
            return isValid;
        }

        private void ShowValidationError(Control control, string errorMessage)
        {
            errorProvider.SetError(control, errorMessage);
            control.Focus();
        }

        // !!!
        // COPY START
        // !!!

        bool menuExpand_1 = false;
        bool menuExpand_2 = false;
        bool menuExpand_3 = false;
        bool menuExpand_4 = false;
        bool menuwidthexpand = false;

        private void NavBar_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_GRF.Text = "";
            textBox_GuestName.Text = "";
            textBox_ContactNo.Text = "";
            textBox_EmailAdd.Text = "";
            textBox_Age.Text = "";
            textBox_Person_to_Notify.Text = "";
            textBox_ContactNoInCaseOfEmEmergency.Text = "";
            textBox_HomeAdd.Text = "";
            comboBox_Hour.Text = "";
            comboBox_Minutes.Text = "";
            ComboBox_Am_Or_Pm1.Text = "";
            comboBox_Hour2.Text = "";
            comboBox_Minutes2.Text = "";
            ComboBox_Am_Or_Pm2.Text = "";
            textBox_No_Of_Days.Text = "";
            comboBox_RoomType.Text = "";
            textBox_Room_Number.Text = "";
            textBox_Remarks.Text = "";
            comboBox_Gender.Text = "";
            textBox_Room_Rate.Text = "";
            textBox_No_of_Guest.Text = "";
            textBox_Amount.Text = "";
            textBox_Discount.Text = "";


        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GRF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_EmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ContactNoInCaseOfEmEmergency_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Hour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Minutes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Am_Or_Pm1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Hour2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Am_Or_Pm2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_No_Of_Days_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Room_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Room_Rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_No_of_Guest_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_No_Click(object sender, EventArgs e)
        {

        }
        // !!!!
        //COPY END
        // !!!!
    }
}
