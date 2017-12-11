namespace HenkINF370
{
    partial class Update_a_Combo
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
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrinkSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFilter2 = new MetroFramework.Controls.MetroTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtExpireDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(252, 79);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(99, 19);
            this.metroLabel9.TabIndex = 44;
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
            this.dataGridView1.Location = new System.Drawing.Point(252, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(605, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPizzaBase
            // 
            this.colPizzaBase.HeaderText = "Pizza Base";
            this.colPizzaBase.Name = "colPizzaBase";
            this.colPizzaBase.ReadOnly = true;
            // 
            // colPizzaSize
            // 
            this.colPizzaSize.HeaderText = "Pizza Size";
            this.colPizzaSize.Name = "colPizzaSize";
            this.colPizzaSize.ReadOnly = true;
            // 
            // colDrinkSize
            // 
            this.colDrinkSize.HeaderText = "Drink Size";
            this.colDrinkSize.Name = "colDrinkSize";
            this.colDrinkSize.ReadOnly = true;
            // 
            // txtFilter2
            // 
            // 
            // 
            // 
            this.txtFilter2.CustomButton.Image = null;
            this.txtFilter2.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtFilter2.CustomButton.Name = "";
            this.txtFilter2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter2.CustomButton.TabIndex = 1;
            this.txtFilter2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter2.CustomButton.UseSelectable = true;
            this.txtFilter2.CustomButton.Visible = false;
            this.txtFilter2.Lines = new string[0];
            this.txtFilter2.Location = new System.Drawing.Point(23, 111);
            this.txtFilter2.MaxLength = 32767;
            this.txtFilter2.Name = "txtFilter2";
            this.txtFilter2.PasswordChar = '\0';
            this.txtFilter2.PromptText = "Please enter a Price";
            this.txtFilter2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter2.SelectedText = "";
            this.txtFilter2.SelectionLength = 0;
            this.txtFilter2.SelectionStart = 0;
            this.txtFilter2.ShortcutsEnabled = true;
            this.txtFilter2.Size = new System.Drawing.Size(210, 23);
            this.txtFilter2.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter2.TabIndex = 52;
            this.txtFilter2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter2.UseSelectable = true;
            this.txtFilter2.WaterMark = "Please enter a Price";
            this.txtFilter2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter2.TextChanged += new System.EventHandler(this.txtFilter2_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 403);
            this.listBox1.TabIndex = 42;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter
            // 
            // 
            // 
            // 
            this.txtFilter.CustomButton.Image = null;
            this.txtFilter.CustomButton.Location = new System.Drawing.Point(188, 1);
            this.txtFilter.CustomButton.Name = "";
            this.txtFilter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter.CustomButton.TabIndex = 1;
            this.txtFilter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter.CustomButton.UseSelectable = true;
            this.txtFilter.CustomButton.Visible = false;
            this.txtFilter.Lines = new string[0];
            this.txtFilter.Location = new System.Drawing.Point(23, 82);
            this.txtFilter.MaxLength = 32767;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PromptText = "Please Enter a Item Name";
            this.txtFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter.SelectedText = "";
            this.txtFilter.SelectionLength = 0;
            this.txtFilter.SelectionStart = 0;
            this.txtFilter.ShortcutsEnabled = true;
            this.txtFilter.Size = new System.Drawing.Size(210, 23);
            this.txtFilter.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter.TabIndex = 41;
            this.txtFilter.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter.UseSelectable = true;
            this.txtFilter.WaterMark = "Please Enter a Item Name";
            this.txtFilter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(252, 307);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "Combo Description:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(481, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(252, 329);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(605, 125);
            this.txtDescription.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtDescription.TabIndex = 50;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(566, 253);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(150, 19);
            this.metroLabel3.TabIndex = 49;
            this.metroLabel3.Text = "Combo Expiration Date:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtExpireDate
            // 
            // 
            // 
            // 
            this.txtExpireDate.CustomButton.Image = null;
            this.txtExpireDate.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.txtExpireDate.CustomButton.Name = "";
            this.txtExpireDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtExpireDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExpireDate.CustomButton.TabIndex = 1;
            this.txtExpireDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExpireDate.CustomButton.UseSelectable = true;
            this.txtExpireDate.CustomButton.Visible = false;
            this.txtExpireDate.Lines = new string[0];
            this.txtExpireDate.Location = new System.Drawing.Point(566, 275);
            this.txtExpireDate.MaxLength = 32767;
            this.txtExpireDate.Name = "txtExpireDate";
            this.txtExpireDate.PasswordChar = '\0';
            this.txtExpireDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExpireDate.SelectedText = "";
            this.txtExpireDate.SelectionLength = 0;
            this.txtExpireDate.SelectionStart = 0;
            this.txtExpireDate.ShortcutsEnabled = true;
            this.txtExpireDate.Size = new System.Drawing.Size(291, 23);
            this.txtExpireDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtExpireDate.TabIndex = 48;
            this.txtExpireDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtExpireDate.UseSelectable = true;
            this.txtExpireDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExpireDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(252, 253);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Combo Price:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(252, 275);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(272, 23);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrice.TabIndex = 46;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Select a Combo:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(252, 478);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(605, 65);
            this.metroButton1.TabIndex = 53;
            this.metroButton1.Text = "Update Combo";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Update_a_Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 559);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFilter2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtExpireDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(884, 559);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(884, 559);
            this.Name = "Update_a_Combo";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update a Combo";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Update_a_Combo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrinkSize;
        private MetroFramework.Controls.MetroTextBox txtFilter2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtExpireDate;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}