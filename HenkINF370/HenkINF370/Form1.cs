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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Username not Provided!";
                txtUsername.Focus();
            }
            else if(txtPassword.Text == "")
            {
                lblDetails.Text = "Error!" +
    "\n" +
    "\n" +
    "Password not Provided!";
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "SELECT UserID, UserName, UserPassword FROM Users WHERE UserName ='" + txtUsername.Text + "' AND UserPassword ='" + txtPassword.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader reader;
                    reader = sqlcom.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Globals.UserName = (reader["UserName"].ToString());
                            Globals.UserID = Convert.ToInt32((reader["UserID"]));
                            Main_Menu myform = new Main_Menu();
                            myform.ShowDialog();
                            this.Close();
                            this.Dispose(true);
                        }
                    }
                    else
                    {
                        lblDetails.Text = "Error!" +
                            "\n" +
                            "\n" +
                            "The Username and Password provided" +
                            "\n" +
                            "Does not match any records in the Database!";
                    }
                    sqlcon.Close();
                }
                catch
                {
                    lblDetails.Text = "A Connection to the Database could not be made!";
                }
            }
        }

        private void lblFP_Click(object sender, EventArgs e)
        {
            Login_Help myform = new Login_Help();
            myform.ShowDialog();
        }
    }
}
