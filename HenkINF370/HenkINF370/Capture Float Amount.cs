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
    public partial class Capture_Float_Amount : MetroFramework.Forms.MetroForm
    {
        public Capture_Float_Amount()
        {
            InitializeComponent();
        }

        private void Capture_Float_Amount_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(txtFloat.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "UPDATE ShiftLine SET FloatAmountInTill = @Amount WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "' AND UserID ='" + Globals.UserID.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.Parameters.Add(new SqlParameter("@Amount", Convert.ToDecimal(txtFloat.Text)));
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                MetroFramework.MetroMessageBox.Show(this, "Float Amount Captured!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
    }
}
