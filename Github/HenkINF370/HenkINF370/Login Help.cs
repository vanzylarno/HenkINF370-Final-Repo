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
    public partial class Login_Help : MetroFramework.Forms.MetroForm
    {
        public Login_Help()
        {
            InitializeComponent();
        }

        private void Login_Help_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Find_Forgotten_Password myform = new Find_Forgotten_Password();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Change_Password myform = new Change_Password();
            myform.ShowDialog();
        }
    }
}
