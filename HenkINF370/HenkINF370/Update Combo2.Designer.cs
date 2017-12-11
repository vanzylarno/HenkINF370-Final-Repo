namespace HenkINF370
{
    partial class Update_Combo2
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
            this.btnCreate = new MetroFramework.Controls.MetroButton();
            this.colPizzaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDrinkSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpExpirationDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbxDrinkSize = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbxPizzaSize = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbxPizzaBase = new MetroFramework.Controls.MetroComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tctFilter1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(620, 425);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(605, 61);
            this.btnCreate.TabIndex = 39;
            this.btnCreate.Text = "Update Combo";
            this.btnCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // colPizzaSize
            // 
            this.colPizzaSize.HeaderText = "Pizza Size";
            this.colPizzaSize.Name = "colPizzaSize";
            this.colPizzaSize.ReadOnly = true;
            // 
            // colPizzaBase
            // 
            this.colPizzaBase.HeaderText = "Pizza Base";
            this.colPizzaBase.Name = "colPizzaBase";
            this.colPizzaBase.ReadOnly = true;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(620, 49);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(99, 19);
            this.metroLabel9.TabIndex = 38;
            this.metroLabel9.Text = "Combo Details:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colPizzaBase,
            this.colPizzaSize,
            this.colDrinkSize});
            this.dataGridView1.Location = new System.Drawing.Point(620, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(605, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // colDrinkSize
            // 
            this.colDrinkSize.HeaderText = "Drink Size";
            this.colDrinkSize.Name = "colDrinkSize";
            this.colDrinkSize.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(219, 61);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add to Combo";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(908, 226);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(126, 19);
            this.metroLabel8.TabIndex = 35;
            this.metroLabel8.Text = "Combo Description:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(161, 161);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(908, 248);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Provide a Short Combo Description";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(317, 163);
            this.txtDescription.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDescription.TabIndex = 34;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Provide a Short Combo Description";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(620, 274);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(215, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Select the Combo\'s Expiration Date:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Location = new System.Drawing.Point(620, 296);
            this.dtpExpirationDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(219, 29);
            this.dtpExpirationDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpExpirationDate.TabIndex = 32;
            this.dtpExpirationDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(620, 226);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Combo Price:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(620, 248);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PromptText = "Please Enter the Combo\'s Price";
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(219, 23);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrice.TabIndex = 30;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMark = "Please Enter the Combo\'s Price";
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(327, 71);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(200, 19);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Select the following if applicable:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(327, 220);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Drink Size:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxDrinkSize
            // 
            this.cbxDrinkSize.FormattingEnabled = true;
            this.cbxDrinkSize.ItemHeight = 23;
            this.cbxDrinkSize.Location = new System.Drawing.Point(327, 242);
            this.cbxDrinkSize.Name = "cbxDrinkSize";
            this.cbxDrinkSize.Size = new System.Drawing.Size(219, 29);
            this.cbxDrinkSize.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxDrinkSize.TabIndex = 27;
            this.cbxDrinkSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDrinkSize.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(327, 167);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Pizza Size:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxPizzaSize
            // 
            this.cbxPizzaSize.FormattingEnabled = true;
            this.cbxPizzaSize.ItemHeight = 23;
            this.cbxPizzaSize.Location = new System.Drawing.Point(327, 189);
            this.cbxPizzaSize.Name = "cbxPizzaSize";
            this.cbxPizzaSize.Size = new System.Drawing.Size(219, 29);
            this.cbxPizzaSize.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxPizzaSize.TabIndex = 25;
            this.cbxPizzaSize.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxPizzaSize.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(327, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Pizza Base:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxPizzaBase
            // 
            this.cbxPizzaBase.FormattingEnabled = true;
            this.cbxPizzaBase.ItemHeight = 23;
            this.cbxPizzaBase.Location = new System.Drawing.Point(327, 134);
            this.cbxPizzaBase.Name = "cbxPizzaBase";
            this.cbxPizzaBase.Size = new System.Drawing.Size(219, 29);
            this.cbxPizzaBase.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxPizzaBase.TabIndex = 23;
            this.cbxPizzaBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxPizzaBase.UseSelectable = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 351);
            this.listBox1.TabIndex = 22;
            // 
            // tctFilter1
            // 
            // 
            // 
            // 
            this.tctFilter1.CustomButton.Image = null;
            this.tctFilter1.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.tctFilter1.CustomButton.Name = "";
            this.tctFilter1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tctFilter1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tctFilter1.CustomButton.TabIndex = 1;
            this.tctFilter1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tctFilter1.CustomButton.UseSelectable = true;
            this.tctFilter1.CustomButton.Visible = false;
            this.tctFilter1.Lines = new string[0];
            this.tctFilter1.Location = new System.Drawing.Point(23, 104);
            this.tctFilter1.MaxLength = 32767;
            this.tctFilter1.Name = "tctFilter1";
            this.tctFilter1.PasswordChar = '\0';
            this.tctFilter1.PromptText = "Please Enter a the Item\'s Name";
            this.tctFilter1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tctFilter1.SelectedText = "";
            this.tctFilter1.SelectionLength = 0;
            this.tctFilter1.SelectionStart = 0;
            this.tctFilter1.ShortcutsEnabled = true;
            this.tctFilter1.Size = new System.Drawing.Size(253, 23);
            this.tctFilter1.Style = MetroFramework.MetroColorStyle.Lime;
            this.tctFilter1.TabIndex = 21;
            this.tctFilter1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tctFilter1.UseSelectable = true;
            this.tctFilter1.WaterMark = "Please Enter a the Item\'s Name";
            this.tctFilter1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tctFilter1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tctFilter1.TextChanged += new System.EventHandler(this.tctFilter1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(253, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Select what your Combo will comprise of:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Update_Combo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 524);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbxDrinkSize);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbxPizzaSize);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbxPizzaBase);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tctFilter1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1252, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1252, 524);
            this.Name = "Update_Combo2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update a Combo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Update_Combo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrinkSize;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime dtpExpirationDate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbxDrinkSize;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbxPizzaSize;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbxPizzaBase;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox tctFilter1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}