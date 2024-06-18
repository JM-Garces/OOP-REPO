namespace HotelManagement
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label_header = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_occupancy = new System.Windows.Forms.TabPage();
            this.dataGridView_occupancy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_revenue = new System.Windows.Forms.TabPage();
            this.dataGridView_revenue = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_booking = new System.Windows.Forms.TabPage();
            this.dataGridView_booking = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_dailymothly = new System.Windows.Forms.ComboBox();
            this.comboBox_roomtype = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_endingdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startingdate = new System.Windows.Forms.DateTimePicker();
            this.label_dailymonthly = new System.Windows.Forms.Label();
            this.label_roomtype = new System.Windows.Forms.Label();
            this.label_startingdate = new System.Windows.Forms.Label();
            this.label_endingdate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_occupancy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_occupancy)).BeginInit();
            this.tab_revenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_revenue)).BeginInit();
            this.tab_booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(389, 37);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(372, 61);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Report Module";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tabControl1.Controls.Add(this.tab_occupancy);
            this.tabControl1.Controls.Add(this.tab_revenue);
            this.tabControl1.Controls.Add(this.tab_booking);
            this.tabControl1.Location = new System.Drawing.Point(382, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1346, 718);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_occupancy
            // 
            this.tab_occupancy.Controls.Add(this.dataGridView_occupancy);
            this.tab_occupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_occupancy.Location = new System.Drawing.Point(4, 22);
            this.tab_occupancy.Name = "tab_occupancy";
            this.tab_occupancy.Padding = new System.Windows.Forms.Padding(3);
            this.tab_occupancy.Size = new System.Drawing.Size(1338, 692);
            this.tab_occupancy.TabIndex = 0;
            this.tab_occupancy.Text = "OCCUPANCY";
            this.tab_occupancy.UseVisualStyleBackColor = true;
            // 
            // dataGridView_occupancy
            // 
            this.dataGridView_occupancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_occupancy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView_occupancy.Location = new System.Drawing.Point(14, 19);
            this.dataGridView_occupancy.Name = "dataGridView_occupancy";
            this.dataGridView_occupancy.Size = new System.Drawing.Size(1310, 667);
            this.dataGridView_occupancy.TabIndex = 0;
            this.dataGridView_occupancy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_occupancy_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date/Month";
            this.Column1.Name = "Column1";
            this.Column1.Width = 215;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.Width = 215;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total Rooms";
            this.Column3.Name = "Column3";
            this.Column3.Width = 215;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Occupied Rooms";
            this.Column4.Name = "Column4";
            this.Column4.Width = 215;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Occupancy Rate";
            this.Column5.Name = "Column5";
            this.Column5.Width = 215;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ave. Stay";
            this.Column6.Name = "Column6";
            this.Column6.Width = 215;
            // 
            // tab_revenue
            // 
            this.tab_revenue.Controls.Add(this.dataGridView_revenue);
            this.tab_revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_revenue.Location = new System.Drawing.Point(4, 22);
            this.tab_revenue.Name = "tab_revenue";
            this.tab_revenue.Padding = new System.Windows.Forms.Padding(3);
            this.tab_revenue.Size = new System.Drawing.Size(1338, 692);
            this.tab_revenue.TabIndex = 1;
            this.tab_revenue.Text = "REVENUE";
            this.tab_revenue.UseVisualStyleBackColor = true;
            // 
            // dataGridView_revenue
            // 
            this.dataGridView_revenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_revenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_revenue.Location = new System.Drawing.Point(14, 19);
            this.dataGridView_revenue.Name = "dataGridView_revenue";
            this.dataGridView_revenue.Size = new System.Drawing.Size(1310, 667);
            this.dataGridView_revenue.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date/Month";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 215;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 215;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total Revenue";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 215;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Room Revenue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 215;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Average Room Revenue";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 215;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "RevPAR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 215;
            // 
            // tab_booking
            // 
            this.tab_booking.Controls.Add(this.dataGridView_booking);
            this.tab_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_booking.Location = new System.Drawing.Point(4, 22);
            this.tab_booking.Name = "tab_booking";
            this.tab_booking.Padding = new System.Windows.Forms.Padding(3);
            this.tab_booking.Size = new System.Drawing.Size(1338, 692);
            this.tab_booking.TabIndex = 2;
            this.tab_booking.Text = "BOOKING";
            this.tab_booking.UseVisualStyleBackColor = true;
            // 
            // dataGridView_booking
            // 
            this.dataGridView_booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridView_booking.Location = new System.Drawing.Point(14, 22);
            this.dataGridView_booking.Name = "dataGridView_booking";
            this.dataGridView_booking.Size = new System.Drawing.Size(1310, 667);
            this.dataGridView_booking.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Date/Month";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 187;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 187;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Total Bookings";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 187;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Confirmed Bookings";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 187;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Canceled Bookings";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 187;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "No-show Bookings";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 187;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Peak Booking Time";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 187;
            // 
            // comboBox_dailymothly
            // 
            this.comboBox_dailymothly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_dailymothly.FormattingEnabled = true;
            this.comboBox_dailymothly.Items.AddRange(new object[] {
            "Daily",
            "Monthly"});
            this.comboBox_dailymothly.Location = new System.Drawing.Point(955, 37);
            this.comboBox_dailymothly.Name = "comboBox_dailymothly";
            this.comboBox_dailymothly.Size = new System.Drawing.Size(199, 33);
            this.comboBox_dailymothly.TabIndex = 2;
            // 
            // comboBox_roomtype
            // 
            this.comboBox_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_roomtype.FormattingEnabled = true;
            this.comboBox_roomtype.Location = new System.Drawing.Point(1320, 37);
            this.comboBox_roomtype.Name = "comboBox_roomtype";
            this.comboBox_roomtype.Size = new System.Drawing.Size(199, 33);
            this.comboBox_roomtype.TabIndex = 4;
            // 
            // dateTimePicker_endingdate
            // 
            this.dateTimePicker_endingdate.Location = new System.Drawing.Point(1320, 90);
            this.dateTimePicker_endingdate.Name = "dateTimePicker_endingdate";
            this.dateTimePicker_endingdate.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker_endingdate.TabIndex = 5;
            // 
            // dateTimePicker_startingdate
            // 
            this.dateTimePicker_startingdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startingdate.Location = new System.Drawing.Point(955, 90);
            this.dateTimePicker_startingdate.Name = "dateTimePicker_startingdate";
            this.dateTimePicker_startingdate.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker_startingdate.TabIndex = 6;
            // 
            // label_dailymonthly
            // 
            this.label_dailymonthly.AutoSize = true;
            this.label_dailymonthly.BackColor = System.Drawing.Color.Transparent;
            this.label_dailymonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailymonthly.ForeColor = System.Drawing.Color.White;
            this.label_dailymonthly.Location = new System.Drawing.Point(813, 40);
            this.label_dailymonthly.Name = "label_dailymonthly";
            this.label_dailymonthly.Size = new System.Drawing.Size(136, 25);
            this.label_dailymonthly.TabIndex = 7;
            this.label_dailymonthly.Text = "Daily/Monthly:";
            // 
            // label_roomtype
            // 
            this.label_roomtype.AutoSize = true;
            this.label_roomtype.BackColor = System.Drawing.Color.Transparent;
            this.label_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomtype.ForeColor = System.Drawing.Color.White;
            this.label_roomtype.Location = new System.Drawing.Point(1195, 40);
            this.label_roomtype.Name = "label_roomtype";
            this.label_roomtype.Size = new System.Drawing.Size(119, 25);
            this.label_roomtype.TabIndex = 8;
            this.label_roomtype.Text = "Room Type:";
            // 
            // label_startingdate
            // 
            this.label_startingdate.AutoSize = true;
            this.label_startingdate.BackColor = System.Drawing.Color.Transparent;
            this.label_startingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startingdate.ForeColor = System.Drawing.Color.White;
            this.label_startingdate.Location = new System.Drawing.Point(813, 85);
            this.label_startingdate.Name = "label_startingdate";
            this.label_startingdate.Size = new System.Drawing.Size(131, 25);
            this.label_startingdate.TabIndex = 9;
            this.label_startingdate.Text = "Starting Date:";
            // 
            // label_endingdate
            // 
            this.label_endingdate.AutoSize = true;
            this.label_endingdate.BackColor = System.Drawing.Color.Transparent;
            this.label_endingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endingdate.ForeColor = System.Drawing.Color.White;
            this.label_endingdate.Location = new System.Drawing.Point(1195, 85);
            this.label_endingdate.Name = "label_endingdate";
            this.label_endingdate.Size = new System.Drawing.Size(125, 25);
            this.label_endingdate.TabIndex = 10;
            this.label_endingdate.Text = "Ending Date:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(1561, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1740, 858);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_endingdate);
            this.Controls.Add(this.label_startingdate);
            this.Controls.Add(this.label_roomtype);
            this.Controls.Add(this.label_dailymonthly);
            this.Controls.Add(this.dateTimePicker_startingdate);
            this.Controls.Add(this.dateTimePicker_endingdate);
            this.Controls.Add(this.comboBox_roomtype);
            this.Controls.Add(this.comboBox_dailymothly);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_header);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.tabControl1.ResumeLayout(false);
            this.tab_occupancy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_occupancy)).EndInit();
            this.tab_revenue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_revenue)).EndInit();
            this.tab_booking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_occupancy;
        private System.Windows.Forms.TabPage tab_revenue;
        private System.Windows.Forms.TabPage tab_booking;
        private System.Windows.Forms.ComboBox comboBox_dailymothly;
        private System.Windows.Forms.ComboBox comboBox_roomtype;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endingdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startingdate;
        private System.Windows.Forms.Label label_dailymonthly;
        private System.Windows.Forms.Label label_roomtype;
        private System.Windows.Forms.DataGridView dataGridView_occupancy;
        private System.Windows.Forms.Label label_startingdate;
        private System.Windows.Forms.Label label_endingdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_revenue;
        private System.Windows.Forms.DataGridView dataGridView_booking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}