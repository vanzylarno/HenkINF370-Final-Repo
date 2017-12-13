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
    public partial class VoidOrder2 : MetroFramework.Forms.MetroForm
    {
        public VoidOrder2()
        {
            InitializeComponent();
        }

        private void VoidOrder2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtReason.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not All information required has been Provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT Into VoidedOrders(OrderID, VoidReason) VALUES (@ID, @Reason)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ID", Globals.OrderID));
                    sqlcom.Parameters.Add(new SqlParameter("@Reason", txtReason.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();


                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "DELETE FROM Orders WHERE OrderID ='" + Globals.OrderID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();
                    MetroFramework.MetroMessageBox.Show(this, "Order Voided Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
