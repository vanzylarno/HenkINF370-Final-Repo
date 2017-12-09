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
    public partial class Edit_Booked_Shifts : MetroFramework.Forms.MetroForm
    {
        public Edit_Booked_Shifts()
        {
            InitializeComponent();
        }
        int ShiftIDs;

        private void Edit_Booked_Shifts_Load(object sender, EventArgs e)
        {
           
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM ShiftLine WHERE UserID ='" + Globals.UserID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["ShiftID"].ToString());
                }

            }
            dr.Close();
            sqlcon.Close();


        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlocn = new SqlConnection(Globals.ConnectionString);
            sqlocn.Open();
            string cmd = "SELECT * FROM Shifts WHERE ShiftID  ='" + listBox1.Text.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlocn);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtDayz.Text = (dr["Day"].ToString());
                    txtTimeSlot.Text = (dr["TimeSlot"].ToString());
                    txtAvailable.Text = (dr["Available"].ToString());
                    txtDate.Text = (dr["Date"].ToString());
                    txtAvailableSlots.Text = (dr["AvailableSlots"].ToString());
                    Globals.UpdateShiftID = Convert.ToInt32((dr["ShiftID"]));
                    Globals.CurrentShiftID = Convert.ToInt32((dr["ShiftID"]));

                }
            }
            dr.Close();
            sqlocn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Edit this Booking?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                Edit_Booking2 myform = new Edit_Booking2();
                myform.ShowDialog();

                listBox1.Items.Clear();
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT * FROM ShiftLine WHERE UserID ='" + Globals.UserID.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add((dr["ShiftID"].ToString()));
                    }

                }
                dr.Close();
                sqlcon.Close();
            }
        }

        private void Edit_Booked_Shifts_Leave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM ShiftLine WHERE UserID ='" + Globals.UserID.ToString() + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add((dr["ShiftID"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
