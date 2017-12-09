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
    public partial class Find_User : MetroFramework.Forms.MetroForm
    {
        public Find_User()
        {
            InitializeComponent();
        }

        int Privilege;
        int Gender;
        int Title;
        int UserType;
        int UserID;

        private void Find_User_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            lbxUsers.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Name FROM Users";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lbxUsers.Items.Add((dr["Name"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lbxUsers.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Name FROM Users WHERE Name LIKE '%" + txtFilter.Text + "%'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lbxUsers.Items.Add((dr["Name"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void lbxUsers_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Users WHERE Name ='" + lbxUsers.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtName.Text = (dr["Name"].ToString());
                    txtSurname.Text = (dr["Surname"].ToString());
                    txtPhoneNumber.Text = (dr["PhoneNumber"].ToString());
                    txtEmailAddress.Text = (dr["EmailAddress"].ToString());
                    txtUserName.Text = (dr["UserName"].ToString());
                    Privilege = Convert.ToInt32((dr["PrivilegeID"]));
                    Gender = Convert.ToInt32((dr["GenderID"]));
                    Title = Convert.ToInt32((dr["TitleID"]));
                    UserType = Convert.ToInt32((dr["UserTypeID"]));
                    UserID = Convert.ToInt32((dr["UserID"]));
                }
            }
            dr.Close();
            sqlcon.Close();

            //Get Gender
            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT GenderDescription FROM Gender WHERE GenderID ='" + Gender.ToString() + "'";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2;
            dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    txtGender.Text = (dr2["GenderDescription"].ToString());
                }
            }
            dr2.Close();
            sqlcon2.Close();

            //Get Title
            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "SELECT TitleDescription FROM Title WHERE TitleID ='" + Title.ToString() + "'";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3;
            dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    txtTitle.Text = (dr3["TitleDescription"].ToString());
                }
            }
            dr3.Close();
            sqlcon3.Close();

            //Get Privilege
            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
            sqlcon4.Open();
            string cmd4 = "SELECT PrivilegeDescription FROM Privilege WHERE PrivilegeID ='" + Privilege.ToString() + "'";
            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
            SqlDataReader dr4;
            dr4 = sqlcom4.ExecuteReader();
            if (dr4.HasRows)
            {
                while (dr4.Read())
                {
                    txtPrivilege.Text = (dr4["PrivilegeDescription"].ToString());
                }
            }
            dr4.Close();
            sqlcon4.Close();

            //Get UserType
            SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
            sqlcon5.Open();
            string cmd5 = "SELECT UserDescription FROM UserType WHERE UserTypeID ='" + UserType.ToString() + "'";
            SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
            SqlDataReader dr5;
            dr5 = sqlcom5.ExecuteReader();
            if (dr5.HasRows)
            {
                while (dr5.Read())
                {
                    txtUserType.Text = (dr5["UserDescription"].ToString());
                }
            }
            dr5.Close();
            sqlcon5.Close();
        }
    }
}
