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
    public partial class Delete_a_Topping : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Topping()
        {
            InitializeComponent();
        }
        int Selected;
        private void Delete_a_Topping_Load(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtPrice.Enabled = false;
            PopulateListBox();
        }
        private void PopulateListBox()
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ToppingName From Toppings";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ToppingName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ToppingName From Toppings WHERE ToppingName LIKE '%" + txtFilter1.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ToppingName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ToppingName From Toppings WHERE Price LIKE '%" + txtFilter2.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ToppingName"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Toppings WHERE ToppingName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtName.Text = (dr["ToppingName"].ToString());
                    txtPrice.Text = (dr["Price"].ToString());
                    Selected = Convert.ToInt32((dr["ToppingID"]));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Topping?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "INSERT INTO ToppingRecord(ToppingName, Price) VALUES(@Name, @Price)";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.Parameters.Add(new SqlParameter("@Name", txtName.Text));
                sqlcom.Parameters.Add(new SqlParameter("@Price", txtPrice.Text));
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "DELETE FROM Toppings WHERE ToppingID ='" + Selected.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                sqlcom2.ExecuteNonQuery();
                sqlcon2.Close();

                MetroFramework.MetroMessageBox.Show(this, "The Topping was Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                PopulateListBox();
                txtName.Text = "";
                txtPrice.Text = "";
            }
        }
    }
}
