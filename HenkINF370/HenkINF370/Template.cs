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
    public partial class Template : MetroFramework.Forms.MetroForm
    {
        public Template()
        {
            InitializeComponent();
        }


        private void Template_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'henkINF370DataSet.Shifts' table. You can move, or remove it, as needed.
            


        }




        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile8_Click(object sender, EventArgs e)
        { 

        }

        private void shiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.henkINF370DataSet);

        }
    }
}
