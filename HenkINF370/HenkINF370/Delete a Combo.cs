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
    public partial class Delete_a_Combo : MetroFramework.Forms.MetroForm
    {
        public Delete_a_Combo()
        {
            InitializeComponent();
        }
        string PizzaSize;
        string DrinkSize;
        string PizzaBase;
        int PizzaSizeID;
        int DrinkSizeID;
        int PizzaBaseID;

        private void Delete_a_Combo_Load(object sender, EventArgs e)
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
                }

            }
            dr.Close();
            sqlcon.Close();

            GetPizzaBaseDesc();
            GetPizzaSizeDesc();
            GetDrinkSizeDesc();

            //Populate dgv
            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT * FROM Combos WHERE Price ='" + txtPrice.Text + "' AND ComboDescription ='" + txtDescription.Text + "' AND ExpireDate ='" + txtExpireDate.Text + "'";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2 = sqlcom2.ExecuteReader();
            if(dr2.HasRows)
            {
                while(dr2.Read())
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Combo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int PizzaBaseIDs;
                    int PizzaSizeIDs;
                    int DrinkSizeIDs;

                    //Get PizzaBaseID
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT PizzaBaseID FROM PizzaBase WHERE Description ='" + row.Cells["colPizzaBase"].Value.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            PizzaBaseIDs = Convert.ToInt32((dr2["PizzaBaseID"]));

                            //Get PizzaSizeID
                            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                            sqlcon3.Open();
                            string cmd3 = "SELECT PizzaSizeID FROM PizzaSize WHERE Description ='" + row.Cells["colPizzaSize"].Value.ToString() + "'";
                            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                            SqlDataReader dr3 = sqlcom3.ExecuteReader();
                            if (dr3.HasRows)
                            {
                                while (dr3.Read())
                                {
                                    PizzaSizeIDs = Convert.ToInt32((dr3["PizzaSizeID"]));

                                    //Get DrinkSizeID
                                    SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                                    sqlcon4.Open();
                                    string cmd4 = "SELECT DrinkSizeID FROM DrinkSize WHERE Description ='" + row.Cells["coLDrinkSize"].Value.ToString() + "'";
                                    SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                                    SqlDataReader dr4 = sqlcom4.ExecuteReader();
                                    if (dr4.HasRows)
                                    {
                                        while (dr4.Read())
                                        {
                                            DrinkSizeIDs = Convert.ToInt32((dr4["DrinkSizeID"]));

                                            //Insert
                                            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                            sqlcon.Open();
                                            string cmd = "INSERT INTO ComboRecords(ItemName, ComboDescription, PizzaBaseID, DrinkSizeID, PizzaSizeID, Price, ExpireDate) VALUES(@ItemName, @ComboDescription, @PizzaBaseID, @DrinkSizeID, @PizzaSizeID, @Price, @ExpireDate)";
                                            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                            sqlcom.Parameters.AddWithValue("@ItemName", row.Cells["colItemName"].Value);
                                            sqlcom.Parameters.AddWithValue("@ComboDescription", txtDescription.Text);
                                            sqlcom.Parameters.AddWithValue("@PizzaBaseID", PizzaBaseIDs);
                                            sqlcom.Parameters.AddWithValue("@DrinkSizeID", DrinkSizeIDs);
                                            sqlcom.Parameters.AddWithValue("@PizzaSizeID", PizzaSizeIDs);
                                            sqlcom.Parameters.AddWithValue("@Price", txtPrice.Text);
                                            sqlcom.Parameters.AddWithValue("@ExpireDate", txtExpireDate.Text);
                                            sqlcom.ExecuteNonQuery();
                                            sqlcon.Close();

                                        }
                                    }
                                    dr4.Close();
                                    sqlcon4.Close();
                                }
                              

                            }
                            dr3.Close();
                            sqlcon3.Close();
                           
                        }

                    }
                    dr2.Close();
                    sqlcon2.Close();
                }


                SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
                sqlcon5.Open();
                string cmd5 = "DELETE FROM Combos WHERE ComboDescription ='" + txtDescription.Text + "' AND ExpireDate ='" + txtExpireDate.Text + "' AND Price ='" + txtPrice.Text + "'";
                SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
                sqlcom5.ExecuteNonQuery();
                sqlcon5.Close();
                PopulateListBox();
                MetroFramework.MetroMessageBox.Show(this, "Combo Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtDescription.Text = "";
                txtExpireDate.Text = "";
                txtPrice.Text = "";
                this.dataGridView1.Rows.Clear();

            }

        }

        private void GetPizzaBaseIDs()
        {
           
        }

        private void txtFilter2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ComboDescription FROM Combos WHERE Price LIKE '%" + txtFilter.Text + "%'";
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
    }
}
