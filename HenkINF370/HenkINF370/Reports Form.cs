using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenkINF370
{
    public partial class Reports_Form : MetroFramework.Forms.MetroForm
    {
        public Reports_Form()
        {
            InitializeComponent();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            End_of_Shift_Report myfor = new End_of_Shift_Report();
            myfor.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Daily_Sales_Report myform = new Daily_Sales_Report();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Daily_Sales_Graph myform = new Daily_Sales_Graph();
            myform.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Monthly_Sales_Graph myform = new Monthly_Sales_Graph();
            myform.ShowDialog();
        }
    }
}
