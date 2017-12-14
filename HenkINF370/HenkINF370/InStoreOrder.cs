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
    public partial class InStoreOrder : MetroFramework.Forms.MetroForm
    {
        public InStoreOrder()
        {
            InitializeComponent();
        }
        //Menu Item Variables
        int id;
        string name;
        decimal price;
        string description;
        int menuitemid;
        int drinksizeid;
        int pizzasizeid;
        int pizzabaseid;

        private void InStoreOrder_Load(object sender, EventArgs e)
        {
            //Menu Item
            panel1.Enabled = false;
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

        private void txtFilter2_Click(object sender, EventArgs e)
        {

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
        {try
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT * FROM Menu WHERE ItemName ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
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
            catch
            {

            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || txtDrinkSizeID.Text == "" || txtPizzaSizeID.Text == "" || txtPizzaBaseID.Text == "" || txtPrice.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Not all information has been provided!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ItemName = txtItemName.Text;
                string DrinkSize = txtDrinkSizeID.Text;
                string PizzaSize = txtPizzaSizeID.Text;
                string PizzaBase = txtPizzaBaseID.Text;
                string Price = txtPrice.Text;

                this.dataGridView1.Rows.Add(ItemName, DrinkSize, PizzaSize, PizzaBase, Price);

                OrderTotal();
            }


            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            CustomiseOrder myform = new CustomiseOrder();
            myform.ShowDialog();
            this.dataGridView2.Rows.Add(Globals.Name, Globals.Price);

            OrderTotal();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Place this Order?", "Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO OrderBasket(ItemName, DrinkSize, PizzaSize, PizzaBase, Price) VALUES(@ItemName, @DrinkSize, @PizzaSize, @PizzaBase, @Price)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@ItemName", row.Cells["colItemName"].Value));
                    sqlcom.Parameters.Add(new SqlParameter("@DrinkSize", row.Cells["colDrinkSize"].Value));
                    sqlcom.Parameters.Add(new SqlParameter("@PizzaSize", row.Cells["colPizzaSize"].Value));
                    sqlcom.Parameters.Add(new SqlParameter("@PizzaBase", row.Cells["colPizzaBase"].Value));
                    sqlcom.Parameters.Add(new SqlParameter("@Price", row.Cells["colPrice"].Value));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();
                }
                foreach(DataGridViewRow rows in dataGridView2.Rows)
                {

                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "INSERT INTO ToppingBasket(ToppingName, Price) VALUES(@ToppingName, @Price)";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    sqlcom2.Parameters.Add(new SqlParameter("@ToppingName", rows.Cells["colTopping"].Value));
                    sqlcom2.Parameters.Add(new SqlParameter("@Price", rows.Cells["colToppingPrice"].Value));
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();
                }

                string NA = "NA";
                int InstoreCustomer = 1;

                SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                sqlcon4.Open();
                string cmd4 = "INSERT INTO Customer(CustomerName, CustomerPhoneNumber, CustomerTypeID) VALUES(@Name, @CustomerPhoneNumber, @CustomerTypeID)";
                SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                sqlcom4.Parameters.Add(new SqlParameter("@Name", NA));
                sqlcom4.Parameters.Add(new SqlParameter("@CustomerPhoneNumber", NA));
                sqlcom4.Parameters.Add(new SqlParameter("@CustomerTypeID", InstoreCustomer));
                sqlcom4.ExecuteNonQuery();
                sqlcon4.Close();

                Globals.CustomerName = NA;
                Globals.CustomerPhoneNumber = NA;

                Globals.Total = Convert.ToDecimal(lblTotal.Text);
                Payment_Choices myform = new Payment_Choices();
                myform.ShowDialog();
                this.dataGridView1.Rows.Clear();
                this.dataGridView2.Rows.Clear();
                lblTotal.Text = "0";

                //Add Items To Receipt

            }
            else
            {
                this.dataGridView1.Rows.Clear();
                this.dataGridView2.Rows.Clear();
            }
        }
        
        private void OrderTotal()
        {
            try { 
            //Calculate Sale Total
            decimal sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
            }
          
                //Calculate Sale Total
                decimal sum2 = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum2 += Convert.ToDecimal(dataGridView2.Rows[i].Cells[1].Value);
                }

                decimal Total = sum + sum2;

                lblTotal.Text =  Total.ToString();
            }
            catch
            {
                //Calculate Sale Total
                decimal sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                }

                lblTotal.Text =  sum.ToString();
            }

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }
    }
}

