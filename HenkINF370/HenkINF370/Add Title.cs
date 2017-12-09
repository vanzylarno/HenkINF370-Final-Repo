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
    public partial class Add_Title : MetroFramework.Forms.MetroForm
    {
        public Add_Title()
        {
            InitializeComponent();
        }
        string Exists;
        private void Add_Title_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TitleDescription FROM Title";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["TitleDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Not all inforamtion required has been Provided!";
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "SELECT TitleDescription FROM Title WHERE TitleDescription ='" + txtDescription.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Exists = (dr["TitleDescription"].ToString());

                            lblDetails.Text = "Error!" +
    "\n" +
    "\n" +
    "This Title already exists on the System!";
                        }
                    }
                    else
                    {
                        SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                        sqlcon2.Open();
                        string cmd2 = "Insert Into Title(TitleDescription) VALUES(@GD)";
                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                        sqlcom2.Parameters.Add(new SqlParameter("@GD", txtDescription.Text));
                        sqlcom2.ExecuteNonQuery();
                        sqlcon2.Close();

                        lblDetails.Text = "Success!" +
                            "\n" +
                            "\n" +
                            "The new Title was added Successfully!";
                    }
                    dr.Close();
                    sqlcon.Close();

                    listBox1.Items.Clear();
                    SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                    sqlcon3.Open();
                    string cmd3 = "SELECT TitleDescription FROM Title";
                    SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                    SqlDataReader dr3 = sqlcom3.ExecuteReader();
                    if (dr3.HasRows)
                    {
                        while (dr3.Read())
                        {
                            listBox1.Items.Add((dr3["TitleDescription"].ToString()));
                        }
                    }
                    dr3.Close();
                    sqlcon3.Close();

                    txtDescription.Text = "";


                }
                catch
                {
                    lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "A Connection to the Database could not be Made!";
                }
            }
        }
    }
}