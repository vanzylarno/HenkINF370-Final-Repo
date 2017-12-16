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
    public partial class Titles : MetroFramework.Forms.MetroForm
    {
        public Titles()
        {
            InitializeComponent();
        }

        private void Titles_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_Title myform = new Add_Title();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Delete_Title myform = new Delete_Title();
            myform.ShowDialog();
        }
    }
}
