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
    public partial class Users_Help : MetroFramework.Forms.MetroForm
    {
        public Users_Help()
        {
            InitializeComponent();
        }

        private void Users_Help_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Genders myform = new Genders();
            myform.ShowDialog();
            
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Titles myform = new Titles();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Privileges myform = new Privileges();
            myform.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            User_Types myform = new User_Types();
            myform.ShowDialog();
        }
    }
}
