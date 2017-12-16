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
    public partial class Add_Gender : MetroFramework.Forms.MetroForm
    {
        public Add_Gender()
        {
            InitializeComponent();
        }
        string Exists;

        private void Add_Gender_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT GenderDescription FROM Gender";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    listBox1.Items.Add((dr["GenderDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add this Gender?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
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
                        string cmd = "SELECT GenderDescription FROM Gender WHERE GenderDescription ='" + txtDescription.Text + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        SqlDataReader dr = sqlcom.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Exists = (dr["GenderDescription"].ToString());

                                lblDetails.Text = "Error!" +
        "\n" +
        "\n" +
        "This Gender already exists on the System!";
                            }
                        }
                        else
                        {
                            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                            sqlcon2.Open();
                            string cmd2 = "Insert Into Gender(GenderDescription) VALUES(@GD)";
                            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                            sqlcom2.Parameters.Add(new SqlParameter("@GD", txtDescription.Text));
                            sqlcom2.ExecuteNonQuery();
                            sqlcon2.Close();

                            lblDetails.Text = "Success!" +
                                "\n" +
                                "\n" +
                                "The new Gender was added Successfully!";
                        }
                        dr.Close();
                        sqlcon.Close();

                        listBox1.Items.Clear();
                        SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                        sqlcon3.Open();
                        string cmd3 = "SELECT GenderDescription FROM Gender";
                        SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                        SqlDataReader dr3 = sqlcom3.ExecuteReader();
                        if (dr3.HasRows)
                        {
                            while (dr3.Read())
                            {
                                listBox1.Items.Add((dr3["GenderDescription"].ToString()));
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
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Action declined Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
