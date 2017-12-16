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
    public partial class Add_User : MetroFramework.Forms.MetroForm
    {
        public Add_User()
        {
            InitializeComponent();
        }

        //Variables
        int Gender;
        int Privilege;
        int Title;
        int UserType;

        private void Add_User_Load(object sender, EventArgs e)
        {
            //Pre-Load Data
            cbxPrivilegeType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Privilege";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxPrivilegeType.Items.Add((dr["PrivilegeDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();

            cbxGender.Items.Clear();
            SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
            sqlcon2.Open();
            string cmd2 = "SELECT * FROM Gender";
            SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
            SqlDataReader dr2;
            dr2 = sqlcom2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    cbxGender.Items.Add((dr2["GenderDescription"].ToString()));
                }
            }
            dr2.Close();
            sqlcon2.Close();

            cbxTitle.Items.Clear();
            SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
            sqlcon3.Open();
            string cmd3 = "SELECT * FROM Title";
            SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
            SqlDataReader dr3;
            dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    cbxTitle.Items.Add((dr3["TitleDescription"].ToString()));
                }
            }
            dr3.Close();
            sqlcon3.Close();

            cbxUserType.Items.Clear();
            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
            sqlcon4.Open();
            string cmd4 = "SELECT * FROM UserType";
            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
            SqlDataReader dr4;
            dr4 = sqlcom4.ExecuteReader();
            if (dr4.HasRows)
            {
                while (dr4.Read())
                {
                    cbxUserType.Items.Add((dr4["UserDescription"].ToString()));
                }
            }
            dr4.Close();
            sqlcon4.Close();
        }

        private void cbxPrivilegeType_Click(object sender, EventArgs e)
        {

            cbxPrivilegeType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Privilege";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxPrivilegeType.Items.Add((dr["PrivilegeDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxGender_Click(object sender, EventArgs e)
        {
            cbxGender.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Gender";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxGender.Items.Add((dr["GenderDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxTitle_Click(object sender, EventArgs e)
        {
            cbxTitle.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Title";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxTitle.Items.Add((dr["TitleDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxUserType_Click(object sender, EventArgs e)
        {
            cbxUserType.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM UserType";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr;
            dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxUserType.Items.Add((dr["UserDescription"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "" || txtPassword.Text == "" || txtUsername.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtPhoneNumber.Text == "" || cbxTitle.Text == "" || cbxGender.Text == "" || cbxPrivilegeType.Text == "" || cbxUserType.Text == "")
            {
                lblDetails.Text = "Error!" +
                    "\n" +
                    "\n" +
                    "Not all information required has been Provided!";
            }
            else
            {
                DialogResult r = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to add this User?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        //Check if Username already exists
                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();
                        string cmd = "SELECT UserID, UserName, UserPassword FROM Users WHERE UserName ='" + txtUsername.Text + "'";
                        SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                        SqlDataReader reader;
                        reader = sqlcom.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lblDetails.Text = "Error!" +
                                     "\n" +
                                     "\n" +
                                     "This Username is already assigned!" +
                                     "\n" +
                                     "Please choose a different one";
                            }
                        }
                        else
                        {
                            try
                            {
                                //Get Gender
                                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                                sqlcon2.Open();
                                string cmd2 = "SELECT GenderID FROM Gender WHERE GenderDescription ='" + cbxGender.SelectedItem.ToString() + "'";
                                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                                SqlDataReader dr2;
                                dr2 = sqlcom2.ExecuteReader();
                                if (dr2.HasRows)
                                {
                                    while (dr2.Read())
                                    {
                                        Gender = Convert.ToInt32((dr2["GenderID"]));
                                    }
                                }
                                dr2.Close();
                                sqlcon2.Close();

                                //Get Title
                                SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                                sqlcon3.Open();
                                string cmd3 = "SELECT TitleID FROM Title WHERE TitleDescription ='" + cbxTitle.SelectedItem.ToString() + "'";
                                SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                                SqlDataReader dr3;
                                dr3 = sqlcom3.ExecuteReader();
                                if (dr3.HasRows)
                                {
                                    while (dr3.Read())
                                    {
                                        Title = Convert.ToInt32((dr3["TitleID"]));
                                    }
                                }
                                dr3.Close();
                                sqlcon3.Close();

                                //Get Privilege
                                SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                                sqlcon4.Open();
                                string cmd4 = "SELECT PrivilegeID FROM Privilege WHERE PrivilegeDescription ='" + cbxPrivilegeType.SelectedItem.ToString() + "'";
                                SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                                SqlDataReader dr4;
                                dr4 = sqlcom4.ExecuteReader();
                                if (dr4.HasRows)
                                {
                                    while (dr4.Read())
                                    {
                                        Privilege = Convert.ToInt32((dr4["PrivilegeID"]));
                                    }
                                }
                                dr4.Close();
                                sqlcon4.Close();

                                //Get UserType
                                SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
                                sqlcon5.Open();
                                string cmd5 = "SELECT UserTypeID FROM UserType WHERE UserDescription ='" + cbxUserType.SelectedItem.ToString() + "'";
                                SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
                                SqlDataReader dr5;
                                dr5 = sqlcom5.ExecuteReader();
                                if (dr5.HasRows)
                                {
                                    while (dr5.Read())
                                    {
                                        UserType = Convert.ToInt32((dr5["UserTypeID"]));
                                    }
                                }
                                dr5.Close();
                                sqlcon5.Close();


                                //Insert Into Users
                                string name = txtName.Text;
                                string Surname = txtSurname.Text;
                                string phoneNumber = txtPhoneNumber.Text;
                                string email = txtEmailAddress.Text;
                                string username = txtUsername.Text;
                                string password = txtPassword.Text;


                                SqlConnection sqlcon1 = new SqlConnection(Globals.ConnectionString);
                                sqlcon1.Open();
                                string cmd1 = "INSERT INTO Users(Name, Surname, PhoneNumber, EmailAddress, UserName, UserPassword, PrivilegeID, GenderID, TitleID, UserTypeID) VALUES(@Name, @Surname, @PhoneNumber, @EmailAddress, @UserName, @UserPassword, @PrivilegeID, @GenderID, @TitleID, @UserTypeID)";
                                SqlCommand sqlcom1 = new SqlCommand(cmd1, sqlcon1);
                                sqlcom1.Parameters.Add(new SqlParameter("@Name", name));
                                sqlcom1.Parameters.Add(new SqlParameter("@Surname", Surname));
                                sqlcom1.Parameters.Add(new SqlParameter("@PhoneNumber", phoneNumber));
                                sqlcom1.Parameters.Add(new SqlParameter("@EmailAddress", email));
                                sqlcom1.Parameters.Add(new SqlParameter("@UserName", username));
                                sqlcom1.Parameters.Add(new SqlParameter("@UserPassword", password));
                                sqlcom1.Parameters.Add(new SqlParameter("@PrivilegeID", Privilege));
                                sqlcom1.Parameters.Add(new SqlParameter("@GenderID", Gender));
                                sqlcom1.Parameters.Add(new SqlParameter("@TitleID", Title));
                                sqlcom1.Parameters.Add(new SqlParameter("@UserTypeID", UserType));
                                sqlcom1.ExecuteNonQuery();
                                sqlcon1.Close();

                                lblDetails.Text = "Success!" +
                                    "\n" +
                                    "\n" +
                                    "The New User was added Successfully!";

                                txtUsername.Text = "";
                                txtPassword.Text = "";
                                txtEmailAddress.Text = "";
                                txtName.Text = "";
                                txtPhoneNumber.Text = "";
                                txtSurname.Text = "";
                                cbxGender.Text = "";
                                cbxPrivilegeType.Text = "";
                                cbxTitle.Text = "";
                                cbxGender.Items.Clear();
                                cbxPrivilegeType.Items.Clear();
                                cbxTitle.Items.Clear();
                                cbxUserType.Items.Clear();


                                int UssserID;
                                //Get UserID
                                SqlConnection sqlcon7 = new SqlConnection(Globals.ConnectionString);
                                sqlcon7.Open();
                                string cmd7 = "SELECT UserID FROM Users WHERE Name ='" + name + "', Surname ='" + Surname + "', PhoneNumber ='" + phoneNumber + "', EmailAddress ='" + email + "', UserName ='" + username + "', UserPassword ='" + password + "', PrivilegeID ='" + Privilege.ToString() + "', GenderID ='" + Gender.ToString() + "', TitleID ='" + Title.ToString() + "', UserTypeID ='" + UserType.ToString() + "'";
                                SqlCommand sqlcom7 = new SqlCommand(cmd7, sqlcon7);
                                SqlDataReader dr7 = sqlcom7.ExecuteReader();
                                if(dr7.HasRows)
                                {
                                    while(dr7.Read())
                                    {
                                        UssserID = Convert.ToInt32((dr7["UserID"]));
                                        string date = System.DateTime.Now.ToLongDateString();
                                        int NewUser = 1;
                                        //Insert into Login
                                        SqlConnection sqlcon8 = new SqlConnection(Globals.ConnectionString);
                                        sqlcon8.Open();
                                        string cmd8 = "INSERT INTO DailyLogin(Date, HasLoggedIn, UserID) VALUES(@Date, @HasLoggedIn, @UserID)";
                                        SqlCommand sqlcom8 = new SqlCommand(cmd8, sqlcon8);
                                        sqlcom8.Parameters.Add(new SqlParameter("@Date", date));
                                        sqlcom8.Parameters.Add(new SqlParameter("@HasLoggedIn", NewUser));
                                        sqlcom8.Parameters.Add(new SqlParameter("@UserID", UssserID));
                                        sqlcom8.ExecuteNonQuery();
                                        sqlcon8.Close();
                                    }
                                }
                                dr7.Close();
                                sqlcon7.Close();
                            }
                            catch
                            {
                                lblDetails.Text = "Error!" +
                                    "\n" +
                                    "\n" +
                                    "A Connection to the Database could" +
                                    "not be made!";
                            }
                        }
                        reader.Close();
                        sqlcon.Close();
                    }
                    catch
                    {
                        lblDetails.Text = "Error!" +
                                    "\n" +
                                    "\n" +
                                    "A Connection to the Database could" +
                                    "not be made!";
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Action declined Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtEmailAddress.Text = "";
                    txtName.Text = "";
                    txtPhoneNumber.Text = "";
                    txtSurname.Text = "";
                    cbxGender.Text = "";
                    cbxPrivilegeType.Text = "";
                    cbxTitle.Text = "";
                    cbxPrivilegeType.Items.Clear();
                    cbxTitle.Items.Clear();
                    cbxUserType.Items.Clear();
                }
            }
        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {
            Users_Help myform = new Users_Help();
            myform.ShowDialog();
        }
    }
}
    

