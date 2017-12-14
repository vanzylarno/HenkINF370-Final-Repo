namespace HenkINF370
{
    partial class Daily_Sales_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblRevenue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblTotalSalesMade = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(463, 66);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(16, 19);
            this.lblRevenue.TabIndex = 13;
            this.lblRevenue.Text = "0";
            this.lblRevenue.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(277, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(180, 38);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Total Revenue Made Today: R\r\n";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTotalSalesMade
            // 
            this.lblTotalSalesMade.AutoSize = true;
            this.lblTotalSalesMade.Location = new System.Drawing.Point(177, 100);
            this.lblTotalSalesMade.Name = "lblTotalSalesMade";
            this.lblTotalSalesMade.Size = new System.Drawing.Size(16, 19);
            this.lblTotalSalesMade.TabIndex = 11;
            this.lblTotalSalesMade.Text = "0";
            this.lblTotalSalesMade.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(84, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Today\'s Date:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(122, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 19);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "0";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Total Sales Made Today:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 138);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Sales Made";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1107, 356);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Sales Made per Payment Type";
            this.chart1.Titles.Add(title3);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(12, 515);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(259, 74);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Print Detailed Report";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Daily_Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 608);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblTotalSalesMade);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1141, 608);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1141, 608);
            this.Name = "Daily_Sales_Report";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Daily Sales Report";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Daily_Sales_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblRevenue;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblTotalSalesMade;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}