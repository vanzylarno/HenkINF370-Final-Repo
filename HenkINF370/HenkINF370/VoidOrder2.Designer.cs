namespace HenkINF370
{
    partial class VoidOrder2
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
            this.txtReason = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(287, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Please Provide a Reason for voiding this Order:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtReason
            // 
            // 
            // 
            // 
            this.txtReason.CustomButton.Image = null;
            this.txtReason.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.txtReason.CustomButton.Name = "";
            this.txtReason.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.txtReason.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReason.CustomButton.TabIndex = 1;
            this.txtReason.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReason.CustomButton.UseSelectable = true;
            this.txtReason.CustomButton.Visible = false;
            this.txtReason.Lines = new string[0];
            this.txtReason.Location = new System.Drawing.Point(24, 87);
            this.txtReason.MaxLength = 32767;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReason.SelectedText = "";
            this.txtReason.SelectionLength = 0;
            this.txtReason.SelectionStart = 0;
            this.txtReason.ShortcutsEnabled = true;
            this.txtReason.Size = new System.Drawing.Size(287, 165);
            this.txtReason.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtReason.TabIndex = 1;
            this.txtReason.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtReason.UseSelectable = true;
            this.txtReason.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReason.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(24, 259);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(287, 54);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Void Order";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // VoidOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 336);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 336);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 336);
            this.Name = "VoidOrder2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Void Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.VoidOrder2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtReason;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}