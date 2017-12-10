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
    public partial class Find_a_Menu_Item : MetroFramework.Forms.MetroForm
    {
        public Find_a_Menu_Item()
        {
            InitializeComponent();
        }
        int id;
        string name;
        decimal price;
        string description;
        int menuitemid;
        int drinksizeid;
        int pizzasizeid;
        int pizzabaseid;


        private void Find_a_Menu_Item_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ItemName FROM Menu";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ItemName"].ToString()));
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
            string cmd = "SELECT Distinct ItemName FROM Menu WHERE ItemName LIKE '%" + txtFilter1.Text + "%'";
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

        private void txtFilter2_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Distinct ItemName FROM Menu WHERE Price LIKE '%" + txtFilter2.Text + "%'";
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

        private void listBox1_Click(object sender, EventArgs e)
        {
         

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Menu WHERE ItemName ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    id = Convert.ToInt32((dr["MenuItemID"]));
                    name = (dr["ItemName"].ToString());
                    price = Convert.ToDecimal((dr["Price"]));
                    description = (dr["Description"].ToString());
                    menuitemid = Convert.ToInt32((dr["MenuItemTypeID"]));
                    drinksizeid = Convert.ToInt32((dr["DrinkSizeID"]));
                    pizzasizeid = Convert.ToInt32((dr["PizzaSizeID"]));
                    pizzabaseid = Convert.ToInt32((dr["PizzaBaseID"]));

                }
            }
            dr.Close();
            sqlcon.Close();

            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string Select2 = "SELECT Image FROM Menu WHERE MenuItemID ='" + id.ToString() + "'";
            SqlCommand sqlcom2 = new SqlCommand(Select2, sqlcon2);
            SqlDataAdapter da = new SqlDataAdapter(sqlcom2);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();

            da.Fill(ds);
            sqlcon2.Close();
            byte[] image = (byte[])(ds.Tables[0].Rows[0]["Image"]);
            MemoryStream ms = new MemoryStream(image);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            ms.Close();

            GetMenuItemDesc();
            GetDrinkSizeDesc();
            GetPizzaSizeDesc();
            GetPizzaBaseDesc();

            txtItemName.Text = name;
            txtPrice.Text = price.ToString();
            txtDescription.Text = description.ToString();

        }
        private void GetMenuItemDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM MenuItemType WHERE MenuItemTypeID ='" + menuitemid + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtMenuItemType.Text = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetDrinkSizeDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM DrinkSize WHERE DrinkSizeID ='" + drinksizeid + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtDrinkSizeID.Text = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetPizzaSizeDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM PizzaSize WHERE PizzaSizeID ='" + pizzasizeid + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtPizzaSizeID.Text = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
        private void GetPizzaBaseDesc()
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM PizzaBase WHERE PizzaBaseID ='" + pizzabaseid + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtPizzaBaseID.Text = (r["Description"].ToString());
                }
            }
            r.Close();
            sqlcon.Close();
        }
    }
}
