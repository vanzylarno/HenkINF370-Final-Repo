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
using System.Net;
using System.Net.Mail;

namespace HenkINF370
{
    public partial class Find_Forgotten_Password : MetroFramework.Forms.MetroForm
    {
        public Find_Forgotten_Password()
        {
            InitializeComponent();
        }
        string Password;
        string eMail;
        string Name;
        string Surname;
        string UserName;

        private void Find_Forgotten_Password_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
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
                    SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                    sqlcon.Open();
                    string cmd = "SELECT EmailAddress, Name, Surname, UserName, UserPassword FROM Users WHERE EmailAddress ='" + txtEmail.Text + "'";
                    SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                    SqlDataReader dr = sqlcom.ExecuteReader();
                    if(dr.HasRows)
                    {
                        while(dr.Read())
                        {
                            Password = (dr["UserPassword"].ToString());
                            eMail = (dr["EmailAddress"].ToString());
                            Name = (dr["Name"].ToString());
                            Surname = (dr["Surname"].ToString());
                            UserName = (dr["UserName"].ToString());

                            MailMessage mail = new MailMessage();
                            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                            mail.From = new MailAddress("henkinf370@gmail.com");
                            mail.To.Add(eMail);
                            mail.Subject = "Find a Forgotten Password";
                            mail.Body = "Dear" + " " + Name + " " + Surname + "\n" +
                                "\n" +
                                "Your Account information is:" +
                                "\n" +
                                "Username:" + " " + UserName +"\n" +
                                "Password:" + " " + Password ;

                            smtpServer.Port = 587;
                            smtpServer.Credentials = new System.Net.NetworkCredential("henkinf370@gmail.com", "Arno1717");
                            smtpServer.EnableSsl = true;

                            smtpServer.Send(mail);

                            lblDetails.Text = "Success!" +
                                "\n" +
                                "\n" +
                                "Email sent Successfully!";
                            txtEmail.Text = "";

                        }
                        dr.Close();
                        sqlcon.Close();
                    }
                    else
                    {
                        lblDetails.Text = "Error!" +
    "\n" +
    "\n" +
    "The email Address provided does not" +
    "\n" +
    "match any Users registered on the System!";
                    }
                }
                
                catch
                {
                    lblDetails.Text = "Error!" +
"\n" +
"\n" +
"A Connection to the database could not" +
"\n" +
"be made at this time!";
                    txtEmail.Text = "";
                }
                
            }
        }
    }
}
