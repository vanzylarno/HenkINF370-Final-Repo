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
    public partial class Add_User_Types : MetroFramework.Forms.MetroForm
    {
        public Add_User_Types()
        {
            InitializeComponent();
        }
        string Exists;
        private void Add_User_Types_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT UserDescription FROM userType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["UserDescription"].ToString()));
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
                    string cmd = "SELECT UserDescription FROM UserType WHERE UserDescription ='" + txtDescription.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Exists = (dr["UserDescription"].ToString());

                            lblDetails.Text = "Error!" +
    "\n" +
    "\n" +
    "This User Type already exists on the System!";
                        }
                    }
                    else
                    {
                        SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                        sqlcon2.Open();
                        string cmd2 = "Insert Into UserType(UserDescription) VALUES(@GD)";
                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                        sqlcom2.Parameters.Add(new SqlParameter("@GD", txtDescription.Text));
                        sqlcom2.ExecuteNonQuery();
                        sqlcon2.Close();

                        lblDetails.Text = "Success!" +
                            "\n" +
                            "\n" +
                            "The new User Type was added Successfully!";
                    }
                    dr.Close();
                    sqlcon.Close();

                    listBox1.Items.Clear();
                    SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                    sqlcon3.Open();
                    string cmd3 = "SELECT UserDescription FROM UserType";
                    SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                    SqlDataReader dr3 = sqlcom3.ExecuteReader();
                    if (dr3.HasRows)
                    {
                        while (dr3.Read())
                        {
                            listBox1.Items.Add((dr3["UserDescription"].ToString()));
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