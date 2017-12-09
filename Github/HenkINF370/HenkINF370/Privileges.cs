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
    public partial class Privileges : MetroFramework.Forms.MetroForm
    {
        public Privileges()
        {
            InitializeComponent();
        }

        private void Privileges_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_Privilege myform = new Add_Privilege();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Delete_Privilege myform = new Delete_Privilege();
            myform.ShowDialog();
        }
    }
}
