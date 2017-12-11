namespace HenkINF370
{
    partial class Update_Template
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
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.cbxTimeSlots = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxDay = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.colAvailableSlots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.colTimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAdapterManager = new HenkINF370.HenkINF370DataSetTableAdapters.TableAdapterManager();
            this.shiftsTableAdapter = new HenkINF370.HenkINF370DataSetTableAdapters.ShiftsTableAdapter();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.henkINF370DataSet = new HenkINF370.HenkINF370DataSet();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.henkINF370DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1107, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 69);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Update Shift";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxTimeSlots
            // 
            this.cbxTimeSlots.FormattingEnabled = true;
            this.cbxTimeSlots.ItemHeight = 23;
            this.cbxTimeSlots.Location = new System.Drawing.Point(670, 93);
            this.cbxTimeSlots.Name = "cbxTimeSlots";
            this.cbxTimeSlots.Size = new System.Drawing.Size(240, 29);
            this.cbxTimeSlots.TabIndex = 43;
            this.cbxTimeSlots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxTimeSlots.UseSelectable = true;
            this.cbxTimeSlots.SelectedIndexChanged += new System.EventHandler(this.cbxTimeSlots_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(670, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Select Time Slot:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            this.cbxDay.Location = new System.Drawing.Point(378, 94);
            this.cbxDay.Name = "cbxDay";
            this.cbxDay.Size = new System.Drawing.Size(240, 29);
            this.cbxDay.TabIndex = 41;
            this.cbxDay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDay.UseSelectable = true;
            this.cbxDay.SelectedIndexChanged += new System.EventHandler(this.cbxDay_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(378, 71);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Select Day:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // colAvailableSlots
            // 
            this.colAvailableSlots.HeaderText = "Available Slots";
            this.colAvailableSlots.Name = "colAvailableSlots";
            this.colAvailableSlots.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Week Start Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(928, 53);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(162, 69);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Show All Availble Slots";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // colTimeSlot
            // 
            this.colTimeSlot.HeaderText = "Time Slot";
            this.colTimeSlot.Name = "colTimeSlot";
            this.colTimeSlot.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay,
            this.colTimeSlot,
            this.colDate,
            this.colAvailableSlots});
            this.dataGridView1.Location = new System.Drawing.Point(23, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1246, 429);
            this.dataGridView1.TabIndex = 44;
            // 
            // colDay
            // 
            this.colDay.HeaderText = "Day";
            this.colDay.Name = "colDay";
            this.colDay.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComboRecordsTableAdapter = null;
            this.tableAdapterManager.CombosTableAdapter = null;
            this.tableAdapterManager.CustomisationTableAdapter = null;
            this.tableAdapterManager.DrinkSizeTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.MenuItemTypeTableAdapter = null;
            this.tableAdapterManager.MenuTableAdapter = null;
            this.tableAdapterManager.PizzaBaseTableAdapter = null;
            this.tableAdapterManager.PizzaSizeTableAdapter = null;
            this.tableAdapterManager.PrivilegeTableAdapter = null;
            this.tableAdapterManager.ShiftLineTableAdapter = null;
            this.tableAdapterManager.ShiftsTableAdapter = this.shiftsTableAdapter;
            this.tableAdapterManager.TitleTableAdapter = null;
            this.tableAdapterManager.ToppingRecordTableAdapter = null;
            this.tableAdapterManager.ToppingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HenkINF370.HenkINF370DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTypeTableAdapter = null;
            // 
            // shiftsTableAdapter
            // 
            this.shiftsTableAdapter.ClearBeforeFill = true;
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this.henkINF370DataSet;
            // 
            // henkINF370DataSet
            // 
            this.henkINF370DataSet.DataSetName = "HenkINF370DataSet";
            this.henkINF370DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(23, 93);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(281, 29);
            this.dtpDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpDate.TabIndex = 38;
            this.dtpDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 39;
            this.metroLabel1.Text = "Select Week Start Date:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Update_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 580);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbxTimeSlots);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbxDay);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1298, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1298, 580);
            this.Name = "Update_Template";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update a Shift";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Update_Template_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.henkINF370DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroComboBox cbxTimeSlots;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxDay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeSlot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay;
        private HenkINF370DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HenkINF370DataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private HenkINF370DataSet henkINF370DataSet;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}