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
    public partial class User_Types : MetroFramework.Forms.MetroForm
    {
        public User_Types()
        {
            InitializeComponent();
        }

        private void User_Types_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Add_User_Types myform = new Add_User_Types();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Delete_User_Types myform = new Delete_User_Types();
            myform.ShowDialog();
        }
    }
}
