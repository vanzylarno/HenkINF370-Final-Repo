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
    public partial class Menu_Form : MetroFramework.Forms.MetroForm
    {
        public Menu_Form()
        {
            InitializeComponent();
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_Menu_Item myform = new Add_Menu_Item();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Find_a_Menu_Item myform = new Find_a_Menu_Item();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Delete_Menu_Item myform = new Delete_Menu_Item();
            myform.ShowDialog();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update_a_Menu_Item myform = new Update_a_Menu_Item();
            myform.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            View_All_Menu_Items myform = new View_All_Menu_Items();
            myform.ShowDialog();
        }
    }
}
