using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HenkINF370
{
    public partial class Orders_Form : MetroFramework.Forms.MetroForm
    {
        public Orders_Form()
        {
            InitializeComponent();
        }

        private void Orders_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            InStoreOrder myform = new InStoreOrder();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Telephone_Order myform = new Telephone_Order();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Search_Orders myform = new Search_Orders();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Void_Order myform = new Void_Order();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update_Order myform = new Update_Order();
            myform.ShowDialog();
        }
    }
}
