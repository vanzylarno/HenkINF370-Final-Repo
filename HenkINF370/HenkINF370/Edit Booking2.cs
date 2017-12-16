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
    public partial class Edit_Booking2 : MetroFramework.Forms.MetroForm
    {
        public Edit_Booking2()
        {
            InitializeComponent();
        }
        int amount;
        string date;
        int CurrentShiftID = Globals.CurrentShiftID;
        int UserID = Globals.UserID;

        private void Edit_Booking2_Load(object sender, EventArgs e)
        {
            
      lblDate.Text = System.DateTime.Now.ToLongDateString();
            lblDate.Visible = false;


                    SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                    sqlcon3.Open();
                    string cmd3 = "SELECT Date FROM Shifts WHERE ShiftID ='" + CurrentShiftID + "'";
                    SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                    SqlDataReader dr3 = sqlcom3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    date = (dr3["Date"].ToString());
                    if (date == lblDate.Text)
                    {
                        btnFind.Enabled = false;
                        btnRemove.Enabled = false;
                        
                    }
                    else
                    {
                        btnFind.Enabled = true;
                        btnRemove.Enabled = true;
                       
                    }
                }
            }
        }

        int Unbooked = 1;
        int available;
        string availables = "Yes";
        int Final;

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Remove yourself from this booking?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "DELETE FROM ShiftLine WHERE UserID ='" + Globals.UserID.ToString() + "' AND ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "SELECT AvailableSlots FROM Shifts WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                SqlDataReader dr2 = sqlcom2.ExecuteReader();
                if(dr2.HasRows)
                {
                    while(dr2.Read())
                    {
                        available = Convert.ToInt32((dr2["AvailableSlots"]));

                        Final = available + Unbooked;
                        SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                        sqlcon3.Open();
                        string cmd3 = "UPDATE Shifts Set AvailableSlots = @AvailableSlots WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                        SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                        sqlcom3.Parameters.Add(new SqlParameter("@AvailableSlots", Final));
                        sqlcom3.ExecuteNonQuery();
                        sqlcon3.Close();
                        if (Final >= 0)
                        {
                            SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                            sqlcon4.Open();
                            string cmd4 = "UPDATE Shifts Set Available = @Available WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                            SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                            sqlcom4.Parameters.Add(new SqlParameter("@Available", availables));
                            sqlcom4.ExecuteNonQuery();
                            sqlcon4.Close();
                        }
                    }
                }
                dr2.Close();
                sqlcon2.Close();

                this.Close();
                this.Dispose(true);
               
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(true);
            Book_Template myform = new Book_Template();
            myform.ShowDialog();

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Capture_Float_Amount myform = new Capture_Float_Amount();
            myform.ShowDialog();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
