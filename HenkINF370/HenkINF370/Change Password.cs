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
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Update your Password?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (txtUsername.Text == "" || txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtNewPAsswordRetype.Text == "")
                {
                    lblDetails.Text = "Error!" +
                        "\n" +
                        "\n" +
                        "Not all information required has been provided!";
                }
                else
                {
                    try
                    {
                        string UserName;
                        string Password;
                        //Get UserName and Password
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "SELECT UserName, UserPassword FROM Users WHERE UserName ='" + txtUsername.Text + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        SqlDataReader dr = sqlcom.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                UserName = (dr["UserName"].ToString());
                                Password = (dr["UserPassword"].ToString());

                                if (txtNewPassword.Text != txtNewPAsswordRetype.Text || txtUsername.Text != UserName)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "The New Password and the Password Re-Type do not Match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    try
                                    {
                                        SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                                        sqlcon2.Open();
                                        string cmd2 = "Update Users SET UserPassword ='" + txtNewPAsswordRetype.Text + "' WHERE Username ='" + txtUsername.Text + "' AND UserPassword ='" + txtOldPassword.Text + "'";
                                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                                        sqlcom2.ExecuteNonQuery();
                                        sqlcon2.Close();

                                        MetroFramework.MetroMessageBox.Show(this, "User information Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        txtUsername.Text = "";
                                        txtOldPassword.Text = "";
                                        txtNewPassword.Text = "";
                                        txtNewPAsswordRetype.Text = "";
                                        this.Close();
                                        this.Dispose(true);
                                    }
                                    catch
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "The User informtaion provided does not match any records in the System!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A Connection to the Database could not be made!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Action declined Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.Dispose(true);
            }
        }
    }
}
