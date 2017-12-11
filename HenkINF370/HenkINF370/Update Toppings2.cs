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
    public partial class Update_Toppings2 : MetroFramework.Forms.MetroForm
    {
        public Update_Toppings2()
        {
            InitializeComponent();
        }

        private void Update_Toppings2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
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
                    string cmd = "UPDATE Toppings SET ToppingName =@Name, Price =@Price WHERE ToppingID ='" + Globals.SelectedToppingID.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Name", txtName.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Price", txtPrice.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Topping Update Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtName.Text = "";
                    txtPrice.Text = "";
                    this.Close();
                    this.Dispose(true);
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
            
    

