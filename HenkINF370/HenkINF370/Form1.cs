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

                            int UserIDs = Convert.ToInt32((reader["UserID"]));
                            string date = System.DateTime.Now.ToLongDateString();
                            int HasLoggedIn;
                            //Check if first login
                            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                            sqlcon2.Open();
                            string cmd2 = "SELECT HasLoggedIn FROM DailyLogin WHERE UserID ='" + UserIDs.ToString() + "' AND Date ='" + date + "'";
                            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                            SqlDataReader dr2 = sqlcom2.ExecuteReader();
                            if(dr2.HasRows)
                            {
                                while (dr2.Read())
                                {
                                    HasLoggedIn = Convert.ToInt32((dr2["HasLoggedIn"]));
                                }

                            }
                            else
                            {
                                int NewLogin = 1;
                                //Insert new Login
                                SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                                sqlcon3.Open();
                                string cmd3 = "INSERT INTO DailyLogin(Date, HasLoggedIn, UserID) VALUES(@Date, @HasLoggedIn, @UserID)";
                                SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                                sqlcom3.Parameters.Add(new SqlParameter("@Date", date));
                                sqlcom3.Parameters.Add(new SqlParameter("@HasLoggedIn", NewLogin));
                                sqlcom3.Parameters.Add(new SqlParameter("@UserID", UserIDs));
                                sqlcom3.ExecuteNonQuery();
                                sqlcon3.Close();

                            }
                            dr2.Close();
                            sqlcon2.Close();


                            this.Hide();
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
