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
    public partial class Menu_Item_Types : MetroFramework.Forms.MetroForm
    {
        public Menu_Item_Types()
        {
            InitializeComponent();
        }

        private void Menu_Item_Types_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Add_Menu_Item_Type myform = new Add_Menu_Item_Type();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Remove_Menu_Item_Type myform = new Remove_Menu_Item_Type();
            myform.ShowDialog();
        }
    }
}
