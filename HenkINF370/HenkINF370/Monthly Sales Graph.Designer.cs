namespace HenkINF370
{
    partial class Monthly_Sales_Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cbxMonth = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSalesMade = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblRevenue = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMonth
            // 
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.ItemHeight = 23;
            this.cbxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbxMonth.Location = new System.Drawing.Point(24, 86);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(228, 29);
            this.cbxMonth.Style = MetroFramework.MetroColorStyle.Lime;
            this.cbxMonth.TabIndex = 0;
            this.cbxMonth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbxMonth.UseSelectable = true;
            this.cbxMonth.SelectedIndexChanged += new System.EventHandler(this.cbxMonth_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Month";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 524);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(259, 74);
            this.metroButton1.TabIndex = 25;
            this.metroButton1.Text = "Print Graph";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(23, 147);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sales Made";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1107, 356);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Sales Made per Payment Type";
            this.chart1.Titles.Add(title2);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(279, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(207, 19);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "Total Revenue Made this Month: R";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTotalSalesMade
            // 
            this.lblTotalSalesMade.AutoSize = true;
            this.lblTotalSalesMade.Location = new System.Drawing.Point(429, 81);
            this.lblTotalSalesMade.Name = "lblTotalSalesMade";
            this.lblTotalSalesMade.Size = new System.Drawing.Size(16, 19);
            this.lblTotalSalesMade.TabIndex = 29;
            this.lblTotalSalesMade.Text = "0";
            this.lblTotalSalesMade.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(279, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(144, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Sales Made this Month:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(492, 60);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(16, 19);
            this.lblRevenue.TabIndex = 31;
            this.lblRevenue.Text = "0";
            this.lblRevenue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Monthly_Sales_Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 613);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblTotalSalesMade);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbxMonth);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1174, 613);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1174, 613);
            this.Name = "Monthly_Sales_Graph";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Monthly Sales Graph";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Monthly_Sales_Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxMonth;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotalSalesMade;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblRevenue;
    }
}