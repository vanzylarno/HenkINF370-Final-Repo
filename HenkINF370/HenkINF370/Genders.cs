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
    public partial class Genders : MetroFramework.Forms.MetroForm
    {
        public Genders()
        {
            InitializeComponent();
        }

        private void Genders_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_Gender myform = new Add_Gender();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Delete_Gender myform = new Delete_Gender();
            myform.ShowDialog();
        }
    }
}
