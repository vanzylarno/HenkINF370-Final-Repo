﻿namespace HenkINF370
{
    partial class CustomiseOrder
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFilter1 = new MetroFramework.Controls.MetroTextBox();
            this.txtFilter2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 273);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // txtFilter1
            // 
            // 
            // 
            // 
            this.txtFilter1.CustomButton.Image = null;
            this.txtFilter1.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtFilter1.CustomButton.Name = "";
            this.txtFilter1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter1.CustomButton.TabIndex = 1;
            this.txtFilter1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter1.CustomButton.UseSelectable = true;
            this.txtFilter1.CustomButton.Visible = false;
            this.txtFilter1.Lines = new string[0];
            this.txtFilter1.Location = new System.Drawing.Point(23, 77);
            this.txtFilter1.MaxLength = 32767;
            this.txtFilter1.Name = "txtFilter1";
            this.txtFilter1.PasswordChar = '\0';
            this.txtFilter1.PromptText = "Please Enter The Topping\'s Name";
            this.txtFilter1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter1.SelectedText = "";
            this.txtFilter1.SelectionLength = 0;
            this.txtFilter1.SelectionStart = 0;
            this.txtFilter1.ShortcutsEnabled = true;
            this.txtFilter1.Size = new System.Drawing.Size(213, 23);
            this.txtFilter1.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter1.TabIndex = 1;
            this.txtFilter1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter1.UseSelectable = true;
            this.txtFilter1.WaterMark = "Please Enter The Topping\'s Name";
            this.txtFilter1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter1.TextChanged += new System.EventHandler(this.txtFilter1_TextChanged);
            // 
            // txtFilter2
            // 
            // 
            // 
            // 
            this.txtFilter2.CustomButton.Image = null;
            this.txtFilter2.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtFilter2.CustomButton.Name = "";
            this.txtFilter2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFilter2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFilter2.CustomButton.TabIndex = 1;
            this.txtFilter2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFilter2.CustomButton.UseSelectable = true;
            this.txtFilter2.CustomButton.Visible = false;
            this.txtFilter2.Lines = new string[0];
            this.txtFilter2.Location = new System.Drawing.Point(23, 106);
            this.txtFilter2.MaxLength = 32767;
            this.txtFilter2.Name = "txtFilter2";
            this.txtFilter2.PasswordChar = '\0';
            this.txtFilter2.PromptText = "Please Enter the Topping\'s Price";
            this.txtFilter2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilter2.SelectedText = "";
            this.txtFilter2.SelectionLength = 0;
            this.txtFilter2.SelectionStart = 0;
            this.txtFilter2.ShortcutsEnabled = true;
            this.txtFilter2.Size = new System.Drawing.Size(213, 23);
            this.txtFilter2.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtFilter2.TabIndex = 2;
            this.txtFilter2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtFilter2.UseSelectable = true;
            this.txtFilter2.WaterMark = "Please Enter the Topping\'s Price";
            this.txtFilter2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFilter2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilter2.TextChanged += new System.EventHandler(this.txtFilter2_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(257, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(101, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Topping Details:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(257, 217);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(213, 23);
            this.txtPrice.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(257, 169);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(213, 23);
            this.txtName.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtName.TabIndex = 4;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(257, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Name:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(257, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Price:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(257, 247);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(212, 61);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Add to Order";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CustomiseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 427);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtFilter2);
            this.Controls.Add(this.txtFilter1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(492, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 427);
            this.Name = "CustomiseOrder";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Customise Order";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CustomiseOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroTextBox txtFilter1;
        private MetroFramework.Controls.MetroTextBox txtFilter2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}