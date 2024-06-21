namespace HotelManagement
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            button_CreateNewBooking = new Button();
            button_ViewBookingList = new Button();
            button_ViewGuestList = new Button();
            pictureBox_BookingInformation = new PictureBox();
            navBarControl1 = new NavBarControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox_BookingInformation).BeginInit();
            SuspendLayout();
            // 
            // button_CreateNewBooking
            // 
            button_CreateNewBooking.BackColor = Color.MidnightBlue;
            button_CreateNewBooking.Font = new Font("HYWenHei-85W", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_CreateNewBooking.ForeColor = Color.DarkOrange;
            button_CreateNewBooking.Location = new Point(618, 383);
            button_CreateNewBooking.Margin = new Padding(4, 3, 4, 3);
            button_CreateNewBooking.Name = "button_CreateNewBooking";
            button_CreateNewBooking.Size = new Size(462, 84);
            button_CreateNewBooking.TabIndex = 0;
            button_CreateNewBooking.Text = "Create New Booking";
            button_CreateNewBooking.UseVisualStyleBackColor = false;
            button_CreateNewBooking.Click += button1_Click_1;
            // 
            // button_ViewBookingList
            // 
            button_ViewBookingList.BackColor = Color.MidnightBlue;
            button_ViewBookingList.Font = new Font("HYWenHei-85W", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ViewBookingList.ForeColor = Color.DarkOrange;
            button_ViewBookingList.Location = new Point(1318, 383);
            button_ViewBookingList.Margin = new Padding(4, 3, 4, 3);
            button_ViewBookingList.Name = "button_ViewBookingList";
            button_ViewBookingList.Size = new Size(462, 84);
            button_ViewBookingList.TabIndex = 1;
            button_ViewBookingList.Text = "View Booking List";
            button_ViewBookingList.UseVisualStyleBackColor = false;
            // 
            // button_ViewGuestList
            // 
            button_ViewGuestList.BackColor = Color.MidnightBlue;
            button_ViewGuestList.Font = new Font("HYWenHei-85W", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_ViewGuestList.ForeColor = Color.DarkOrange;
            button_ViewGuestList.Location = new Point(618, 665);
            button_ViewGuestList.Margin = new Padding(4, 3, 4, 3);
            button_ViewGuestList.Name = "button_ViewGuestList";
            button_ViewGuestList.Size = new Size(462, 84);
            button_ViewGuestList.TabIndex = 5;
            button_ViewGuestList.Text = "View Guest List";
            button_ViewGuestList.UseVisualStyleBackColor = false;
            // 
            // pictureBox_BookingInformation
            // 
            pictureBox_BookingInformation.Image = (Image)resources.GetObject("pictureBox_BookingInformation.Image");
            pictureBox_BookingInformation.Location = new Point(509, 87);
            pictureBox_BookingInformation.Margin = new Padding(4, 3, 4, 3);
            pictureBox_BookingInformation.Name = "pictureBox_BookingInformation";
            pictureBox_BookingInformation.Size = new Size(1448, 825);
            pictureBox_BookingInformation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_BookingInformation.TabIndex = 11;
            pictureBox_BookingInformation.TabStop = false;
            // 
            // navBarControl1
            // 
            navBarControl1.BackColor = Color.Transparent;
            navBarControl1.Dock = DockStyle.Left;
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.Size = new Size(345, 990);
            navBarControl1.TabIndex = 12;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 990);
            Controls.Add(navBarControl1);
            Controls.Add(button_ViewGuestList);
            Controls.Add(button_CreateNewBooking);
            Controls.Add(button_ViewBookingList);
            Controls.Add(pictureBox_BookingInformation);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_BookingInformation).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button_CreateNewBooking;
        private System.Windows.Forms.Button button_ViewBookingList;
        private System.Windows.Forms.Button button_ViewGuestList;
        private System.Windows.Forms.PictureBox pictureBox_BookingInformation;
        private NavBarControl navBarControl1;
    }
}