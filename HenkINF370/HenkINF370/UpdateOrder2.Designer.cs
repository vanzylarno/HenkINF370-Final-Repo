namespace HenkINF370
{
    partial class UpdateOrder2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.cbxCustomerType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPaymentAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dtpDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtVAT = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountReceived = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtChange = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cbxPaymentType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtCardNumber = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.cbxCustomerType);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroLabel12);
            this.panel2.Controls.Add(this.txtCardNumber);
            this.panel2.Controls.Add(this.metroLabel11);
            this.panel2.Controls.Add(this.cbxPaymentType);
            this.panel2.Controls.Add(this.metroLabel10);
            this.panel2.Controls.Add(this.txtChange);
            this.panel2.Controls.Add(this.metroLabel9);
            this.panel2.Controls.Add(this.txtAmountReceived);
            this.panel2.Controls.Add(this.metroLabel8);
            this.panel2.Controls.Add(this.txtVAT);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.metroLabel7);
            this.panel2.Controls.Add(this.metroLabel6);
            this.panel2.Controls.Add(this.txtPaymentAmount);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Location = new System.Drawing.Point(350, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 448);
            this.panel2.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 518);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(670, 61);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Update Order";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Customer Details:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 5);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Payment Details:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(12, 66);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Please Enter the Customer\'s Name";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(253, 23);
            this.txtCustomerName.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Please Enter the Customer\'s Name";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 44);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Customer Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 92);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Phone Number";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 114);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PromptText = "Please Enter the Customer\'s Phone Number";
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(253, 23);
            this.txtPhoneNumber.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMark = "Please Enter the Customer\'s Phone Number";
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.ItemHeight = 23;
            this.cbxCustomerType.Location = new System.Drawing.Point(12, 162);
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.Size = new System.Drawing.Size(253, 29);
            this.cbxCustomerType.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxCustomerType.TabIndex = 5;
            this.cbxCustomerType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxCustomerType.UseSelectable = true;
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            this.cbxCustomerType.Click += new System.EventHandler(this.cbxCustomerType_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 140);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Customer Type:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 45);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(113, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Payment Amount:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPaymentAmount
            // 
            // 
            // 
            // 
            this.txtPaymentAmount.CustomButton.Image = null;
            this.txtPaymentAmount.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtPaymentAmount.CustomButton.Name = "";
            this.txtPaymentAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPaymentAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaymentAmount.CustomButton.TabIndex = 1;
            this.txtPaymentAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaymentAmount.CustomButton.UseSelectable = true;
            this.txtPaymentAmount.CustomButton.Visible = false;
            this.txtPaymentAmount.Lines = new string[0];
            this.txtPaymentAmount.Location = new System.Drawing.Point(12, 67);
            this.txtPaymentAmount.MaxLength = 32767;
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.PasswordChar = '\0';
            this.txtPaymentAmount.PromptText = "Please Enter the Payment Amount";
            this.txtPaymentAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaymentAmount.SelectedText = "";
            this.txtPaymentAmount.SelectionLength = 0;
            this.txtPaymentAmount.SelectionStart = 0;
            this.txtPaymentAmount.ShortcutsEnabled = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(253, 23);
            this.txtPaymentAmount.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPaymentAmount.TabIndex = 3;
            this.txtPaymentAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPaymentAmount.UseSelectable = true;
            this.txtPaymentAmount.WaterMark = "Please Enter the Payment Amount";
            this.txtPaymentAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaymentAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPaymentAmount.TextChanged += new System.EventHandler(this.txtPaymentAmount_TextChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(10, 93);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Payment Date:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 117);
            this.dtpDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(253, 29);
            this.dtpDate.Style = MetroFramework.MetroColorStyle.Lime;
            this.dtpDate.TabIndex = 7;
            this.dtpDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(11, 147);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "VAT:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtVAT
            // 
            // 
            // 
            // 
            this.txtVAT.CustomButton.Image = null;
            this.txtVAT.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtVAT.CustomButton.Name = "";
            this.txtVAT.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVAT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVAT.CustomButton.TabIndex = 1;
            this.txtVAT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVAT.CustomButton.UseSelectable = true;
            this.txtVAT.CustomButton.Visible = false;
            this.txtVAT.Lines = new string[0];
            this.txtVAT.Location = new System.Drawing.Point(12, 169);
            this.txtVAT.MaxLength = 32767;
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.PasswordChar = '\0';
            this.txtVAT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVAT.SelectedText = "";
            this.txtVAT.SelectionLength = 0;
            this.txtVAT.SelectionStart = 0;
            this.txtVAT.ShortcutsEnabled = true;
            this.txtVAT.Size = new System.Drawing.Size(253, 23);
            this.txtVAT.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtVAT.TabIndex = 8;
            this.txtVAT.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtVAT.UseSelectable = true;
            this.txtVAT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVAT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 195);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(115, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Amount Received:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtAmountReceived
            // 
            // 
            // 
            // 
            this.txtAmountReceived.CustomButton.Image = null;
            this.txtAmountReceived.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtAmountReceived.CustomButton.Name = "";
            this.txtAmountReceived.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAmountReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountReceived.CustomButton.TabIndex = 1;
            this.txtAmountReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountReceived.CustomButton.UseSelectable = true;
            this.txtAmountReceived.CustomButton.Visible = false;
            this.txtAmountReceived.Lines = new string[0];
            this.txtAmountReceived.Location = new System.Drawing.Point(12, 217);
            this.txtAmountReceived.MaxLength = 32767;
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.PasswordChar = '\0';
            this.txtAmountReceived.PromptText = "Please Enter the Amount Received";
            this.txtAmountReceived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountReceived.SelectedText = "";
            this.txtAmountReceived.SelectionLength = 0;
            this.txtAmountReceived.SelectionStart = 0;
            this.txtAmountReceived.ShortcutsEnabled = true;
            this.txtAmountReceived.Size = new System.Drawing.Size(253, 23);
            this.txtAmountReceived.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtAmountReceived.TabIndex = 10;
            this.txtAmountReceived.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtAmountReceived.UseSelectable = true;
            this.txtAmountReceived.WaterMark = "Please Enter the Amount Received";
            this.txtAmountReceived.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountReceived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.txtAmountReceived_TextChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(11, 247);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(57, 19);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Change:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtChange
            // 
            // 
            // 
            // 
            this.txtChange.CustomButton.Image = null;
            this.txtChange.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtChange.CustomButton.Name = "";
            this.txtChange.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChange.CustomButton.TabIndex = 1;
            this.txtChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChange.CustomButton.UseSelectable = true;
            this.txtChange.CustomButton.Visible = false;
            this.txtChange.Lines = new string[0];
            this.txtChange.Location = new System.Drawing.Point(12, 269);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChange.SelectedText = "";
            this.txtChange.SelectionLength = 0;
            this.txtChange.SelectionStart = 0;
            this.txtChange.ShortcutsEnabled = true;
            this.txtChange.Size = new System.Drawing.Size(253, 23);
            this.txtChange.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtChange.TabIndex = 12;
            this.txtChange.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtChange.UseSelectable = true;
            this.txtChange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(11, 295);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(93, 19);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Payment Type:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.FormattingEnabled = true;
            this.cbxPaymentType.ItemHeight = 23;
            this.cbxPaymentType.Location = new System.Drawing.Point(12, 317);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(253, 29);
            this.cbxPaymentType.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxPaymentType.TabIndex = 14;
            this.cbxPaymentType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxPaymentType.UseSelectable = true;
            this.cbxPaymentType.SelectedIndexChanged += new System.EventHandler(this.cbxPaymentType_SelectedIndexChanged);
            this.cbxPaymentType.Click += new System.EventHandler(this.cbxPaymentType_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(11, 349);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(95, 19);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Card Number:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtCardNumber
            // 
            // 
            // 
            // 
            this.txtCardNumber.CustomButton.Image = null;
            this.txtCardNumber.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCardNumber.CustomButton.Name = "";
            this.txtCardNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCardNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCardNumber.CustomButton.TabIndex = 1;
            this.txtCardNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCardNumber.CustomButton.UseSelectable = true;
            this.txtCardNumber.CustomButton.Visible = false;
            this.txtCardNumber.Lines = new string[0];
            this.txtCardNumber.Location = new System.Drawing.Point(12, 371);
            this.txtCardNumber.MaxLength = 32767;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.PasswordChar = '\0';
            this.txtCardNumber.PromptText = "Please Enter the Card Number";
            this.txtCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCardNumber.SelectedText = "";
            this.txtCardNumber.SelectionLength = 0;
            this.txtCardNumber.SelectionStart = 0;
            this.txtCardNumber.ShortcutsEnabled = true;
            this.txtCardNumber.Size = new System.Drawing.Size(253, 23);
            this.txtCardNumber.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtCardNumber.TabIndex = 16;
            this.txtCardNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCardNumber.UseSelectable = true;
            this.txtCardNumber.WaterMark = "Please Enter the Card Number";
            this.txtCardNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCardNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UpdateOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 596);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(704, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 596);
            this.Name = "UpdateOrder2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Update Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.UpdateOrder2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbxCustomerType;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtCardNumber;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cbxPaymentType;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtChange;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAmountReceived;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtVAT;
        private MetroFramework.Controls.MetroDateTime dtpDate;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPaymentAmount;
    }
}