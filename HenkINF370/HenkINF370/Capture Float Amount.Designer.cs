namespace HenkINF370
{
    partial class Capture_Float_Amount
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtFloat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 141);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(273, 51);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Capture Float";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtFloat
            // 
            // 
            // 
            // 
            this.txtFloat.CustomButton.Image = null;
            this.txtFloat.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.txtFloat.CustomButton.Name = "";
            this.txtFloat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFloat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFloat.CustomButton.TabIndex = 1;
            this.txtFloat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFloat.CustomButton.UseSelectable = true;
            this.txtFloat.CustomButton.Visible = false;
            this.txtFloat.Lines = new string[0];
            this.txtFloat.Location = new System.Drawing.Point(23, 92);
            this.txtFloat.MaxLength = 32767;
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.PasswordChar = '\0';
            this.txtFloat.PromptText = "Please Enter the Float Amount";
            this.txtFloat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFloat.SelectedText = "";
            this.txtFloat.SelectionLength = 0;
            this.txtFloat.SelectionStart = 0;
            this.txtFloat.ShortcutsEnabled = true;
            this.txtFloat.Size = new System.Drawing.Size(273, 23);
            this.txtFloat.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFloat.TabIndex = 1;
            this.txtFloat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFloat.UseSelectable = true;
            this.txtFloat.WaterMark = "Please Enter the Float Amount";
            this.txtFloat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFloat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Float Amount:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Capture_Float_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 222);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(338, 222);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(338, 222);
            this.Name = "Capture_Float_Amount";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Capture Float Amount";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Capture_Float_Amount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtFloat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}