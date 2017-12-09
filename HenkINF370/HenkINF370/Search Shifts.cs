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
    public partial class Search_Shifts : MetroFramework.Forms.MetroForm
    {
        public Search_Shifts()
        {
            InitializeComponent();
        }

        private void Search_Shifts_Load(object sender, EventArgs e)
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
        string Search;
        private void Search_Shifts_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
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
                }
            }
            dr.Close();
            sqlocn.Close();
        }
    }
}
