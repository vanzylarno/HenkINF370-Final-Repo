namespace HenkINF370
{
    partial class Backup_System
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
            this.btnCreatebackup = new MetroFramework.Controls.MetroButton();
            this.cbxDatabaseName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCreatebackup
            // 
            this.btnCreatebackup.Location = new System.Drawing.Point(22, 143);
            this.btnCreatebackup.Name = "btnCreatebackup";
            this.btnCreatebackup.Size = new System.Drawing.Size(276, 58);
            this.btnCreatebackup.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCreatebackup.TabIndex = 9;
            this.btnCreatebackup.Text = "Create Database Backup";
            this.btnCreatebackup.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreatebackup.UseSelectable = true;
            this.btnCreatebackup.Click += new System.EventHandler(this.btnCreatebackup_Click);
            // 
            // cbxDatabaseName
            // 
            this.cbxDatabaseName.FormattingEnabled = true;
            this.cbxDatabaseName.ItemHeight = 23;
            this.cbxDatabaseName.Location = new System.Drawing.Point(23, 108);
            this.cbxDatabaseName.Name = "cbxDatabaseName";
            this.cbxDatabaseName.Size = new System.Drawing.Size(275, 29);
            this.cbxDatabaseName.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxDatabaseName.TabIndex = 8;
            this.cbxDatabaseName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxDatabaseName.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Select Database Name:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Backup_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 220);
            this.Controls.Add(this.btnCreatebackup);
            this.Controls.Add(this.cbxDatabaseName);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(317, 220);
            this.Name = "Backup_System";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Backup System";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Backup_System_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCreatebackup;
        private MetroFramework.Controls.MetroComboBox cbxDatabaseName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}