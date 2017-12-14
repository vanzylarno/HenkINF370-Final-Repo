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
    public partial class Restore_System : MetroFramework.Forms.MetroForm
    {
        public Restore_System()
        {
            InitializeComponent();
        }

        private void Restore_System_Load(object sender, EventArgs e)
        {
            btnRestore.Enabled = false;

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

        private void metroButton1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup Files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtFilename.Text == "" || cbxDatabaseName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Provide all fiedls Required for System Restore!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogueResult = MetroFramework.MetroMessageBox.Show(this, "Are you Sure you want to Restore from this File? :" + txtFilename.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogueResult == DialogResult.Yes)
                {
                    try
                    {


                        SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                        sqlcon.Open();

                        string Query1 = "ALTER DATABASE [" + cbxDatabaseName.Text + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                        SqlCommand sqlcom1 = new SqlCommand(Query1, sqlcon);
                        sqlcom1.ExecuteNonQuery();

                        string Query2 = "USE MASTER RESTORE DATABASE [" + cbxDatabaseName.Text + "] FROM DISK ='" + txtFilename.Text + "' WITH REPLACE";
                        SqlCommand sqlCom2 = new SqlCommand(Query2, sqlcon);
                        sqlCom2.ExecuteNonQuery();

                        string Query3 = "ALTER DATABASE [" + cbxDatabaseName.Text + "] SET MULTI_USER";
                        SqlCommand sqlcom3 = new SqlCommand(Query3, sqlcon);
                        sqlcom3.ExecuteNonQuery();

                        sqlcon.Close();
                        MetroFramework.MetroMessageBox.Show(this, "The Database Restor was Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "An Error Has Occurred whils Restoring the Database!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }
    }
}
