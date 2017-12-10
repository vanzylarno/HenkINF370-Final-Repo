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
using System.IO;

namespace HenkINF370
{
    public partial class Add_Menu_Item : MetroFramework.Forms.MetroForm
    {
        public Add_Menu_Item()
        {
            InitializeComponent();
        }
        string Filelocation;
        int MenuItemTypeID;
        int DrinkSizeID;
        int PizzaSizeID;
        int PizzaBaseID;

        private void Add_Menu_Item_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM DrinkSize";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    cbxDrinkSize.Items.Add((dr["Description"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();


            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT Description FROM PizzaBase";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2 = sqlcom2.ExecuteReader();
            if(dr2.HasRows)
            {
                while(dr2.Read())
                {
                    cbxPizzaBasse.Items.Add((dr2["Description"].ToString()));
                }
            }
            dr2.Close();
            sqlcon2.Close();

            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "SELECT Description FROM PizzaSize";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3 = sqlcom3.ExecuteReader();
            if(dr3.HasRows)
            { while(dr3.Read())
                {
                    cbxPizzaSize.Items.Add((dr3["Description"].ToString()));
                }
            }
            dr3.Close();
            sqlcon3.Close();

            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
            sqlcon4.Open();
            string cmd4 = "SELECT Description FROM MenuItemType";
            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
            SqlDataReader dr4 = sqlcom4.ExecuteReader();
            if (dr4.HasRows)
            {
                while (dr4.Read())
                {
                    cbxMenuItemType.Items.Add((dr4["Description"].ToString()));
                }
            }
            dr4.Close();
            sqlcon4.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Filelocation = ofd.FileName;
                pictureBox1.Image = Image.FromFile(Filelocation);
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtItemName.Text == "" || txtPrice.Text == "" || txtDescription.Text == "" || Filelocation == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information required has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                try
                {
                    byte[] image = null;
                    FileStream fs = new FileStream(Filelocation, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    image = br.ReadBytes((int)fs.Length);

                    //GEt Variables
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "SELECT DrinkSizeID FROM DrinkSize WHERE Description ='" + cbxDrinkSize.SelectedItem.ToString() + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            DrinkSizeID = Convert.ToInt32((dr["DrinkSizeID"]));
                        }
                    }
                    dr.Close();
                    sqlcon.Close();


                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT PizzaBaseID FROM PizzaBase WHERE Description ='" + cbxPizzaBasse.SelectedItem.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            PizzaBaseID = Convert.ToInt32((dr2["PizzaBaseID"]));
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();

                    SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                    sqlcon3.Open();
                    string cmd3 = "SELECT PizzaSizeID FROM PizzaSize WHERE Description ='" + cbxPizzaSize.SelectedItem.ToString() + "'";
                    SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                    SqlDataReader dr3 = sqlcom3.ExecuteReader();
                    if (dr3.HasRows)
                    {
                        while (dr3.Read())
                        {
                            PizzaSizeID = Convert.ToInt32((dr3["PizzaSizeID"]));
                        }
                    }
                    dr3.Close();
                    sqlcon3.Close();

                    SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                    sqlcon4.Open();
                    string cmd4 = "SELECT MenuItemTypeID FROM MenuItemType WHERE Description ='" + cbxMenuItemType.SelectedItem.ToString() + "'";
                    SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                    SqlDataReader dr4 = sqlcom4.ExecuteReader();
                    if (dr4.HasRows)
                    {
                        while (dr4.Read())
                        {
                            MenuItemTypeID = Convert.ToInt32((dr4["MenuItemTypeID"]));
                        }
                    }
                    dr4.Close();
                    sqlcon4.Close();

                    decimal money = Convert.ToDecimal(txtPrice.Text);

                    SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
                    sqlcon5.Open();
                    string cmd5 = "INSERT INTO Menu(ItemName, Price, Description, Image, MenuItemTypeID, DrinKSizeID, PizzaSizeID, PizzaBaseID) Values(@ItemName, @Price, @Description, @Image, @MenuItemTypeID, @DrinkSizeID, @PizzaSizeID, @PizzaBaseID)";
                    SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
                    sqlcom5.Parameters.Add(new SqlParameter("@ItemName", txtItemName.Text));
                    sqlcom5.Parameters.Add(new SqlParameter("@Price", txtPrice.Text));
                    sqlcom5.Parameters.Add(new SqlParameter("@Description",txtDescription.Text));
                    sqlcom5.Parameters.Add(new SqlParameter("@Image",image));
                    sqlcom5.Parameters.Add(new SqlParameter("MenuItemTypeID",MenuItemTypeID));
                    sqlcom5.Parameters.Add(new SqlParameter("@DrinkSizeID", DrinkSizeID));
                    sqlcom5.Parameters.Add(new SqlParameter("@PizzaSizeID", PizzaSizeID));
                    sqlcom5.Parameters.Add(new SqlParameter("@PizzaBaseID", PizzaBaseID));
                    sqlcom5.ExecuteNonQuery();
                    sqlcon5.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Menu Item Successfully Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

                    txtItemName.Text = "";
                    txtPrice.Text = "";
                    txtDescription.Text = "";
                    cbxDrinkSize.Text = "";
                    cbxMenuItemType.Text = "";
                    cbxPizzaBasse.Text = "";
                    cbxPizzaSize.Text = "";
                    Filelocation = "";
                    pictureBox1.Image = null;
                    btnAdd.Enabled = false;
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database Could not be Made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbxPizzaBasse_Click(object sender, EventArgs e)
        {
            cbxPizzaBasse.Items.Clear();
            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT Description FROM PizzaBase";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    cbxPizzaBasse.Items.Add((dr2["Description"].ToString()));
                }
            }
            dr2.Close();
            sqlcon2.Close();
        }

        private void cbxPizzaSize_Click(object sender, EventArgs e)
        {
            cbxPizzaSize.Items.Clear();
            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "SELECT Description FROM PizzaSize";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    cbxPizzaSize.Items.Add((dr3["Description"].ToString()));
                }
            }
            dr3.Close();
            sqlcon3.Close();
        }

        private void cbxDrinkSize_Click(object sender, EventArgs e)
        {
            cbxDrinkSize.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM DrinkSize";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxDrinkSize.Items.Add((dr["Description"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxMenuItemType_Click(object sender, EventArgs e)
        {
            cbxMenuItemType.Items.Clear();
            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
            sqlcon4.Open();
            string cmd4 = "SELECT Description FROM MenuItemType";
            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
            SqlDataReader dr4 = sqlcom4.ExecuteReader();
            if(dr4.HasRows)
            {
                while(dr4.Read())
                {
                    cbxMenuItemType.Items.Add((dr4["Description"].ToString()));
                }
            }
            dr4.Close();
            sqlcon4.Close();
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {
            Menu_Item_Help_Page myform = new Menu_Item_Help_Page();
            myform.ShowDialog();
        }
    }
}
