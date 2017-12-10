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
    public partial class Pizza_Sizes : MetroFramework.Forms.MetroForm
    {
        public Pizza_Sizes()
        {
            InitializeComponent();
        }

        private void Pizza_Sizes_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Add_Pizza_Size myform = new Add_Pizza_Size();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Remove_a_Pizza_Size myform = new Remove_a_Pizza_Size();
            myform.ShowDialog();
        }
    }
}
