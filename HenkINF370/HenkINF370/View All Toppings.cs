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
    public partial class View_All_Toppings : MetroFramework.Forms.MetroForm
    {
        public View_All_Toppings()
        {
            InitializeComponent();
        }

        private void View_All_Toppings_Load(object sender, EventArgs e)
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
            if(dr.HasRows)
            {
                while(dr.Read())
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
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
