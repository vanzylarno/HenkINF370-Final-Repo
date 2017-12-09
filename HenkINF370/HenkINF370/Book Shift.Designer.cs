namespace HenkINF370
{
    partial class Book_Shift
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
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtp = new MetroFramework.Controls.MetroDateTime();
            this.lblDetails = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtAvailableSlots = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAvailable = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtTimeSlot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDay = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(290, 463);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(274, 99);
            this.metroButton1.TabIndex = 88;
            this.metroButton1.Text = "Book Shift";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 55);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 19);
            this.metroLabel7.TabIndex = 87;
            this.metroLabel7.Text = "Select a Date:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(23, 77);
            this.dtp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(236, 29);
            this.dtp.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtp.TabIndex = 86;
            this.dtp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtp.Value = new System.DateTime(2017, 12, 21, 0, 0, 0, 0);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDetails.Location = new System.Drawing.Point(292, 400);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(272, 133);
            this.lblDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDetails.TabIndex = 85;
            this.lblDetails.Text = "Help!\r\n\r\nTo view all Shift details, please select a Date\r\n\r\n\r\n\r\n";
            this.lblDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDetails.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(290, 352);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Available Slots:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAvailableSlots
            // 
            // 
            // 
            // 
            this.txtAvailableSlots.CustomButton.Image = null;
            this.txtAvailableSlots.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtAvailableSlots.CustomButton.Name = "";
            this.txtAvailableSlots.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvailableSlots.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvailableSlots.CustomButton.TabIndex = 1;
            this.txtAvailableSlots.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvailableSlots.CustomButton.UseSelectable = true;
            this.txtAvailableSlots.CustomButton.Visible = false;
            this.txtAvailableSlots.Lines = new string[0];
            this.txtAvailableSlots.Location = new System.Drawing.Point(290, 374);
            this.txtAvailableSlots.MaxLength = 32767;
            this.txtAvailableSlots.Name = "txtAvailableSlots";
            this.txtAvailableSlots.PasswordChar = '\0';
            this.txtAvailableSlots.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvailableSlots.SelectedText = "";
            this.txtAvailableSlots.SelectionLength = 0;
            this.txtAvailableSlots.SelectionStart = 0;
            this.txtAvailableSlots.ShortcutsEnabled = true;
            this.txtAvailableSlots.Size = new System.Drawing.Size(238, 23);
            this.txtAvailableSlots.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAvailableSlots.TabIndex = 83;
            this.txtAvailableSlots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAvailableSlots.UseSelectable = true;
            this.txtAvailableSlots.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvailableSlots.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(290, 286);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 82;
            this.metroLabel5.Text = "Date:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(290, 308);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(238, 23);
            this.txtDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDate.TabIndex = 81;
            this.txtDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(290, 227);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 80;
            this.metroLabel4.Text = "Available:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAvailable
            // 
            // 
            // 
            // 
            this.txtAvailable.CustomButton.Image = null;
            this.txtAvailable.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtAvailable.CustomButton.Name = "";
            this.txtAvailable.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvailable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvailable.CustomButton.TabIndex = 1;
            this.txtAvailable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvailable.CustomButton.UseSelectable = true;
            this.txtAvailable.CustomButton.Visible = false;
            this.txtAvailable.Lines = new string[0];
            this.txtAvailable.Location = new System.Drawing.Point(290, 249);
            this.txtAvailable.MaxLength = 32767;
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.PasswordChar = '\0';
            this.txtAvailable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvailable.SelectedText = "";
            this.txtAvailable.SelectionLength = 0;
            this.txtAvailable.SelectionStart = 0;
            this.txtAvailable.ShortcutsEnabled = true;
            this.txtAvailable.Size = new System.Drawing.Size(238, 23);
            this.txtAvailable.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAvailable.TabIndex = 79;
            this.txtAvailable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAvailable.UseSelectable = true;
            this.txtAvailable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvailable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(290, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 78;
            this.metroLabel3.Text = "Timeslot:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTimeSlot
            // 
            // 
            // 
            // 
            this.txtTimeSlot.CustomButton.Image = null;
            this.txtTimeSlot.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtTimeSlot.CustomButton.Name = "";
            this.txtTimeSlot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimeSlot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeSlot.CustomButton.TabIndex = 1;
            this.txtTimeSlot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeSlot.CustomButton.UseSelectable = true;
            this.txtTimeSlot.CustomButton.Visible = false;
            this.txtTimeSlot.Lines = new string[0];
            this.txtTimeSlot.Location = new System.Drawing.Point(290, 193);
            this.txtTimeSlot.MaxLength = 32767;
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.PasswordChar = '\0';
            this.txtTimeSlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeSlot.SelectedText = "";
            this.txtTimeSlot.SelectionLength = 0;
            this.txtTimeSlot.SelectionStart = 0;
            this.txtTimeSlot.ShortcutsEnabled = true;
            this.txtTimeSlot.Size = new System.Drawing.Size(238, 23);
            this.txtTimeSlot.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtTimeSlot.TabIndex = 77;
            this.txtTimeSlot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTimeSlot.UseSelectable = true;
            this.txtTimeSlot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeSlot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(290, 108);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = "Day:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDay
            // 
            // 
            // 
            // 
            this.txtDay.CustomButton.Image = null;
            this.txtDay.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtDay.CustomButton.Name = "";
            this.txtDay.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDay.CustomButton.TabIndex = 1;
            this.txtDay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDay.CustomButton.UseSelectable = true;
            this.txtDay.CustomButton.Visible = false;
            this.txtDay.Lines = new string[0];
            this.txtDay.Location = new System.Drawing.Point(290, 130);
            this.txtDay.MaxLength = 32767;
            this.txtDay.Name = "txtDay";
            this.txtDay.PasswordChar = '\0';
            this.txtDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDay.SelectedText = "";
            this.txtDay.SelectionLength = 0;
            this.txtDay.SelectionStart = 0;
            this.txtDay.ShortcutsEnabled = true;
            this.txtDay.Size = new System.Drawing.Size(238, 23);
            this.txtDay.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDay.TabIndex = 75;
            this.txtDay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDay.UseSelectable = true;
            this.txtDay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 442);
            this.listBox1.TabIndex = 74;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 107);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 73;
            this.metroLabel1.Text = "Shifts Available:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Book_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 599);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtAvailableSlots);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(628, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(628, 599);
            this.Name = "Book_Shift";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Book a Shift";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Book_Shift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtp;
        private MetroFramework.Controls.MetroLabel lblDetails;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtAvailableSlots;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAvailable;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtTimeSlot;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}