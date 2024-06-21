using System.Data;

namespace HotelManagement
{
    partial class StartUp
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Required method for Designer support - do not modify the contents of this method with the code editor.
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            pictureBox2 = new PictureBox();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            label_username = new Label();
            label_Password = new Label();
            label_username_required = new Label();
            label_password_required = new Label();
            sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            errorProviderusername = new ErrorProvider(components);
            errorProviderpass = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderusername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderpass).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1509, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1545, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 2;
            label1.Text = "Log In";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Gold;
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(1072, 804);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 24);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Dungeon.Hotel";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Gold;
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(1284, 804);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(138, 24);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Dungeon.Hotel";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Gold;
            linkLabel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(1496, 804);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(138, 24);
            linkLabel3.TabIndex = 5;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Dungeon.Hotel";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.ActiveLinkColor = Color.Gold;
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = Color.Transparent;
            linkLabel4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel4.LinkColor = Color.White;
            linkLabel4.Location = new Point(1330, 37);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(100, 31);
            linkLabel4.TabIndex = 6;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Rooms";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1399, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(167, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox_username
            // 
            textBox_username.Location = new Point(1347, 365);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(100, 23);
            textBox_username.TabIndex = 8;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(1347, 432);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(100, 23);
            textBox_password.TabIndex = 9;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(1347, 458);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 10;
            button_login.Text = "Log in";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_Login_Click;
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.BackColor = Color.Transparent;
            label_username.Location = new Point(1344, 337);
            label_username.Name = "label_username";
            label_username.Size = new Size(68, 15);
            label_username.TabIndex = 11;
            label_username.Text = "USERNAME";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.BackColor = Color.Transparent;
            label_Password.Location = new Point(1344, 405);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(68, 15);
            label_Password.TabIndex = 12;
            label_Password.Text = "PASSWORD";
            // 
            // label_username_required
            // 
            label_username_required.Location = new Point(0, 0);
            label_username_required.Name = "label_username_required";
            label_username_required.Size = new Size(100, 23);
            label_username_required.TabIndex = 0;
            // 
            // label_password_required
            // 
            label_password_required.Location = new Point(0, 0);
            label_password_required.Name = "label_password_required";
            label_password_required.Size = new Size(100, 23);
            label_password_required.TabIndex = 0;
            // 
            // sqLiteCommand1
            // 
            sqLiteCommand1.CommandText = null;
            // 
            // errorProviderusername
            // 
            errorProviderusername.ContainerControl = this;
            // 
            // errorProviderpass
            // 
            errorProviderpass.ContainerControl = this;
            // 
            // StartUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1740, 858);
            Controls.Add(label_Password);
            Controls.Add(label_username);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(255, 128, 128);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartUp";
            Load += StartUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderusername).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderpass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_username_required;
        private System.Windows.Forms.Label label_password_required;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.ErrorProvider errorProviderusername;
        private System.Windows.Forms.ErrorProvider errorProviderpass;
    }
}
