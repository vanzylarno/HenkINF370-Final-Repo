namespace HenkINF370
{
    partial class Update_Shift2
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
            this.lblDetails = new MetroFramework.Controls.MetroLabel();
            this.cbxAvailable = new MetroFramework.Controls.MetroComboBox();
            this.cbxDay = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.AvailableSlots = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDetails.Location = new System.Drawing.Point(392, 74);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(223, 171);
            this.lblDetails.Style = MetroFramework.MetroColorStyle.Lime;
            this.lblDetails.TabIndex = 51;
            this.lblDetails.Text = "Help!\r\n\r\nTo Update a Shift please provide all\r\nthe information required into\r\nthe" +
    " fields provided!\r\n\r\n\r\n\r\n";
            this.lblDetails.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDetails.UseCustomForeColor = true;
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.FormattingEnabled = true;
            this.cbxAvailable.ItemHeight = 23;
            this.cbxAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxAvailable.Location = new System.Drawing.Point(34, 209);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(311, 29);
            this.cbxAvailable.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxAvailable.TabIndex = 50;
            this.cbxAvailable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxAvailable.UseSelectable = true;
            // 
            // cbxDay
            // 
            this.cbxDay.FormattingEnabled = true;
            this.cbxDay.ItemHeight = 23;
            this.cbxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbxDay.Location = new System.Drawing.Point(35, 97);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(311, 29);
            this.cbxDay.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxDay.TabIndex = 49;
            this.cbxDay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDay.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(378, 299);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(237, 45);
            this.metroButton1.TabIndex = 48;
            this.metroButton1.Text = "Update Shift";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(34, 265);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(312, 29);
            this.dtpDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpDate.TabIndex = 47;
            this.dtpDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtpDate.Value = new System.DateTime(2017, 12, 9, 0, 0, 0, 0);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(34, 299);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel5.TabIndex = 46;
            this.metroLabel5.Text = "Available Slots:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AvailableSlots
            // 
            // 
            // 
            // 
            this.AvailableSlots.CustomButton.Image = null;
            this.AvailableSlots.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.AvailableSlots.CustomButton.Name = "";
            this.AvailableSlots.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AvailableSlots.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AvailableSlots.CustomButton.TabIndex = 1;
            this.AvailableSlots.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AvailableSlots.CustomButton.UseSelectable = true;
            this.AvailableSlots.CustomButton.Visible = false;
            this.AvailableSlots.Lines = new string[0];
            this.AvailableSlots.Location = new System.Drawing.Point(34, 321);
            this.AvailableSlots.MaxLength = 32767;
            this.AvailableSlots.Name = "AvailableSlots";
            this.AvailableSlots.PasswordChar = '\0';
            this.AvailableSlots.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AvailableSlots.SelectedText = "";
            this.AvailableSlots.SelectionLength = 0;
            this.AvailableSlots.SelectionStart = 0;
            this.AvailableSlots.ShortcutsEnabled = true;
            this.AvailableSlots.Size = new System.Drawing.Size(312, 23);
            this.AvailableSlots.Style = MetroFramework.MetroColorStyle.Lime;
            this.AvailableSlots.TabIndex = 45;
            this.AvailableSlots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AvailableSlots.UseSelectable = true;
            this.AvailableSlots.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AvailableSlots.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 242);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = "Date:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(34, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Available:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(34, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "Timeslot:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtTime
            // 
            // 
            // 
            // 
            this.txtTime.CustomButton.Image = null;
            this.txtTime.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtTime.CustomButton.Name = "";
            this.txtTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTime.CustomButton.TabIndex = 1;
            this.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTime.CustomButton.UseSelectable = true;
            this.txtTime.CustomButton.Visible = false;
            this.txtTime.Lines = new string[0];
            this.txtTime.Location = new System.Drawing.Point(34, 154);
            this.txtTime.MaxLength = 32767;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.ShortcutsEnabled = true;
            this.txtTime.Size = new System.Drawing.Size(312, 23);
            this.txtTime.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtTime.TabIndex = 41;
            this.txtTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTime.UseSelectable = true;
            this.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Day:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Update_Shift2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 376);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cbxAvailable);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.AvailableSlots);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 376);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 376);
            this.Name = "Update_Shift2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update Shift";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Update_Shift2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDetails;
        private MetroFramework.Controls.MetroComboBox cbxAvailable;
        private MetroFramework.Controls.MetroComboBox cbxDay;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox AvailableSlots;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}