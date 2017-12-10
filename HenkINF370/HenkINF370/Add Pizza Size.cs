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
    public partial class Add_Pizza_Size : MetroFramework.Forms.MetroForm
    {
        public Add_Pizza_Size()
        {
            InitializeComponent();
        }

        private void Add_Pizza_Size_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || txtPrice.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Not all information required has been " +
                    "\n" +
                    "provided!";
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "INSERT INTO PizzaSize(Description, Price) VALUES(@Description, @Price)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Description", txtDescription.Text));
                    sqlcom.Parameters.Add(new SqlParameter("@Price", txtPrice.Text));
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    lblDetails.Text = "Success!" +
                        "\n" +
                        "\n" +
                        "The Pizza Size was added" +
                        "\n" +
                        "Successfully!";

                    txtDescription.Text = "";
                    txtPrice.Text = "";
                }
                catch
                {
                    lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "A Connection to the database could not" +
                        "\n" +
                        "be made!";
                }
            }
        }
    }
}

