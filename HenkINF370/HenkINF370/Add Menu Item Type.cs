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
    public partial class Add_Menu_Item_Type : MetroFramework.Forms.MetroForm
    {
        public Add_Menu_Item_Type()
        {
            InitializeComponent();
        }

        private void Add_Menu_Item_Type_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
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
                    string cmd = "INSERT INTO MenuItemType(Description) VALUES(@Description)";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    sqlcom.Parameters.Add(new SqlParameter("@Description", txtDescription.Text));

                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();

                    lblDetails.Text = "Success!" +
                        "\n" +
                        "\n" +
                        "The Menu Item Type was added" +
                        "\n" +
                        "Successfully!";

                    txtDescription.Text = "";
                    
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

