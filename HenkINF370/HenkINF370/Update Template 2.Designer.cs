namespace HenkINF370
{
    partial class Update_Template_2
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbxDay = new MetroFramework.Controls.MetroComboBox();
            this.txtTimeSlot = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxAvailable = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAvailableSlots = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select a Day:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.cbxDay.Location = new System.Drawing.Point(23, 104);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(241, 29);
            this.cbxDay.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxDay.TabIndex = 1;
            this.cbxDay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDay.UseSelectable = true;
            // 
            // txtTimeSlot
            // 
            // 
            // 
            // 
            this.txtTimeSlot.CustomButton.Image = null;
            this.txtTimeSlot.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtTimeSlot.CustomButton.Name = "";
            this.txtTimeSlot.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimeSlot.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeSlot.CustomButton.TabIndex = 1;
            this.txtTimeSlot.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeSlot.CustomButton.UseSelectable = true;
            this.txtTimeSlot.CustomButton.Visible = false;
            this.txtTimeSlot.Lines = new string[0];
            this.txtTimeSlot.Location = new System.Drawing.Point(23, 165);
            this.txtTimeSlot.MaxLength = 32767;
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.PasswordChar = '\0';
            this.txtTimeSlot.PromptText = "Please Enter a Time Slot";
            this.txtTimeSlot.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeSlot.SelectedText = "";
            this.txtTimeSlot.SelectionLength = 0;
            this.txtTimeSlot.SelectionStart = 0;
            this.txtTimeSlot.ShortcutsEnabled = true;
            this.txtTimeSlot.Size = new System.Drawing.Size(241, 23);
            this.txtTimeSlot.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtTimeSlot.TabIndex = 2;
            this.txtTimeSlot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtTimeSlot.UseSelectable = true;
            this.txtTimeSlot.WaterMark = "Please Enter a Time Slot";
            this.txtTimeSlot.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeSlot.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 143);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Time Slot:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.FormattingEnabled = true;
            this.cbxAvailable.ItemHeight = 23;
            this.cbxAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbxAvailable.Location = new System.Drawing.Point(23, 222);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(241, 29);
            this.cbxAvailable.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxAvailable.TabIndex = 4;
            this.cbxAvailable.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxAvailable.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Available:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(23, 285);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 29);
            this.dtpDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 263);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Select Week Start:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 321);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Available Slots:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAvailableSlots
            // 
            // 
            // 
            // 
            this.txtAvailableSlots.CustomButton.Image = null;
            this.txtAvailableSlots.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtAvailableSlots.CustomButton.Name = "";
            this.txtAvailableSlots.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvailableSlots.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvailableSlots.CustomButton.TabIndex = 1;
            this.txtAvailableSlots.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvailableSlots.CustomButton.UseSelectable = true;
            this.txtAvailableSlots.CustomButton.Visible = false;
            this.txtAvailableSlots.Lines = new string[0];
            this.txtAvailableSlots.Location = new System.Drawing.Point(23, 343);
            this.txtAvailableSlots.MaxLength = 32767;
            this.txtAvailableSlots.Name = "txtAvailableSlots";
            this.txtAvailableSlots.PasswordChar = '\0';
            this.txtAvailableSlots.PromptText = "Please Enter the Amount of Slots Available";
            this.txtAvailableSlots.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvailableSlots.SelectedText = "";
            this.txtAvailableSlots.SelectionLength = 0;
            this.txtAvailableSlots.SelectionStart = 0;
            this.txtAvailableSlots.ShortcutsEnabled = true;
            this.txtAvailableSlots.Size = new System.Drawing.Size(241, 23);
            this.txtAvailableSlots.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAvailableSlots.TabIndex = 8;
            this.txtAvailableSlots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAvailableSlots.UseSelectable = true;
            this.txtAvailableSlots.WaterMark = "Please Enter the Amount of Slots Available";
            this.txtAvailableSlots.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvailableSlots.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 380);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(241, 72);
            this.metroButton1.TabIndex = 10;
            this.metroButton1.Text = "Update Shift";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Update_Template_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 475);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtAvailableSlots);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbxAvailable);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(299, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 475);
            this.Name = "Update_Template_2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update a Shift";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Update_Template_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbxDay;
        private MetroFramework.Controls.MetroTextBox txtTimeSlot;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxAvailable;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAvailableSlots;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}