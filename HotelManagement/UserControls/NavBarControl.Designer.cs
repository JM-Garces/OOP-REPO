namespace HotelManagement
{
    partial class NavBarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBarControl));
            NavBarFlow = new FlowLayoutPanel();
            panel_header = new Panel();
            pictureBox_logo = new PictureBox();
            panel1 = new Panel();
            button_hamburger = new Button();
            menu_1 = new FlowLayoutPanel();
            panel_menu_1 = new Panel();
            button1 = new Button();
            menu_2 = new FlowLayoutPanel();
            panel_menu_2 = new Panel();
            button2 = new Button();
            menu_3 = new FlowLayoutPanel();
            panel_menu_3 = new Panel();
            room_button = new Button();
            panel6 = new Panel();
            button10 = new Button();
            panel7 = new Panel();
            button11 = new Button();
            menu_4 = new FlowLayoutPanel();
            panel_menu_4 = new Panel();
            billing_button = new Button();
            panel4 = new Panel();
            button8 = new Button();
            panel5 = new Panel();
            button9 = new Button();
            menu_5 = new FlowLayoutPanel();
            panel_menu_5 = new Panel();
            report_button = new Button();
            panel2 = new Panel();
            button6 = new Button();
            panel3 = new Panel();
            button7 = new Button();
            room_timer = new System.Windows.Forms.Timer(components);
            billing_timer = new System.Windows.Forms.Timer(components);
            report_timer = new System.Windows.Forms.Timer(components);
            menu_timer = new System.Windows.Forms.Timer(components);
            NavBarFlow.SuspendLayout();
            panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            panel1.SuspendLayout();
            menu_1.SuspendLayout();
            panel_menu_1.SuspendLayout();
            menu_2.SuspendLayout();
            panel_menu_2.SuspendLayout();
            menu_3.SuspendLayout();
            panel_menu_3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            menu_4.SuspendLayout();
            panel_menu_4.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            menu_5.SuspendLayout();
            panel_menu_5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // NavBarFlow
            // 
            NavBarFlow.BackColor = Color.FromArgb(2, 24, 103);
            NavBarFlow.Controls.Add(panel_header);
            NavBarFlow.Controls.Add(menu_1);
            NavBarFlow.Controls.Add(menu_2);
            NavBarFlow.Controls.Add(menu_3);
            NavBarFlow.Controls.Add(menu_4);
            NavBarFlow.Controls.Add(menu_5);
            NavBarFlow.Location = new Point(0, 0);
            NavBarFlow.Margin = new Padding(0);
            NavBarFlow.Name = "NavBarFlow";
            NavBarFlow.Size = new Size(100, 9999);
            NavBarFlow.TabIndex = 0;
            // 
            // panel_header
            // 
            panel_header.Controls.Add(pictureBox_logo);
            panel_header.Controls.Add(panel1);
            panel_header.Location = new Point(0, 0);
            panel_header.Margin = new Padding(0);
            panel_header.Name = "panel_header";
            panel_header.Size = new Size(345, 80);
            panel_header.TabIndex = 0;
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.BackgroundImage = (Image)resources.GetObject("pictureBox_logo.BackgroundImage");
            pictureBox_logo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_logo.Location = new Point(123, 0);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(200, 97);
            pictureBox_logo.TabIndex = 1;
            pictureBox_logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button_hamburger);
            panel1.Location = new Point(24, 21);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(46, 42);
            panel1.TabIndex = 0;
            // 
            // button_hamburger
            // 
            button_hamburger.BackColor = Color.FromArgb(2, 24, 103);
            button_hamburger.BackgroundImage = (Image)resources.GetObject("button_hamburger.BackgroundImage");
            button_hamburger.BackgroundImageLayout = ImageLayout.Stretch;
            button_hamburger.Location = new Point(-4, -7);
            button_hamburger.Name = "button_hamburger";
            button_hamburger.Size = new Size(57, 54);
            button_hamburger.TabIndex = 0;
            button_hamburger.UseVisualStyleBackColor = false;
            button_hamburger.Click += button_hamburger_Click;
            // 
            // menu_1
            // 
            menu_1.Controls.Add(panel_menu_1);
            menu_1.Location = new Point(0, 80);
            menu_1.Margin = new Padding(0);
            menu_1.Name = "menu_1";
            menu_1.Size = new Size(345, 80);
            menu_1.TabIndex = 1;
            // 
            // panel_menu_1
            // 
            panel_menu_1.Controls.Add(button1);
            panel_menu_1.Location = new Point(3, 3);
            panel_menu_1.Name = "panel_menu_1";
            panel_menu_1.Size = new Size(339, 70);
            panel_menu_1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 24, 103);
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 189, 89);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-13, -15);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 80, 0);
            button1.Size = new Size(367, 100);
            button1.TabIndex = 2;
            button1.Text = "HOME";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // menu_2
            // 
            menu_2.Controls.Add(panel_menu_2);
            menu_2.Location = new Point(0, 160);
            menu_2.Margin = new Padding(0);
            menu_2.Name = "menu_2";
            menu_2.Size = new Size(345, 80);
            menu_2.TabIndex = 5;
            // 
            // panel_menu_2
            // 
            panel_menu_2.Controls.Add(button2);
            panel_menu_2.Location = new Point(3, 3);
            panel_menu_2.Name = "panel_menu_2";
            panel_menu_2.Size = new Size(339, 70);
            panel_menu_2.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(2, 24, 103);
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(255, 189, 89);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-13, -15);
            button2.Name = "button2";
            button2.Padding = new Padding(25, 0, 50, 0);
            button2.Size = new Size(367, 100);
            button2.TabIndex = 2;
            button2.Text = "BOOKINGS";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menu_3
            // 
            menu_3.Controls.Add(panel_menu_3);
            menu_3.Controls.Add(panel6);
            menu_3.Controls.Add(panel7);
            menu_3.Location = new Point(0, 240);
            menu_3.Margin = new Padding(0);
            menu_3.Name = "menu_3";
            menu_3.Size = new Size(345, 80);
            menu_3.TabIndex = 6;
            // 
            // panel_menu_3
            // 
            panel_menu_3.Controls.Add(room_button);
            panel_menu_3.Location = new Point(3, 3);
            panel_menu_3.Name = "panel_menu_3";
            panel_menu_3.Size = new Size(339, 80);
            panel_menu_3.TabIndex = 4;
            // 
            // room_button
            // 
            room_button.BackColor = Color.FromArgb(2, 24, 103);
            room_button.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            room_button.ForeColor = Color.FromArgb(255, 189, 89);
            room_button.Image = (Image)resources.GetObject("room_button.Image");
            room_button.ImageAlign = ContentAlignment.MiddleLeft;
            room_button.Location = new Point(-13, -15);
            room_button.Name = "room_button";
            room_button.Padding = new Padding(10, 0, 65, 0);
            room_button.Size = new Size(367, 100);
            room_button.TabIndex = 2;
            room_button.Text = "ROOMS";
            room_button.TextAlign = ContentAlignment.MiddleRight;
            room_button.UseVisualStyleBackColor = false;
            room_button.Click += room_button_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(button10);
            panel6.Location = new Point(0, 86);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(345, 80);
            panel6.TabIndex = 6;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(7, 58, 148);
            button10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.White;
            button10.Location = new Point(-10, -9);
            button10.Name = "button10";
            button10.Size = new Size(367, 98);
            button10.TabIndex = 0;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(button11);
            panel7.Location = new Point(0, 166);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(345, 80);
            panel7.TabIndex = 7;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(7, 58, 148);
            button11.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.White;
            button11.Location = new Point(-10, -9);
            button11.Name = "button11";
            button11.Size = new Size(367, 98);
            button11.TabIndex = 0;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = false;
            // 
            // menu_4
            // 
            menu_4.Controls.Add(panel_menu_4);
            menu_4.Controls.Add(panel4);
            menu_4.Controls.Add(panel5);
            menu_4.Location = new Point(0, 320);
            menu_4.Margin = new Padding(0);
            menu_4.Name = "menu_4";
            menu_4.Size = new Size(345, 80);
            menu_4.TabIndex = 7;
            // 
            // panel_menu_4
            // 
            panel_menu_4.Controls.Add(billing_button);
            panel_menu_4.Location = new Point(3, 3);
            panel_menu_4.Name = "panel_menu_4";
            panel_menu_4.Size = new Size(339, 80);
            panel_menu_4.TabIndex = 4;
            // 
            // billing_button
            // 
            billing_button.BackColor = Color.FromArgb(2, 24, 103);
            billing_button.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billing_button.ForeColor = Color.FromArgb(255, 189, 89);
            billing_button.Image = (Image)resources.GetObject("billing_button.Image");
            billing_button.ImageAlign = ContentAlignment.MiddleLeft;
            billing_button.Location = new Point(-13, -8);
            billing_button.Name = "billing_button";
            billing_button.Padding = new Padding(25, 0, 58, 0);
            billing_button.Size = new Size(367, 100);
            billing_button.TabIndex = 2;
            billing_button.Text = "BILLINGS";
            billing_button.TextAlign = ContentAlignment.MiddleRight;
            billing_button.UseVisualStyleBackColor = false;
            billing_button.Click += billing_button_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button8);
            panel4.Location = new Point(0, 86);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 80);
            panel4.TabIndex = 5;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(7, 58, 148);
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Location = new Point(-10, -9);
            button8.Name = "button8";
            button8.Size = new Size(367, 98);
            button8.TabIndex = 0;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button9);
            panel5.Location = new Point(0, 166);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(345, 80);
            panel5.TabIndex = 6;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(7, 58, 148);
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(-10, -9);
            button9.Name = "button9";
            button9.Size = new Size(367, 98);
            button9.TabIndex = 0;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = false;
            // 
            // menu_5
            // 
            menu_5.Controls.Add(panel_menu_5);
            menu_5.Controls.Add(panel2);
            menu_5.Controls.Add(panel3);
            menu_5.Location = new Point(0, 400);
            menu_5.Margin = new Padding(0);
            menu_5.Name = "menu_5";
            menu_5.Size = new Size(345, 80);
            menu_5.TabIndex = 8;
            // 
            // panel_menu_5
            // 
            panel_menu_5.Controls.Add(report_button);
            panel_menu_5.Location = new Point(3, 3);
            panel_menu_5.Name = "panel_menu_5";
            panel_menu_5.Size = new Size(339, 80);
            panel_menu_5.TabIndex = 4;
            // 
            // report_button
            // 
            report_button.BackColor = Color.FromArgb(2, 24, 103);
            report_button.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            report_button.ForeColor = Color.FromArgb(255, 189, 89);
            report_button.Image = (Image)resources.GetObject("report_button.Image");
            report_button.ImageAlign = ContentAlignment.MiddleLeft;
            report_button.Location = new Point(-13, -10);
            report_button.Name = "report_button";
            report_button.Padding = new Padding(25, 0, 60, 0);
            report_button.Size = new Size(367, 100);
            report_button.TabIndex = 2;
            report_button.Text = "REPORTS";
            report_button.TextAlign = ContentAlignment.MiddleRight;
            report_button.UseVisualStyleBackColor = false;
            report_button.Click += report_button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Location = new Point(0, 86);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 80);
            panel2.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(7, 58, 148);
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-10, -10);
            button6.Name = "button6";
            button6.Size = new Size(367, 102);
            button6.TabIndex = 0;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Location = new Point(0, 166);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 80);
            panel3.TabIndex = 6;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(7, 58, 148);
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(-10, -10);
            button7.Name = "button7";
            button7.Size = new Size(367, 102);
            button7.TabIndex = 0;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // room_timer
            // 
            room_timer.Interval = 10;
            room_timer.Tick += menu_width_timer_Tick;
            // 
            // billing_timer
            // 
            billing_timer.Interval = 1;
            billing_timer.Tick += billing_timer_Tick;
            // 
            // report_timer
            // 
            report_timer.Interval = 1;
            report_timer.Tick += report_timer_Tick;
            // 
            // menu_timer
            // 
            menu_timer.Interval = 1;
            menu_timer.Tick += menu_timer_Tick;
            // 
            // NavBarControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(NavBarFlow);
            Name = "NavBarControl";
            Size = new Size(100, 900);
            NavBarFlow.ResumeLayout(false);
            panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            panel1.ResumeLayout(false);
            menu_1.ResumeLayout(false);
            panel_menu_1.ResumeLayout(false);
            menu_2.ResumeLayout(false);
            panel_menu_2.ResumeLayout(false);
            menu_3.ResumeLayout(false);
            panel_menu_3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            menu_4.ResumeLayout(false);
            panel_menu_4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            menu_5.ResumeLayout(false);
            panel_menu_5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel NavBarFlow;
        private Panel panel_header;
        private PictureBox pictureBox_logo;
        private Panel panel1;
        private FlowLayoutPanel menu_1;
        private Panel panel_menu_1;
        private Button button1;
        private FlowLayoutPanel menu_2;
        private Panel panel_menu_2;
        private Button button2;
        private FlowLayoutPanel menu_3;
        private Panel panel_menu_3;
        private Button room_button;
        private FlowLayoutPanel menu_4;
        private Panel panel_menu_4;
        private Button billing_button;
        private FlowLayoutPanel menu_5;
        private Panel panel_menu_5;
        private Button report_button;
        private Panel panel2;
        private Button button6;
        private Panel panel3;
        private Button button7;
        private Panel panel6;
        private Button button10;
        private Panel panel7;
        private Button button11;
        private Panel panel4;
        private Button button8;
        private Panel panel5;
        private Button button9;
        private System.Windows.Forms.Timer room_timer;
        private System.Windows.Forms.Timer billing_timer;
        private System.Windows.Forms.Timer report_timer;
        private System.Windows.Forms.Timer menu_timer;
        private Button button_hamburger;
    }
}
