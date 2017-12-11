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
    public partial class Create_a_New_Combo : MetroFramework.Forms.MetroForm
    {
        public Create_a_New_Combo()
        {
            InitializeComponent();
        }
        int DrinkSizeID;
        int PizzaSizeID;
        int PizzaBaseID;
        string ItemName;
        string DrinkSize;
        string PizzaSize;
        string PizzaBase;

        private void Create_a_New_Combo_Load(object sender, EventArgs e)
        {
            PopulateListBox();
            PopulateDrinkSizeCBX();
            PopulatePizzaSizeCBX();
            PopulatePizzaBaseCBX();

        }
        private void PopulateListBox()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ItemName FROM Menu";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ItemName"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ItemName FROM Menu WHERE ItemName LIKE '%" + tctFilter1.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ItemName"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }
        
        private void GetDrinkSizeID()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT DrinkSizeID FROM DrinkSize WHERE Description ='" + cbxDrinkSize.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    DrinkSizeID = Convert.ToInt32((r["DrinkSizeID"]));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void GetPizzaSizeID()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PizzaSizeID FROM PizzaSize WHERE Description ='" + cbxPizzaSize.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    PizzaSizeID = Convert.ToInt32((r["PizzaSizeID"]));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void GetPizzaBaseID()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PizzaBaseID FROM PizzaBase WHERE Description ='" + cbxPizzaBase.SelectedItem.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    PizzaBaseID = Convert.ToInt32((r["PizzaBaseID"]));
                }
            }
            r.Close();
            sqlcon.Close();
        }


        private void PopulateDrinkSizeCBX()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM DrinkSize";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    cbxDrinkSize.Items.Add((r["Description"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void PopulatePizzaSizeCBX()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM PizzaSize";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    cbxPizzaSize.Items.Add((r["Description"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void PopulatePizzaBaseCBX()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM PizzaBase";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    cbxPizzaBase.Items.Add((r["Description"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxDrinkSize.SelectedItem.ToString() == "" || cbxPizzaBase.SelectedItem.ToString() == "" || cbxPizzaSize.SelectedItem.ToString() == "" || listBox1.Text.ToString() == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required was porivided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ItemName = listBox1.Text.ToString();
                DrinkSize = cbxDrinkSize.SelectedItem.ToString();
                PizzaBase = cbxPizzaBase.SelectedItem.ToString();
                PizzaSize = cbxPizzaSize.SelectedItem.ToString();

                this.dataGridView1.Rows.Add(ItemName, PizzaBase, PizzaSize, DrinkSize);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Create this Combo?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                try
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

                                                //Update
                                                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                                                sqlcon.Open();
                                                string cmd = "INSERT INTO Combos(ItemName, ComboDescription, PizzaBaseID, DrinkSizeID, PizzaSizeID, Price, ExpireDate) VALUES(@ItemName, @ComboDescription, @PizzaBaseID, @DrinkSizeID, @PizzaSizeID, @Price, @ExpireDate)";
                                                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                                                sqlcom.Parameters.AddWithValue("@ItemName", row.Cells["colItemName"].Value);
                                                sqlcom.Parameters.AddWithValue("@ComboDescription", txtDescription.Text);
                                                sqlcom.Parameters.AddWithValue("@PizzaBaseID", PizzaBaseIDs);
                                                sqlcom.Parameters.AddWithValue("@DrinkSizeID", DrinkSizeIDs);
                                                sqlcom.Parameters.AddWithValue("@PizzaSizeID", PizzaSizeIDs);
                                                sqlcom.Parameters.AddWithValue("@Price", txtPrice.Text);
                                                sqlcom.Parameters.AddWithValue("@ExpireDate", dtpExpirationDate.Text);
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
               
                    MetroFramework.MetroMessageBox.Show(this, "New Combo Added Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.dataGridView1.Rows.Clear();
                    txtDescription.Text = "";
                    txtPrice.Text = "";
                    cbxDrinkSize.Items.Clear();
                    cbxPizzaBase.Items.Clear();
                    cbxPizzaSize.Items.Clear();
                    listBox1.Items.Clear();

                    PopulateDrinkSizeCBX();
                    PopulateListBox();
                    PopulatePizzaBaseCBX();
                    PopulatePizzaSizeCBX();
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                this.dataGridView1.Rows.Clear();
                txtDescription.Text = "";
                txtPrice.Text = "";
                cbxDrinkSize.Items.Clear();
                cbxPizzaBase.Items.Clear();
                cbxPizzaSize.Items.Clear();
                listBox1.Items.Clear();

                PopulateDrinkSizeCBX();
                PopulateListBox();
                PopulatePizzaBaseCBX();
                PopulatePizzaSizeCBX();
            }
        }

        private void cbxPizzaBase_Click(object sender, EventArgs e)
        {
            cbxPizzaBase.Items.Clear();
            PopulatePizzaBaseCBX();
        }

        private void cbxPizzaSize_Click(object sender, EventArgs e)
        {
            cbxPizzaSize.Items.Clear();
            PopulatePizzaSizeCBX();
        }

        private void cbxDrinkSize_Click(object sender, EventArgs e)
        {
            cbxDrinkSize.Items.Clear();
            PopulateDrinkSizeCBX();
        }

        private void cbxPizzaBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPizzaBaseID();
        }

        private void cbxPizzaSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPizzaSizeID();
        }

        private void cbxDrinkSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDrinkSizeID();
        }
    }
}
