namespace HotelManagement.Forms
{
    partial class NavBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBar));
            menutransition_1 = new System.Windows.Forms.Timer(components);
            menutransition_2 = new System.Windows.Forms.Timer(components);
            menutransition_3 = new System.Windows.Forms.Timer(components);
            menutransition_4 = new System.Windows.Forms.Timer(components);
            menuwidth = new System.Windows.Forms.Timer(components);
            navBarControl1 = new NavBarControl();
            SuspendLayout();
            // 
            // navBarControl1
            // 
            navBarControl1.BackColor = Color.Transparent;
            navBarControl1.Dock = DockStyle.Left;
            navBarControl1.Location = new Point(0, 0);
            navBarControl1.Name = "navBarControl1";
            navBarControl1.Size = new Size(345, 990);
            navBarControl1.TabIndex = 1;
            // 
            // NavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1924, 990);
            Controls.Add(navBarControl1);
            DoubleBuffered = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "NavBar";
            Text = "NavBar";
            WindowState = FormWindowState.Maximized;
            FormClosing += NavBar_FormClosing;
            Load += NavBar_Load_1;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer menutransition_1;
        private System.Windows.Forms.Timer menutransition_2;
        private System.Windows.Forms.Timer menutransition_3;
        private System.Windows.Forms.Timer menutransition_4;
        private System.Windows.Forms.Timer menuwidth;
        private NavBarControl navBarControl1;

        // !!!
        // COPY END
        // !!!
    }
}