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
    public partial class Backup_System : MetroFramework.Forms.MetroForm
    {
        public Backup_System()
        {
            InitializeComponent();
        }

        private void Backup_System_Load(object sender, EventArgs e)
        {
            //Populate Datbases
            SqlConnection sqlcon1 = new SqlConnection(Globals.ConnectionString);
            sqlcon1.Open();
            string CMD1 = "SELECT * FROM sysdatabases";
            SqlCommand sqlCom1 = new SqlCommand(CMD1, sqlcon1);
            SqlDataReader sqlDR1;
            sqlDR1 = sqlCom1.ExecuteReader();

            while (sqlDR1.Read())
            {
                cbxDatabaseName.Items.Add(sqlDR1[0]);
            }
            sqlcon1.Close();
        }

        private void btnCreatebackup_Click(object sender, EventArgs e)
        {
            if (cbxDatabaseName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Select a Server and a Database to Backup!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                try
                {

                    sfd.DefaultExt = ".bak";

                    sfd.ShowDialog();

                    string FilePath = sfd.FileName;

                    SqlConnection sqlCon = new SqlConnection(Globals.ConnectionString);
                    sqlCon.Open();
                    string Command = "BACKUP DATABASE " + cbxDatabaseName.Text + " TO DISK ='" + @"" + FilePath + "" + "'";
                    SqlCommand sqlCom = new SqlCommand(Command, sqlCon);
                    sqlCom.ExecuteNonQuery();

                    MetroFramework.MetroMessageBox.Show(this, "Database Successfully Backedup!" + "\n" + "Backup Location " + FilePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    sqlCon.Close();
                    this.Close();
                    this.Dispose(true);

                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "An Error has Occured backing up the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }
    }
}
