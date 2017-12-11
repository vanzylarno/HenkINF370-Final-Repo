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
    public partial class Combos_Form : MetroFramework.Forms.MetroForm
    {
        public Combos_Form()
        {
            InitializeComponent();
        }

        private void Combos_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Create_a_New_Combo myform = new Create_a_New_Combo();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Delete_a_Combo myform = new Delete_a_Combo();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Find_a_Combo myform = new Find_a_Combo();
            myform.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Find_a_Combo myform = new Find_a_Combo();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update_a_Combo myform = new Update_a_Combo();
            myform.ShowDialog();
        }
    }
}
