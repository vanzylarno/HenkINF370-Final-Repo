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
    public partial class Add_Topping : MetroFramework.Forms.MetroForm
    {
        public Add_Topping()
        {
            InitializeComponent();
        }

        private void Add_Topping_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add this Topping?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (txtName.Text == "" || txtPrice.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Not all required information has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "INSERT INTO Toppings(ToppingName, Price) VALUES(@Name, @Price)";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.Parameters.Add(new SqlParameter("@Name", txtName.Text));
                        sqlcom.Parameters.Add(new SqlParameter("@Price", txtPrice.Text));
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();

                        MetroFramework.MetroMessageBox.Show(this, "New Topping added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtName.Text = "";
                        txtPrice.Text = "";
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                txtName.Text = "";
                txtPrice.Text = "";
            }
        }
    }
}
