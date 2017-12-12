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
    public partial class Payment_Choices : MetroFramework.Forms.MetroForm
    {
        public Payment_Choices()
        {
            InitializeComponent();
        }

        private void Payment_Choices_Load(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Cash_Payment myform = new Cash_Payment();
            myform.ShowDialog();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Credit_Card_Sale myform = new Credit_Card_Sale();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
