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
    public partial class Telephone_Order : MetroFramework.Forms.MetroForm
    {
        public Telephone_Order()
        {
            InitializeComponent();
        }

        private void Telephone_Order_Load(object sender, EventArgs e)
        {

        }
        int TelephoneOrder = 2;

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhoneNumber.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Do you want to create a New Telephone Order?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "Insert Into Customer(CustomerName, CustomerPhoneNumber, CustomerTypeID) VALUES(@Name, @Phone, @Type)";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@Name", txtName.Text));
                        sqlcom.Parameters.Add(new SqlParameter("@Phone", txtPhoneNumber.Text));
                        sqlcom.Parameters.Add(new SqlParameter("@Type", TelephoneOrder));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();


                        Globals.CustomerName = txtName.Text;
                        Globals.CustomerPhoneNumber = txtPhoneNumber.Text;


                        MetroFramework.MetroMessageBox.Show(this, "Customer added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Telephone_Order2 myform = new Telephone_Order2();
                        myform.ShowDialog();
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
