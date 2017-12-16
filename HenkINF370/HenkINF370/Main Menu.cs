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
    public partial class Main_Menu : MetroFramework.Forms.MetroForm
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string PrivilegeDescription;
            int PrivilegeID;
            string Name;
            string Surname;
            lblDate.Text = System.DateTime.Now.ToLongDateString();
            
            //Get Privilege
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT PrivilegeID, Name, Surname FROM Users WHERE UserID ='" + Globals.UserID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    PrivilegeID = Convert.ToInt32((dr["PrivilegeID"]));
                    Name = (dr["Name"].ToString());
                    Surname = (dr["Surname"].ToString());

                    lblUser.Text = Name + " " + Surname;
                    //Get Description
                    SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                    sqlcon2.Open();
                    string cmd2 = "SELECT PrivilegeDescription FROM Privilege WHERE PrivilegeID ='" + PrivilegeID.ToString() + "'";
                    SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                    SqlDataReader dr2 = sqlcom2.ExecuteReader();
                    if(dr2.HasRows)
                    {
                        while(dr2.Read())
                        {
                            PrivilegeDescription = (dr2["PrivilegeDescription"].ToString());

                            if (PrivilegeDescription == "Administrator" || PrivilegeDescription == "Manager")
                            {
                                mtManagerFeatures.Enabled = true;
                            }
                            else
                            {
                                mtManagerFeatures.Enabled = false;
                            }
                        }
                    }
                    dr2.Close();
                    sqlcon2.Close();
                }
            }
            dr.Close();
            sqlcon.Close();
          //  MetroFramework.MetroMessageBox.Show(this, "If this is your first login, please Remember to Capture the Float Amount in the Till!",  "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Manager_Features myform = new Manager_Features();
            myform.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Shifts_Form myform = new Shifts_Form();
            myform.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Menu_Form myform = new Menu_Form();
            myform.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Schedule_form myform = new Schedule_form();
            myform.ShowDialog();

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Combos_Form myform = new Combos_Form();
            myform.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Toppings_Form myform = new Toppings_Form();
            myform.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Orders_Form myform = new Orders_Form();
            myform.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Reports_Form myform = new Reports_Form();
            myform.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
                this.Dispose(true);
                Form1 myform = new Form1();
                myform.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Action Declined Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = System.DateTime.Now.ToShortTimeString();
        }
    }
}
