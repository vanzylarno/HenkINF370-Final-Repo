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
    public partial class Update_a_Combo : MetroFramework.Forms.MetroForm
    {
        public Update_a_Combo()
        {
            InitializeComponent();
        }
        int ComboID;
        string PizzaSize;
        string DrinkSize;
        string PizzaBase;
        int PizzaSizeID;
        int DrinkSizeID;
        int PizzaBaseID;


        private void Update_a_Combo_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            txtExpireDate.Enabled = false;
            txtPrice.Enabled = false;
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ComboDescription FROM Combos";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ComboDescription"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ComboDescription FROM Combos WHERE ItemName LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ComboDescription"].ToString()));
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
            string cmd = "SELECT Distinct ComboDescription FROM Combos WHERE Price LIKE '%" + txtFilter2.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ComboDescription"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Combos WHERE ComboDescription ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtPrice.Text = (dr["Price"].ToString());
                    txtExpireDate.Text = (dr["ExpireDate"].ToString());
                    txtDescription.Text = (dr["ComboDescription"].ToString());
                    PizzaBaseID = Convert.ToInt32((dr["PizzaBaseID"]));
                    PizzaSizeID = Convert.ToInt32((dr["PizzaSizeID"]));
                    DrinkSizeID = Convert.ToInt32((dr["DrinkSizeID"]));
                    Globals.SelectedComboPrice = (dr["Price"].ToString());
                    Globals.SelectedComboExpireDate = (dr["ExpireDate"].ToString());
                    Globals.SelectedComboDescription = (dr["ComboDescription"].ToString());
                }

            }
            dr.Close();
            sqlcon.Close();

            GetPizzaBaseDesc();
            GetPizzaSizeDesc();
            GetDrinkSizeDesc();
            GetComboID();

            //Populate dgv
            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT * FROM Combos WHERE Price ='" + txtPrice.Text + "' AND ComboDescription ='" + txtDescription.Text + "' AND ExpireDate ='" + txtExpireDate.Text + "'";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    this.dataGridView1.Rows.Add((dr2["ItemName"].ToString()), PizzaBase, PizzaSize, DrinkSize);
                }
            }
            dr2.Close();
            sqlcon2.Close();
        }
        private void GetPizzaBaseDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM PizzaBase WHERE PizzaBaseID ='" + PizzaBaseID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    PizzaBase = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetPizzaSizeDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM PizzaSize WHERE PizzaSizeID ='" + PizzaSizeID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    PizzaSize = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetDrinkSizeDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM DrinkSize WHERE DrinkSizeID ='" + DrinkSizeID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    DrinkSize = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetComboID()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "Select ComboID FROM Combos WHERE Price ='" + txtPrice.Text + "' AND ComboDescription ='" + txtDescription.Text + "' AND ExpireDate ='" + txtExpireDate.Text + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    ComboID = Convert.ToInt32((dr["ComboID"]));
                    Globals.ComboID = Convert.ToInt32((dr["ComboID"]));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Update this Combo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                
                Update_Combo2 myform = new Update_Combo2();
                myform.ShowDialog();

                PopulateListBox();
            }
        }
    }
    
}
