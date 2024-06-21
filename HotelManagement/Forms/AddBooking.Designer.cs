namespace HotelManagement
{
    partial class AddBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooking));
            menutransition_1 = new System.Windows.Forms.Timer(components);
            menutransition_2 = new System.Windows.Forms.Timer(components);
            menutransition_3 = new System.Windows.Forms.Timer(components);
            menutransition_4 = new System.Windows.Forms.Timer(components);
            menuwidth = new System.Windows.Forms.Timer(components);
            Check_InDate = new Label();
            Check_OutDate = new Label();
            Room_Type = new Label();
            comboBox_RoomType = new ComboBox();
            ComboBox_Am_Or_Pm1 = new ComboBox();
            ComboBox_Am_Or_Pm2 = new ComboBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            panel1 = new Panel();
            comboBox_Minutes2 = new ComboBox();
            comboBox_Minutes = new ComboBox();
            comboBox_Hour2 = new ComboBox();
            comboBox_Hour = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            textBox_Discount = new TextBox();
            textBox_Amount = new TextBox();
            Discount = new Label();
            Amount = new Label();
            textBox_No_of_Guest = new TextBox();
            No_Of_Guest = new Label();
            textBox_Room_Rate = new TextBox();
            room_Rate = new Label();
            comboBox_Gender = new ComboBox();
            combo_Box_Sex = new Label();
            textBox_Remarks = new TextBox();
            Remarks = new Label();
            textBox_Room_Number = new TextBox();
            Room_Number = new Label();
            textBox_No_Of_Days = new TextBox();
            NoOfDays = new Label();
            label15 = new Label();
            home_Address = new Label();
            textBox_HomeAdd = new TextBox();
            textBox_ContactNoInCaseOfEmEmergency = new TextBox();
            Contact_No_In_Case_of_Emergency = new Label();
            textBox_Person_to_Notify = new TextBox();
            person_to_Notify = new Label();
            incaseofemergency = new Label();
            textBox_Age = new TextBox();
            age = new Label();
            textBox_EmailAdd = new TextBox();
            textBox_ContactNo = new TextBox();
            email_Address = new Label();
            contact_No = new Label();
            textBox_GuestName = new TextBox();
            guest_Name = new Label();
            GRF_No = new Label();
            textBox_GRF = new TextBox();
            guest_Registration_Form_Header = new Label();
            guest_Registration_Form = new Label();
            navBarControl1 = new NavBarControl();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Check_InDate
            // 
            Check_InDate.AutoSize = true;
            Check_InDate.BackColor = Color.Transparent;
            Check_InDate.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check_InDate.ForeColor = Color.White;
            Check_InDate.Location = new Point(51, 832);
            Check_InDate.Name = "Check_InDate";
            Check_InDate.Size = new Size(181, 34);
            Check_InDate.TabIndex = 40;
            Check_InDate.Text = "Check-In Date :";
            // 
            // Check_OutDate
            // 
            Check_OutDate.AutoSize = true;
            Check_OutDate.BackColor = Color.Transparent;
            Check_OutDate.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Check_OutDate.ForeColor = Color.White;
            Check_OutDate.Location = new Point(51, 884);
            Check_OutDate.Name = "Check_OutDate";
            Check_OutDate.Size = new Size(199, 34);
            Check_OutDate.TabIndex = 42;
            Check_OutDate.Text = "Check-Out Date :";
            // 
            // Room_Type
            // 
            Room_Type.AutoSize = true;
            Room_Type.BackColor = Color.Transparent;
            Room_Type.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Room_Type.ForeColor = Color.White;
            Room_Type.Location = new Point(51, 985);
            Room_Type.Name = "Room_Type";
            Room_Type.Size = new Size(146, 34);
            Room_Type.TabIndex = 44;
            Room_Type.Text = "Room Type :";
            // 
            // comboBox_RoomType
            // 
            comboBox_RoomType.BackColor = SystemColors.ScrollBar;
            comboBox_RoomType.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_RoomType.FormattingEnabled = true;
            comboBox_RoomType.Items.AddRange(new object[] { "Single Bedroom", "Double Bedroom", "Twin Bedroom", "Triple Bedroom", "Family Bedroom" });
            comboBox_RoomType.Location = new Point(257, 983);
            comboBox_RoomType.Name = "comboBox_RoomType";
            comboBox_RoomType.Size = new Size(344, 32);
            comboBox_RoomType.TabIndex = 46;
            comboBox_RoomType.SelectedIndexChanged += comboBox_RoomType_SelectedIndexChanged;
            // 
            // ComboBox_Am_Or_Pm1
            // 
            ComboBox_Am_Or_Pm1.BackColor = SystemColors.ScrollBar;
            ComboBox_Am_Or_Pm1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox_Am_Or_Pm1.FormattingEnabled = true;
            ComboBox_Am_Or_Pm1.Items.AddRange(new object[] { "AM", "PM" });
            ComboBox_Am_Or_Pm1.Location = new Point(517, 832);
            ComboBox_Am_Or_Pm1.Name = "ComboBox_Am_Or_Pm1";
            ComboBox_Am_Or_Pm1.Size = new Size(84, 32);
            ComboBox_Am_Or_Pm1.TabIndex = 58;
            ComboBox_Am_Or_Pm1.SelectedIndexChanged += ComboBox_Am_Or_Pm1_SelectedIndexChanged;
            // 
            // ComboBox_Am_Or_Pm2
            // 
            ComboBox_Am_Or_Pm2.BackColor = SystemColors.ScrollBar;
            ComboBox_Am_Or_Pm2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox_Am_Or_Pm2.FormattingEnabled = true;
            ComboBox_Am_Or_Pm2.Items.AddRange(new object[] { "AM", "PM" });
            ComboBox_Am_Or_Pm2.Location = new Point(517, 884);
            ComboBox_Am_Or_Pm2.Name = "ComboBox_Am_Or_Pm2";
            ComboBox_Am_Or_Pm2.Size = new Size(84, 32);
            ComboBox_Am_Or_Pm2.TabIndex = 59;
            ComboBox_Am_Or_Pm2.SelectedIndexChanged += ComboBox_Am_Or_Pm2_SelectedIndexChanged;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(comboBox_Minutes2);
            panel1.Controls.Add(comboBox_Minutes);
            panel1.Controls.Add(comboBox_Hour2);
            panel1.Controls.Add(comboBox_Hour);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox_Discount);
            panel1.Controls.Add(textBox_Amount);
            panel1.Controls.Add(Discount);
            panel1.Controls.Add(Amount);
            panel1.Controls.Add(textBox_No_of_Guest);
            panel1.Controls.Add(No_Of_Guest);
            panel1.Controls.Add(textBox_Room_Rate);
            panel1.Controls.Add(room_Rate);
            panel1.Controls.Add(comboBox_Gender);
            panel1.Controls.Add(combo_Box_Sex);
            panel1.Controls.Add(textBox_Remarks);
            panel1.Controls.Add(Remarks);
            panel1.Controls.Add(textBox_Room_Number);
            panel1.Controls.Add(Room_Number);
            panel1.Controls.Add(textBox_No_Of_Days);
            panel1.Controls.Add(NoOfDays);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(home_Address);
            panel1.Controls.Add(textBox_HomeAdd);
            panel1.Controls.Add(textBox_ContactNoInCaseOfEmEmergency);
            panel1.Controls.Add(Contact_No_In_Case_of_Emergency);
            panel1.Controls.Add(textBox_Person_to_Notify);
            panel1.Controls.Add(person_to_Notify);
            panel1.Controls.Add(incaseofemergency);
            panel1.Controls.Add(ComboBox_Am_Or_Pm2);
            panel1.Controls.Add(Room_Type);
            panel1.Controls.Add(comboBox_RoomType);
            panel1.Controls.Add(textBox_Age);
            panel1.Controls.Add(ComboBox_Am_Or_Pm1);
            panel1.Controls.Add(Check_OutDate);
            panel1.Controls.Add(age);
            panel1.Controls.Add(textBox_EmailAdd);
            panel1.Controls.Add(textBox_ContactNo);
            panel1.Controls.Add(email_Address);
            panel1.Controls.Add(Check_InDate);
            panel1.Controls.Add(contact_No);
            panel1.Controls.Add(textBox_GuestName);
            panel1.Controls.Add(guest_Name);
            panel1.Controls.Add(GRF_No);
            panel1.Controls.Add(textBox_GRF);
            panel1.Controls.Add(guest_Registration_Form_Header);
            panel1.Controls.Add(guest_Registration_Form);
            panel1.Location = new Point(453, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1417, 1229);
            panel1.TabIndex = 62;
            // 
            // comboBox_Minutes2
            // 
            comboBox_Minutes2.BackColor = SystemColors.ScrollBar;
            comboBox_Minutes2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Minutes2.FormattingEnabled = true;
            comboBox_Minutes2.Items.AddRange(new object[] { "15", "30", "45", "00" });
            comboBox_Minutes2.Location = new Point(401, 884);
            comboBox_Minutes2.Name = "comboBox_Minutes2";
            comboBox_Minutes2.Size = new Size(110, 32);
            comboBox_Minutes2.TabIndex = 87;
            comboBox_Minutes2.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBox_Minutes
            // 
            comboBox_Minutes.BackColor = SystemColors.ScrollBar;
            comboBox_Minutes.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Minutes.FormattingEnabled = true;
            comboBox_Minutes.Items.AddRange(new object[] { "15", "30", "45", "00" });
            comboBox_Minutes.Location = new Point(401, 831);
            comboBox_Minutes.Name = "comboBox_Minutes";
            comboBox_Minutes.Size = new Size(110, 32);
            comboBox_Minutes.TabIndex = 86;
            comboBox_Minutes.SelectedIndexChanged += comboBox_Minutes_SelectedIndexChanged;
            // 
            // comboBox_Hour2
            // 
            comboBox_Hour2.BackColor = SystemColors.ScrollBar;
            comboBox_Hour2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Hour2.FormattingEnabled = true;
            comboBox_Hour2.Items.AddRange(new object[] { "12:", "11:", "10:", "9:", "8:", "7:", "6:", "5:", "4:", "3:", "2:", "1:" });
            comboBox_Hour2.Location = new Point(257, 883);
            comboBox_Hour2.Name = "comboBox_Hour2";
            comboBox_Hour2.Size = new Size(138, 32);
            comboBox_Hour2.TabIndex = 85;
            comboBox_Hour2.SelectedIndexChanged += comboBox_Hour2_SelectedIndexChanged;
            // 
            // comboBox_Hour
            // 
            comboBox_Hour.BackColor = SystemColors.ScrollBar;
            comboBox_Hour.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Hour.FormattingEnabled = true;
            comboBox_Hour.Items.AddRange(new object[] { "12:", "11:", "10:", "9:", "8:", "7:", "6:", "5:", "4:", "3:", "2:", "1:" });
            comboBox_Hour.Location = new Point(257, 832);
            comboBox_Hour.Name = "comboBox_Hour";
            comboBox_Hour.Size = new Size(138, 32);
            comboBox_Hour.TabIndex = 84;
            comboBox_Hour.SelectedIndexChanged += comboBox_Hour_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("HYWenHei-85W", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1100, 1172);
            button2.Name = "button2";
            button2.Size = new Size(135, 45);
            button2.TabIndex = 83;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("HYWenHei-85W", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1241, 1172);
            button1.Name = "button1";
            button1.Size = new Size(135, 45);
            button1.TabIndex = 82;
            button1.Text = "+ ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox_Discount
            // 
            textBox_Discount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Discount.Location = new Point(834, 1039);
            textBox_Discount.Name = "textBox_Discount";
            textBox_Discount.Size = new Size(197, 29);
            textBox_Discount.TabIndex = 81;
            textBox_Discount.TextChanged += textBox_Discount_TextChanged;
            // 
            // textBox_Amount
            // 
            textBox_Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Amount.Location = new Point(834, 977);
            textBox_Amount.Name = "textBox_Amount";
            textBox_Amount.Size = new Size(197, 29);
            textBox_Amount.TabIndex = 80;
            textBox_Amount.TextChanged += textBox_Amount_TextChanged;
            // 
            // Discount
            // 
            Discount.AutoSize = true;
            Discount.BackColor = Color.Transparent;
            Discount.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Discount.ForeColor = Color.White;
            Discount.Location = new Point(680, 1038);
            Discount.Name = "Discount";
            Discount.Size = new Size(118, 34);
            Discount.TabIndex = 79;
            Discount.Text = "Discount :";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.BackColor = Color.Transparent;
            Amount.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Amount.ForeColor = Color.White;
            Amount.Location = new Point(680, 979);
            Amount.Name = "Amount";
            Amount.Size = new Size(110, 34);
            Amount.TabIndex = 78;
            Amount.Text = "Amount :";
            Amount.Click += label22_Click;
            // 
            // textBox_No_of_Guest
            // 
            textBox_No_of_Guest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_No_of_Guest.Location = new Point(836, 925);
            textBox_No_of_Guest.Name = "textBox_No_of_Guest";
            textBox_No_of_Guest.Size = new Size(197, 29);
            textBox_No_of_Guest.TabIndex = 77;
            textBox_No_of_Guest.TextChanged += textBox_No_of_Guest_TextChanged;
            // 
            // No_Of_Guest
            // 
            No_Of_Guest.AutoSize = true;
            No_Of_Guest.BackColor = Color.Transparent;
            No_Of_Guest.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            No_Of_Guest.ForeColor = Color.White;
            No_Of_Guest.Location = new Point(680, 925);
            No_Of_Guest.Name = "No_Of_Guest";
            No_Of_Guest.Size = new Size(157, 34);
            No_Of_Guest.TabIndex = 76;
            No_Of_Guest.Text = "No. of Guest :";
            // 
            // textBox_Room_Rate
            // 
            textBox_Room_Rate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Room_Rate.Location = new Point(835, 876);
            textBox_Room_Rate.Name = "textBox_Room_Rate";
            textBox_Room_Rate.Size = new Size(197, 29);
            textBox_Room_Rate.TabIndex = 75;
            textBox_Room_Rate.TextChanged += textBox_Room_Rate_TextChanged;
            // 
            // room_Rate
            // 
            room_Rate.AutoSize = true;
            room_Rate.BackColor = Color.Transparent;
            room_Rate.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            room_Rate.ForeColor = Color.White;
            room_Rate.Location = new Point(680, 878);
            room_Rate.Name = "room_Rate";
            room_Rate.Size = new Size(143, 34);
            room_Rate.TabIndex = 74;
            room_Rate.Text = "Room Rate :";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.BackColor = SystemColors.ScrollBar;
            comboBox_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female" });
            comboBox_Gender.Location = new Point(834, 825);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(197, 29);
            comboBox_Gender.TabIndex = 73;
            // 
            // combo_Box_Sex
            // 
            combo_Box_Sex.AutoSize = true;
            combo_Box_Sex.BackColor = Color.Transparent;
            combo_Box_Sex.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            combo_Box_Sex.ForeColor = Color.White;
            combo_Box_Sex.Location = new Point(680, 825);
            combo_Box_Sex.Name = "combo_Box_Sex";
            combo_Box_Sex.Size = new Size(63, 34);
            combo_Box_Sex.TabIndex = 72;
            combo_Box_Sex.Text = "Sex :";
            // 
            // textBox_Remarks
            // 
            textBox_Remarks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Remarks.Location = new Point(257, 1085);
            textBox_Remarks.Name = "textBox_Remarks";
            textBox_Remarks.Size = new Size(344, 29);
            textBox_Remarks.TabIndex = 71;
            // 
            // Remarks
            // 
            Remarks.AutoSize = true;
            Remarks.BackColor = Color.Transparent;
            Remarks.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remarks.ForeColor = Color.White;
            Remarks.Location = new Point(51, 1083);
            Remarks.Name = "Remarks";
            Remarks.Size = new Size(120, 34);
            Remarks.TabIndex = 70;
            Remarks.Text = "Remarks :";
            // 
            // textBox_Room_Number
            // 
            textBox_Room_Number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Room_Number.Location = new Point(257, 1037);
            textBox_Room_Number.Name = "textBox_Room_Number";
            textBox_Room_Number.Size = new Size(344, 29);
            textBox_Room_Number.TabIndex = 69;
            textBox_Room_Number.TextChanged += textBox_Room_Number_TextChanged;
            // 
            // Room_Number
            // 
            Room_Number.AutoSize = true;
            Room_Number.BackColor = Color.Transparent;
            Room_Number.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Room_Number.ForeColor = Color.White;
            Room_Number.Location = new Point(51, 1035);
            Room_Number.Name = "Room_Number";
            Room_Number.Size = new Size(179, 34);
            Room_Number.TabIndex = 68;
            Room_Number.Text = "Room Number :";
            // 
            // textBox_No_Of_Days
            // 
            textBox_No_Of_Days.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_No_Of_Days.Location = new Point(257, 932);
            textBox_No_Of_Days.Name = "textBox_No_Of_Days";
            textBox_No_Of_Days.Size = new Size(344, 29);
            textBox_No_Of_Days.TabIndex = 67;
            textBox_No_Of_Days.TextChanged += textBox_No_Of_Days_TextChanged;
            // 
            // NoOfDays
            // 
            NoOfDays.AutoSize = true;
            NoOfDays.BackColor = Color.Transparent;
            NoOfDays.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoOfDays.ForeColor = Color.White;
            NoOfDays.Location = new Point(51, 935);
            NoOfDays.Name = "NoOfDays";
            NoOfDays.Size = new Size(147, 34);
            NoOfDays.TabIndex = 66;
            NoOfDays.Text = "No. of Days :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.MidnightBlue;
            label15.Font = new Font("HYWenHei-85W", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkOrange;
            label15.Location = new Point(47, 737);
            label15.Name = "label15";
            label15.Padding = new Padding(0, 10, 0, 10);
            label15.Size = new Size(1329, 65);
            label15.TabIndex = 63;
            label15.Text = "CHECK-IN SCHEDULE                                                                                 ";
            // 
            // home_Address
            // 
            home_Address.AutoSize = true;
            home_Address.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            home_Address.ForeColor = Color.White;
            home_Address.Location = new Point(51, 668);
            home_Address.Name = "home_Address";
            home_Address.Size = new Size(181, 34);
            home_Address.TabIndex = 65;
            home_Address.Text = "Home Address :";
            // 
            // textBox_HomeAdd
            // 
            textBox_HomeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_HomeAdd.Location = new Point(257, 668);
            textBox_HomeAdd.Name = "textBox_HomeAdd";
            textBox_HomeAdd.Size = new Size(323, 29);
            textBox_HomeAdd.TabIndex = 64;
            // 
            // textBox_ContactNoInCaseOfEmEmergency
            // 
            textBox_ContactNoInCaseOfEmEmergency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ContactNoInCaseOfEmEmergency.Location = new Point(257, 607);
            textBox_ContactNoInCaseOfEmEmergency.Name = "textBox_ContactNoInCaseOfEmEmergency";
            textBox_ContactNoInCaseOfEmEmergency.Size = new Size(323, 29);
            textBox_ContactNoInCaseOfEmEmergency.TabIndex = 63;
            textBox_ContactNoInCaseOfEmEmergency.TextChanged += textBox_ContactNoInCaseOfEmEmergency_TextChanged;
            // 
            // Contact_No_In_Case_of_Emergency
            // 
            Contact_No_In_Case_of_Emergency.AutoSize = true;
            Contact_No_In_Case_of_Emergency.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contact_No_In_Case_of_Emergency.ForeColor = Color.White;
            Contact_No_In_Case_of_Emergency.Location = new Point(51, 605);
            Contact_No_In_Case_of_Emergency.Name = "Contact_No_In_Case_of_Emergency";
            Contact_No_In_Case_of_Emergency.Size = new Size(153, 34);
            Contact_No_In_Case_of_Emergency.TabIndex = 62;
            Contact_No_In_Case_of_Emergency.Text = "Contact No. :";
            // 
            // textBox_Person_to_Notify
            // 
            textBox_Person_to_Notify.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Person_to_Notify.Location = new Point(257, 543);
            textBox_Person_to_Notify.Name = "textBox_Person_to_Notify";
            textBox_Person_to_Notify.Size = new Size(323, 29);
            textBox_Person_to_Notify.TabIndex = 61;
            // 
            // person_to_Notify
            // 
            person_to_Notify.AutoSize = true;
            person_to_Notify.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            person_to_Notify.ForeColor = Color.White;
            person_to_Notify.Location = new Point(51, 541);
            person_to_Notify.Name = "person_to_Notify";
            person_to_Notify.Size = new Size(194, 34);
            person_to_Notify.TabIndex = 60;
            person_to_Notify.Text = "Person to Notify :";
            // 
            // incaseofemergency
            // 
            incaseofemergency.AutoSize = true;
            incaseofemergency.BackColor = Color.MidnightBlue;
            incaseofemergency.Font = new Font("HYWenHei-85W", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            incaseofemergency.ForeColor = Color.DarkOrange;
            incaseofemergency.Location = new Point(47, 437);
            incaseofemergency.Name = "incaseofemergency";
            incaseofemergency.Padding = new Padding(0, 10, 0, 10);
            incaseofemergency.Size = new Size(1321, 65);
            incaseofemergency.TabIndex = 12;
            incaseofemergency.Text = "INCASE OF EMERGENCY                                                                            ";
            // 
            // textBox_Age
            // 
            textBox_Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Age.Location = new Point(680, 204);
            textBox_Age.Name = "textBox_Age";
            textBox_Age.Size = new Size(274, 29);
            textBox_Age.TabIndex = 11;
            textBox_Age.TextChanged += textBox_Age_TextChanged;
            // 
            // age
            // 
            age.AutoSize = true;
            age.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            age.ForeColor = Color.White;
            age.Location = new Point(605, 204);
            age.Name = "age";
            age.Size = new Size(69, 34);
            age.TabIndex = 10;
            age.Text = "Age :";
            // 
            // textBox_EmailAdd
            // 
            textBox_EmailAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_EmailAdd.Location = new Point(230, 372);
            textBox_EmailAdd.Name = "textBox_EmailAdd";
            textBox_EmailAdd.Size = new Size(236, 29);
            textBox_EmailAdd.TabIndex = 9;
            textBox_EmailAdd.TextChanged += textBox_EmailAdd_TextChanged;
            // 
            // textBox_ContactNo
            // 
            textBox_ContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ContactNo.Location = new Point(230, 316);
            textBox_ContactNo.Name = "textBox_ContactNo";
            textBox_ContactNo.Size = new Size(236, 29);
            textBox_ContactNo.TabIndex = 8;
            textBox_ContactNo.TextChanged += textBox_ContactNo_TextChanged;
            // 
            // email_Address
            // 
            email_Address.AutoSize = true;
            email_Address.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_Address.ForeColor = Color.White;
            email_Address.Location = new Point(51, 370);
            email_Address.Name = "email_Address";
            email_Address.Size = new Size(178, 34);
            email_Address.TabIndex = 7;
            email_Address.Text = "Email Address :";
            // 
            // contact_No
            // 
            contact_No.AutoSize = true;
            contact_No.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contact_No.ForeColor = Color.White;
            contact_No.Location = new Point(51, 316);
            contact_No.Name = "contact_No";
            contact_No.Size = new Size(153, 34);
            contact_No.TabIndex = 6;
            contact_No.Text = "Contact No. :";
            contact_No.Click += contact_No_Click;
            // 
            // textBox_GuestName
            // 
            textBox_GuestName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_GuestName.Location = new Point(230, 261);
            textBox_GuestName.Name = "textBox_GuestName";
            textBox_GuestName.Size = new Size(236, 29);
            textBox_GuestName.TabIndex = 5;
            textBox_GuestName.TextChanged += textBox_GuestName_TextChanged;
            // 
            // guest_Name
            // 
            guest_Name.AutoSize = true;
            guest_Name.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guest_Name.ForeColor = Color.White;
            guest_Name.Location = new Point(51, 259);
            guest_Name.Name = "guest_Name";
            guest_Name.Size = new Size(159, 34);
            guest_Name.TabIndex = 4;
            guest_Name.Text = "Guest Name :";
            guest_Name.Click += label4_Click;
            // 
            // GRF_No
            // 
            GRF_No.AutoSize = true;
            GRF_No.Font = new Font("Poppins Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GRF_No.ForeColor = Color.White;
            GRF_No.Location = new Point(51, 204);
            GRF_No.Name = "GRF_No";
            GRF_No.Size = new Size(109, 34);
            GRF_No.TabIndex = 3;
            GRF_No.Text = "GRF No. :";
            // 
            // textBox_GRF
            // 
            textBox_GRF.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_GRF.Location = new Point(230, 204);
            textBox_GRF.Name = "textBox_GRF";
            textBox_GRF.Size = new Size(236, 29);
            textBox_GRF.TabIndex = 2;
            textBox_GRF.TextChanged += textBox_GRF_TextChanged;
            // 
            // guest_Registration_Form_Header
            // 
            guest_Registration_Form_Header.AutoSize = true;
            guest_Registration_Form_Header.BackColor = Color.MidnightBlue;
            guest_Registration_Form_Header.Font = new Font("HYWenHei-85W", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guest_Registration_Form_Header.ForeColor = Color.DarkOrange;
            guest_Registration_Form_Header.Location = new Point(47, 120);
            guest_Registration_Form_Header.Name = "guest_Registration_Form_Header";
            guest_Registration_Form_Header.Padding = new Padding(0, 10, 0, 10);
            guest_Registration_Form_Header.Size = new Size(1323, 65);
            guest_Registration_Form_Header.TabIndex = 1;
            guest_Registration_Form_Header.Text = "GUEST REGISTRATION FORM HEADER                                                    ";
            // 
            // guest_Registration_Form
            // 
            guest_Registration_Form.AutoSize = true;
            guest_Registration_Form.BackColor = Color.MidnightBlue;
            guest_Registration_Form.Font = new Font("HYWenHei-85W", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guest_Registration_Form.ForeColor = Color.DarkOrange;
            guest_Registration_Form.Location = new Point(0, 0);
            guest_Registration_Form.Name = "guest_Registration_Form";
            guest_Registration_Form.Size = new Size(2293, 78);
            guest_Registration_Form.TabIndex = 0;
            guest_Registration_Form.Text = "GUEST REGISTRATION FORM                                                                    ";
            // 
            // navBarControl1
            // 
            navBarControl1.BackColor = Color.Transparent;
            navBarControl1.Dock = DockStyle.Left;
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.Size = new Size(345, 1386);
            navBarControl1.TabIndex = 63;
            // 
            // AddBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 840);
            Controls.Add(navBarControl1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddBooking";
            Text = "NavBar";
            WindowState = FormWindowState.Maximized;
            Load += NavBar_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label Check_InDate;
        private System.Windows.Forms.Label Check_OutDate;
        private System.Windows.Forms.Label Room_Type;
        private System.Windows.Forms.ComboBox comboBox_RoomType;
        private System.Windows.Forms.ComboBox ComboBox_Am_Or_Pm1;
        private System.Windows.Forms.ComboBox ComboBox_Am_Or_Pm2;
        private System.Windows.Forms.Timer menutransition_1;
        private System.Windows.Forms.Timer menutransition_2;
        private System.Windows.Forms.Timer menutransition_3;
        private System.Windows.Forms.Timer menutransition_4;
        private System.Windows.Forms.Timer menuwidth;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Panel panel1;
        private Label GRF_No;
        private TextBox textBox_GRF;
        private Label guest_Registration_Form_Header;
        private Label guest_Registration_Form;
        private TextBox textBox_EmailAdd;
        private TextBox textBox_ContactNo;
        private Label email_Address;
        private Label contact_No;
        private TextBox textBox_GuestName;
        private Label guest_Name;
        private Label age;
        private Label home_Address;
        private TextBox textBox_HomeAdd;
        private TextBox textBox_ContactNoInCaseOfEmEmergency;
        private Label Contact_No_In_Case_of_Emergency;
        private TextBox textBox_Person_to_Notify;
        private Label person_to_Notify;
        private Label incaseofemergency;
        private TextBox textBox_Age;
        private Label label15;
        private TextBox textBox_No_Of_Days;
        private Label NoOfDays;
        private Label Discount;
        private Label Amount;
        private TextBox textBox_No_of_Guest;
        private Label No_Of_Guest;
        private TextBox textBox_Room_Rate;
        private Label room_Rate;
        private ComboBox comboBox_Gender;
        private Label combo_Box_Sex;
        private TextBox textBox_Remarks;
        private Label Remarks;
        private TextBox textBox_Room_Number;
        private Label Room_Number;
        private TextBox textBox_Discount;
        private TextBox textBox_Amount;
        private Button button1;
        private Button button2;
        private ComboBox comboBox_Minutes2;
        private ComboBox comboBox_Minutes;
        private ComboBox comboBox_Hour2;
        private ComboBox comboBox_Hour;
        private NavBarControl navBarControl1;

        // !!!
        // COPY END
        // !!!
    }
}