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
    public partial class Change_Password : MetroFramework.Forms.MetroForm
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtNewPAsswordRetype.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Not all information required has been provided!";
            }
            else if(txtNewPassword.Text != txtNewPAsswordRetype.Text)
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "The New Password Provided does not match the retype!";
            }
            else
            {

                {
                    try
                    {
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "Update Users SET UserPassword ='" + txtNewPAsswordRetype.Text + "' WHERE Username ='" + txtUsername.Text + "' AND UserPassword ='" + txtOldPassword.Text + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        sqlcom.ExecuteNonQuery();
                        sqlcon.Close();
                        lblDetails.Text = "Success!" +
                        "\n" +
                        "\n" +
                        "The Password has been changed!";

                        txtUsername.Text = "";
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtNewPAsswordRetype.Text = "";
                    }
                    catch
                    {
                        lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "The User inforamtion requested does not" +
                        "\n" +
                        "exist on the System!";
                    }
                }
            }
        }
    }
}
