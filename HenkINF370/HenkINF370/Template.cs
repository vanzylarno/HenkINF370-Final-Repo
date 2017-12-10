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

        string Monday = "Monday";
        string Tuesday = "Tuesday";
        string Wednesday = "Wednesday";
        string Thursday = "Thursday";
        string Friday = "Friday";
        string Saturday = "Saturday";
        string Sunday = "Sunday";

        private void Template_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell Cell in dataGridView1.Rows)
            {
              
            }
        }
    }
}
