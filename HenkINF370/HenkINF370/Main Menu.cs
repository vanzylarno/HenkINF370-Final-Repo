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
    public partial class Main_Menu : MetroFramework.Forms.MetroForm
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "If this is your first login, please Remember to Capture the Float Amount in the Till!",  "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Manager_Features myform = new Manager_Features();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Shifts_Form myform = new Shifts_Form();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Menu_Form myform = new Menu_Form();
            myform.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Template myform = new Template();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Combos_Form myform = new Combos_Form();
            myform.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Toppings_Form myform = new Toppings_Form();
            myform.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Orders_Form myform = new Orders_Form();
            myform.ShowDialog();
        }
    }
}
