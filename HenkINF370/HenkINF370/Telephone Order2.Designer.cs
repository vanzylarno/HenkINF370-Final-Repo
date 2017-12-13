namespace HenkINF370
{
    partial class Telephone_Order2
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
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.btnPlaceOrder = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.colToppingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTopping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPizzaSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDrinkSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPizzaBaseID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtPizzaSizeID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtDrinkSizeID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtMenuItemType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtFilter2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFilter1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1252, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 19);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "0";
            this.lblTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(846, 572);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(698, 81);
            this.btnPlaceOrder.TabIndex = 33;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPlaceOrder.UseSelectable = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(846, 353);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(46, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "Extras:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // colToppingPrice
            // 
            this.colToppingPrice.HeaderText = "Price";
            this.colToppingPrice.Name = "colToppingPrice";
            this.colToppingPrice.ReadOnly = true;
            // 
            // colTopping
            // 
            this.colTopping.HeaderText = "Toppings";
            this.colTopping.Name = "colTopping";
            this.colTopping.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTopping,
            this.colToppingPrice});
            this.dataGridView2.Location = new System.Drawing.Point(846, 375);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(698, 150);
            this.dataGridView2.TabIndex = 31;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(846, 297);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(698, 45);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Customise Order";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(846, 58);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 19);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "Your Order:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colPizzaBase
            // 
            this.colPizzaBase.HeaderText = "Pizza Base";
            this.colPizzaBase.Name = "colPizzaBase";
            // 
            // colPizzaSize
            // 
            this.colPizzaSize.HeaderText = "Pizza Size";
            this.colPizzaSize.Name = "colPizzaSize";
            // 
            // colDrinkSize
            // 
            this.colDrinkSize.HeaderText = "Drink Size";
            this.colDrinkSize.Name = "colDrinkSize";
            // 
            // colItemName
            // 
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.Name = "colItemName";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(1063, 27);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(183, 19);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "Order Total (Excluding VAT): R";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemName,
            this.colDrinkSize,
            this.colPizzaSize,
            this.colPizzaBase,
            this.colPrice});
            this.dataGridView1.Location = new System.Drawing.Point(846, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 211);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(276, 572);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(538, 81);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add Item To Order";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtPizzaBaseID);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.txtPizzaSizeID);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.txtDrinkSizeID);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.txtMenuItemType);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Location = new System.Drawing.Point(276, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 485);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 190);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtPizzaBaseID
            // 
            // 
            // 
            // 
            this.txtPizzaBaseID.CustomButton.Image = null;
            this.txtPizzaBaseID.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtPizzaBaseID.CustomButton.Name = "";
            this.txtPizzaBaseID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPizzaBaseID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPizzaBaseID.CustomButton.TabIndex = 1;
            this.txtPizzaBaseID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPizzaBaseID.CustomButton.UseSelectable = true;
            this.txtPizzaBaseID.CustomButton.Visible = false;
            this.txtPizzaBaseID.Lines = new string[0];
            this.txtPizzaBaseID.Location = new System.Drawing.Point(263, 239);
            this.txtPizzaBaseID.MaxLength = 32767;
            this.txtPizzaBaseID.Name = "txtPizzaBaseID";
            this.txtPizzaBaseID.PasswordChar = '\0';
            this.txtPizzaBaseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPizzaBaseID.SelectedText = "";
            this.txtPizzaBaseID.SelectionLength = 0;
            this.txtPizzaBaseID.SelectionStart = 0;
            this.txtPizzaBaseID.ShortcutsEnabled = true;
            this.txtPizzaBaseID.Size = new System.Drawing.Size(240, 23);
            this.txtPizzaBaseID.TabIndex = 15;
            this.txtPizzaBaseID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPizzaBaseID.UseSelectable = true;
            this.txtPizzaBaseID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPizzaBaseID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(263, 217);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(73, 19);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Pizza Base:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPizzaSizeID
            // 
            // 
            // 
            // 
            this.txtPizzaSizeID.CustomButton.Image = null;
            this.txtPizzaSizeID.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtPizzaSizeID.CustomButton.Name = "";
            this.txtPizzaSizeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPizzaSizeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPizzaSizeID.CustomButton.TabIndex = 1;
            this.txtPizzaSizeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPizzaSizeID.CustomButton.UseSelectable = true;
            this.txtPizzaSizeID.CustomButton.Visible = false;
            this.txtPizzaSizeID.Lines = new string[0];
            this.txtPizzaSizeID.Location = new System.Drawing.Point(263, 188);
            this.txtPizzaSizeID.MaxLength = 32767;
            this.txtPizzaSizeID.Name = "txtPizzaSizeID";
            this.txtPizzaSizeID.PasswordChar = '\0';
            this.txtPizzaSizeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPizzaSizeID.SelectedText = "";
            this.txtPizzaSizeID.SelectionLength = 0;
            this.txtPizzaSizeID.SelectionStart = 0;
            this.txtPizzaSizeID.ShortcutsEnabled = true;
            this.txtPizzaSizeID.Size = new System.Drawing.Size(240, 23);
            this.txtPizzaSizeID.TabIndex = 13;
            this.txtPizzaSizeID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPizzaSizeID.UseSelectable = true;
            this.txtPizzaSizeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPizzaSizeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(263, 166);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 19);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Pizza Size:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDrinkSizeID
            // 
            // 
            // 
            // 
            this.txtDrinkSizeID.CustomButton.Image = null;
            this.txtDrinkSizeID.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtDrinkSizeID.CustomButton.Name = "";
            this.txtDrinkSizeID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDrinkSizeID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDrinkSizeID.CustomButton.TabIndex = 1;
            this.txtDrinkSizeID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDrinkSizeID.CustomButton.UseSelectable = true;
            this.txtDrinkSizeID.CustomButton.Visible = false;
            this.txtDrinkSizeID.Lines = new string[0];
            this.txtDrinkSizeID.Location = new System.Drawing.Point(263, 133);
            this.txtDrinkSizeID.MaxLength = 32767;
            this.txtDrinkSizeID.Name = "txtDrinkSizeID";
            this.txtDrinkSizeID.PasswordChar = '\0';
            this.txtDrinkSizeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDrinkSizeID.SelectedText = "";
            this.txtDrinkSizeID.SelectionLength = 0;
            this.txtDrinkSizeID.SelectionStart = 0;
            this.txtDrinkSizeID.ShortcutsEnabled = true;
            this.txtDrinkSizeID.Size = new System.Drawing.Size(240, 23);
            this.txtDrinkSizeID.TabIndex = 11;
            this.txtDrinkSizeID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDrinkSizeID.UseSelectable = true;
            this.txtDrinkSizeID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDrinkSizeID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(263, 111);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Drink Size:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtMenuItemType
            // 
            // 
            // 
            // 
            this.txtMenuItemType.CustomButton.Image = null;
            this.txtMenuItemType.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtMenuItemType.CustomButton.Name = "";
            this.txtMenuItemType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMenuItemType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMenuItemType.CustomButton.TabIndex = 1;
            this.txtMenuItemType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMenuItemType.CustomButton.UseSelectable = true;
            this.txtMenuItemType.CustomButton.Visible = false;
            this.txtMenuItemType.Lines = new string[0];
            this.txtMenuItemType.Location = new System.Drawing.Point(263, 82);
            this.txtMenuItemType.MaxLength = 32767;
            this.txtMenuItemType.Name = "txtMenuItemType";
            this.txtMenuItemType.PasswordChar = '\0';
            this.txtMenuItemType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMenuItemType.SelectedText = "";
            this.txtMenuItemType.SelectionLength = 0;
            this.txtMenuItemType.SelectionStart = 0;
            this.txtMenuItemType.ShortcutsEnabled = true;
            this.txtMenuItemType.Size = new System.Drawing.Size(240, 23);
            this.txtMenuItemType.TabIndex = 7;
            this.txtMenuItemType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtMenuItemType.UseSelectable = true;
            this.txtMenuItemType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMenuItemType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(263, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(69, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Item Type:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(-30, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(269, 269);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(3, 188);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(240, 271);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Description:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(3, 133);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(240, 23);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 111);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Price:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(3, 82);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(240, 23);
            this.txtItemName.TabIndex = 3;
            this.txtItemName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Item Name:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(222, 4);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Item Information:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFilter2
            // 
            // 
            // 
            // 
            this.txtFilter2.CustomButton.Image = null;
            this.txtFilter2.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtFilter2.CustomButton.Name = "";
            this.txtFilter2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter2.CustomButton.TabIndex = 1;
            this.txtFilter2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter2.CustomButton.UseSelectable = true;
            this.txtFilter2.CustomButton.Visible = false;
            this.txtFilter2.Lines = new string[0];
            this.txtFilter2.Location = new System.Drawing.Point(17, 132);
            this.txtFilter2.MaxLength = 32767;
            this.txtFilter2.Name = "txtFilter2";
            this.txtFilter2.PasswordChar = '\0';
            this.txtFilter2.PromptText = "Please Enter the Item\'s Price";
            this.txtFilter2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter2.SelectedText = "";
            this.txtFilter2.SelectionLength = 0;
            this.txtFilter2.SelectionStart = 0;
            this.txtFilter2.ShortcutsEnabled = true;
            this.txtFilter2.Size = new System.Drawing.Size(240, 23);
            this.txtFilter2.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter2.TabIndex = 24;
            this.txtFilter2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter2.UseSelectable = true;
            this.txtFilter2.WaterMark = "Please Enter the Item\'s Price";
            this.txtFilter2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter2.TextChanged += new System.EventHandler(this.txtFilter2_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(71, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Item Price:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFilter1
            // 
            // 
            // 
            // 
            this.txtFilter1.CustomButton.Image = null;
            this.txtFilter1.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.txtFilter1.CustomButton.Name = "";
            this.txtFilter1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter1.CustomButton.TabIndex = 1;
            this.txtFilter1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter1.CustomButton.UseSelectable = true;
            this.txtFilter1.CustomButton.Visible = false;
            this.txtFilter1.Lines = new string[0];
            this.txtFilter1.Location = new System.Drawing.Point(17, 80);
            this.txtFilter1.MaxLength = 32767;
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.PasswordChar = '\0';
            this.txtFilter1.PromptText = "Please Enter the Item\'s Name";
            this.txtFilter1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter1.SelectedText = "";
            this.txtFilter1.SelectionLength = 0;
            this.txtFilter1.SelectionStart = 0;
            this.txtFilter1.ShortcutsEnabled = true;
            this.txtFilter1.Size = new System.Drawing.Size(240, 23);
            this.txtFilter1.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter1.TabIndex = 22;
            this.txtFilter1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter1.UseSelectable = true;
            this.txtFilter1.WaterMark = "Please Enter the Item\'s Name";
            this.txtFilter1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Item Name:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 162);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 494);
            this.listBox1.TabIndex = 25;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Telephone_Order2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 682);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilter2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(1561, 682);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1561, 682);
            this.Movable = false;
            this.Name = "Telephone_Order2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Place a New Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Telephone_Order2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroButton btnPlaceOrder;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToppingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTopping;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPizzaSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrinkSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtPizzaBaseID;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtPizzaSizeID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtDrinkSizeID;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtMenuItemType;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtFilter2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFilter1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}