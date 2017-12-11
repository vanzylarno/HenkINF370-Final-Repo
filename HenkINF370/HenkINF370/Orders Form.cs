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
            InStoreOrder myform = new InStoreOrder();
            myform.ShowDialog();
        }
    }
}
