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
    public partial class Drinks : MetroFramework.Forms.MetroForm
    {
        public Drinks()
        {
            InitializeComponent();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Add_Drink_Size myform = new Add_Drink_Size();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Remove_Drink_Size myform = new Remove_Drink_Size();
            myform.ShowDialog();
        }
    }
}
