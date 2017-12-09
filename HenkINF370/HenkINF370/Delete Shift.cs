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
    public partial class Delete_Shift : MetroFramework.Forms.MetroForm
    {
        public Delete_Shift()
        {
            InitializeComponent();
        }
        string Search;
        private void Delete_Shift_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Shifts";
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

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Search = dtp.Value.ToLongDateString();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Shifts WHERE Date ='" + Search + "'";
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
                    txtDay.Text = (dr["Day"].ToString());
                    txtTimeSlot.Text = (dr["TimeSlot"].ToString());
                    txtAvailable.Text = (dr["Available"].ToString());
                    txtDate.Text = (dr["Date"].ToString());
                    txtAvailableSlots.Text = (dr["AvailableSlots"].ToString());
                    Globals.UpdateShiftID = Convert.ToInt32((dr["ShiftID"]));
                }
            }
            dr.Close();
            sqlocn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Delete this Shift?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "DELETE FROM Shifts WHERE ShiftID ='" + listBox1.Text.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                lblDetails.Text = "Success!" +
                    "\n" +
                    "\n" +
                    "Shift removed Successfully!";

                listBox1.Items.Clear();
                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "SELECT * FROM Shifts";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                SqlDataReader dr2 = sqlcom2.ExecuteReader();
                if (dr2.HasRows)
                {
                    while (dr2.Read())
                    {
                        listBox1.Items.Add((dr2["ShiftID"].ToString()));
                    }

                }
                dr2.Close();
                sqlcon2.Close();
            }
        }
    }
}
