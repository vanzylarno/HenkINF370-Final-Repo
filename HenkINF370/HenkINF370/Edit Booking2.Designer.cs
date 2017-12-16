namespace HenkINF370
{
    partial class Edit_Booking2
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
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.btnFind = new MetroFramework.Controls.MetroTile();
            this.btnRemove = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(252, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 19);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "metroLabel1";
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnFind
            // 
            this.btnFind.ActiveControl = null;
            this.btnFind.Location = new System.Drawing.Point(227, 73);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(208, 203);
            this.btnFind.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Choose a New Booking";
            this.btnFind.TileImage = global::HenkINF370.Properties.Resources.Ca1;
            this.btnFind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFind.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnFind.UseSelectable = true;
            this.btnFind.UseTileImage = true;
            this.btnFind.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveControl = null;
            this.btnRemove.Location = new System.Drawing.Point(13, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 203);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove yourself from Booking";
            this.btnRemove.TileImage = global::HenkINF370.Properties.Resources.Delete;
            this.btnRemove.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnRemove.UseSelectable = true;
            this.btnRemove.UseTileImage = true;
            this.btnRemove.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Edit_Booking2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 292);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRemove);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 496);
            this.MinimizeBox = false;
            this.Name = "Edit_Booking2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Edit Booking";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Edit_Booking2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnFind;
        private MetroFramework.Controls.MetroTile btnRemove;
        private MetroFramework.Controls.MetroLabel lblDate;
    }
}