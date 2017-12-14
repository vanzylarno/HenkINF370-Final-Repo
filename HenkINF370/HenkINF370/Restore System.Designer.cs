namespace HenkINF370
{
    partial class Restore_System
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
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.cbxDatabaseName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFilename = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnRestore = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // cbxDatabaseName
            // 
            this.cbxDatabaseName.FormattingEnabled = true;
            this.cbxDatabaseName.ItemHeight = 23;
            this.cbxDatabaseName.Location = new System.Drawing.Point(23, 85);
            this.cbxDatabaseName.Name = "cbxDatabaseName";
            this.cbxDatabaseName.Size = new System.Drawing.Size(275, 29);
            this.cbxDatabaseName.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxDatabaseName.TabIndex = 18;
            this.cbxDatabaseName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDatabaseName.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 17;
            this.metroLabel2.Text = "Select Database Name:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtFilename
            // 
            // 
            // 
            // 
            this.txtFilename.CustomButton.Image = null;
            this.txtFilename.CustomButton.Location = new System.Drawing.Point(254, 1);
            this.txtFilename.CustomButton.Name = "";
            this.txtFilename.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilename.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilename.CustomButton.TabIndex = 1;
            this.txtFilename.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilename.CustomButton.UseSelectable = true;
            this.txtFilename.CustomButton.Visible = false;
            this.txtFilename.Enabled = false;
            this.txtFilename.Lines = new string[0];
            this.txtFilename.Location = new System.Drawing.Point(23, 184);
            this.txtFilename.MaxLength = 32767;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.PasswordChar = '\0';
            this.txtFilename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilename.SelectedText = "";
            this.txtFilename.SelectionLength = 0;
            this.txtFilename.SelectionStart = 0;
            this.txtFilename.ShortcutsEnabled = true;
            this.txtFilename.Size = new System.Drawing.Size(276, 23);
            this.txtFilename.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilename.TabIndex = 16;
            this.txtFilename.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilename.UseSelectable = true;
            this.txtFilename.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilename.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(22, 120);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(276, 58);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Browse For Database File";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(23, 213);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(276, 58);
            this.btnRestore.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRestore.TabIndex = 14;
            this.btnRestore.Text = "Restore Database";
            this.btnRestore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRestore.UseSelectable = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // Restore_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 293);
            this.Controls.Add(this.cbxDatabaseName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRestore);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(312, 293);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(312, 293);
            this.Name = "Restore_System";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Restore System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Restore_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFD;
        private MetroFramework.Controls.MetroComboBox cbxDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtFilename;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnRestore;
    }
}