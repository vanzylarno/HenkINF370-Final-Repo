﻿using System;
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
    public partial class Remove_Drink_Size : MetroFramework.Forms.MetroForm
    {
        public Remove_Drink_Size()
        {
            InitializeComponent();
        }
        int Selected;
        private void Remove_Drink_Size_Load(object sender, EventArgs e)
        {
            txtDescription.Enabled = false;
            Price.Enabled = false;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Description FROM DrinkSize";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if(r.HasRows)
            {
                while(r.Read())
                {
                    listBox1.Items.Add((r["Description"].ToString()));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM DrinkSize WHERE Description ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader r = sqlcom.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    txtDescription.Text = (r["Description"].ToString());
                    Price.Text = (r["Price"].ToString());
                    Selected = Convert.ToInt32((r["DrinkSizeID"]));
                }
            }
            r.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Drink Size?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "DELETE FROM DrinkSize WHERE DrinkSizeID ='" + Selected.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                lblDetails.Text = "Success!" +
                    "\n" +
                    "\n" +
                    "The Drink Size was Deleted Successfully!";

                txtDescription.Text = "";
                Price.Text = "";

                listBox1.Items.Clear();
                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "SELECT Description FROM DrinkSize";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                SqlDataReader r2 = sqlcom2.ExecuteReader();
                if (r2.HasRows)
                {
                    while (r2.Read())
                    {
                        listBox1.Items.Add((r2["Description"].ToString()));
                    }
                }
                r2.Close();
                sqlcon2.Close();
            }
        }
    }
}