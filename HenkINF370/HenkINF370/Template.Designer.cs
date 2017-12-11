namespace HenkINF370
{
    partial class Template
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFriday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSaturday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSunday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtAvailableSlots = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeSlot,
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colFriday,
            this.colSaturday,
            this.colSunday});
            this.dataGridView1.Location = new System.Drawing.Point(23, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1212, 334);
            this.dataGridView1.TabIndex = 2;
            // 
            // colTimeSlot
            // 
            this.colTimeSlot.HeaderText = "Time Slot";
            this.colTimeSlot.Name = "colTimeSlot";
            // 
            // colMonday
            // 
            this.colMonday.HeaderText = "Monday";
            this.colMonday.Name = "colMonday";
            this.colMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTuesday
            // 
            this.colTuesday.HeaderText = "Tuesday";
            this.colTuesday.Name = "colTuesday";
            this.colTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colWednesday
            // 
            this.colWednesday.HeaderText = "Wednesday";
            this.colWednesday.Name = "colWednesday";
            this.colWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colThursday
            // 
            this.colThursday.HeaderText = "Thursday";
            this.colThursday.Name = "colThursday";
            this.colThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFriday
            // 
            this.colFriday.HeaderText = "Friday";
            this.colFriday.Name = "colFriday";
            this.colFriday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSaturday
            // 
            this.colSaturday.HeaderText = "Saturday";
            this.colSaturday.Name = "colSaturday";
            this.colSaturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSaturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSunday
            // 
            this.colSunday.HeaderText = "Sunday";
            this.colSunday.Name = "colSunday";
            this.colSunday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(23, 79);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(281, 29);
            this.dtpDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Select Week Start Date:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1004, 482);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(231, 68);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Create Weekly Schedule";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtAvailableSlots
            // 
            // 
            // 
            // 
            this.txtAvailableSlots.CustomButton.Image = null;
            this.txtAvailableSlots.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtAvailableSlots.CustomButton.Name = "";
            this.txtAvailableSlots.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAvailableSlots.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAvailableSlots.CustomButton.TabIndex = 1;
            this.txtAvailableSlots.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAvailableSlots.CustomButton.UseSelectable = true;
            this.txtAvailableSlots.CustomButton.Visible = false;
            this.txtAvailableSlots.Lines = new string[0];
            this.txtAvailableSlots.Location = new System.Drawing.Point(336, 85);
            this.txtAvailableSlots.MaxLength = 32767;
            this.txtAvailableSlots.Name = "txtAvailableSlots";
            this.txtAvailableSlots.PasswordChar = '\0';
            this.txtAvailableSlots.PromptText = "Please Enter the Amount of Available Slots";
            this.txtAvailableSlots.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAvailableSlots.SelectedText = "";
            this.txtAvailableSlots.SelectionLength = 0;
            this.txtAvailableSlots.SelectionStart = 0;
            this.txtAvailableSlots.ShortcutsEnabled = true;
            this.txtAvailableSlots.Size = new System.Drawing.Size(247, 23);
            this.txtAvailableSlots.TabIndex = 6;
            this.txtAvailableSlots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAvailableSlots.UseSelectable = true;
            this.txtAvailableSlots.WaterMark = "Please Enter the Amount of Available Slots";
            this.txtAvailableSlots.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAvailableSlots.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(336, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Enter the Available Slots:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 568);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtAvailableSlots);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1258, 568);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1258, 568);
            this.Name = "Template";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Template";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Template_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeSlot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFriday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSaturday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSunday;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtAvailableSlots;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}