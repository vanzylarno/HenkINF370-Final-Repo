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
    public partial class Toppings_Form : MetroFramework.Forms.MetroForm
    {
        public Toppings_Form()
        {
            InitializeComponent();
        }

        private void Toppings_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Add_Topping myform = new Add_Topping();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            View_All_Toppings myform = new View_All_Toppings();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Update_Toppings myform = new Update_Toppings();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Find_a_Topping myform = new Find_a_Topping();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Delete_a_Topping myform = new Delete_a_Topping();
            myform.ShowDialog();
        }
    }
}
