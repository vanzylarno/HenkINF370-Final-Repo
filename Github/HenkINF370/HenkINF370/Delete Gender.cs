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
    public partial class Delete_Gender : MetroFramework.Forms.MetroForm
    {
        public Delete_Gender()
        {
            InitializeComponent();
        }

        private void Delete_Gender_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT GenderDescription FROM Gender";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["GenderDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Gender?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "DELETE FROM Gender WHERE GenderDescription ='" + listBox1.Text.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    sqlcom2.ExecuteNonQuery();
                    sqlcon2.Close();

                    lblDetails.Text = "Success!" +
                        "\n" +
                        "\n" +
                        "Gender Type Deleted Successfully!";

                    listBox1.Items.Clear();
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "SELECT GenderDescription FROM Gender";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listBox1.Items.Add((dr["GenderDescription"].ToString()));
                        }
                    }
                    dr.Close();
                    sqlcon.Close();
                }
                catch
                {
                    lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "This Gender Type is " +
                        "\n" +
                        "Currently in use and cannot" +
                        "be deleted!";
                }

            }
        }
    }
}
