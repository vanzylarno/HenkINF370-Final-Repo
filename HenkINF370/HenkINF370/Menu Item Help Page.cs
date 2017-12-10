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
    public partial class Menu_Item_Help_Page : MetroFramework.Forms.MetroForm
    {
        public Menu_Item_Help_Page()
        {
            InitializeComponent();
        }

        private void Menu_Item_Help_Page_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Drinks myform = new Drinks();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Pizza_Sizes myform = new Pizza_Sizes();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Pizza_Bases myform = new Pizza_Bases();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Menu_Item_Types myform = new Menu_Item_Types();
            myform.ShowDialog();
        }
    }
}
