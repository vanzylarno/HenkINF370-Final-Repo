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
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Capture this Amount?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (txtFloat.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Not All information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "UPDATE ShiftLine SET FloatAmountInTill = @Amount WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "' AND UserID ='" + Globals.UserID.ToString() + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@Amount", Convert.ToDecimal(txtFloat.Text)));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        //Update hasLoggedIn
                        int HasLoggedIn = 2;
                        SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                        sqlcon2.Open();
                        string cmd2 = "UPDATE DailyLogin SET HasLoggedIn ='" + HasLoggedIn + "' WHERE UserID ='" + Globals.UserID.ToString() + "'";
                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                        sqlcom2.ExecuteNonQuery();
                        sqlcon2.Close();
                        MetroFramework.MetroMessageBox.Show(this, "Float Amount Captured!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                        this.Dispose(true);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please enter the Correct format!" +
                            "\n" +
                            "i.e. 12.89, 131,56", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFloat.Text = "";
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Action Declined Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
