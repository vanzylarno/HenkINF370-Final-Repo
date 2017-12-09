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
    public partial class Shifts_Form : MetroFramework.Forms.MetroForm
    {
        public Shifts_Form()
        {
            InitializeComponent();
        }

        private void Shifts_Form_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            View_Available_Shifts myform = new View_Available_Shifts();
            myform.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Search_Shifts myform = new Search_Shifts();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Create_Shift myform = new Create_Shift();
            myform.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Update_Shift myform = new Update_Shift();
            myform.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Delete_Shift myform = new Delete_Shift();
            myform.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Book_Shift myform = new Book_Shift();
            myform.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Edit_Booked_Shifts myform = new Edit_Booked_Shifts();
            myform.ShowDialog();
        }
    }
}
