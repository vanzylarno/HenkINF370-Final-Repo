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
    public partial class View_Available_Shifts : MetroFramework.Forms.MetroForm
    {
        public View_Available_Shifts()
        {
            InitializeComponent();
        }
        string day;
        string timeslot;
        string available;
        string date;
        int AvailableSlots;
        string Available = "Yes";
        private void View_Available_Shifts_Load(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Date FROM Shifts WHERE Available ='" + Available + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    listBox1.Items.Add((dr["Date"].ToString()));
                }

            }
            dr.Close();
            sqlcon.Close();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlocn = new SqlConnection(Globals.ConnectionString);
            sqlocn.Open();
            string cmd = "SELECT * FROM Shifts WHERE Date ='" + listBox1.Text.ToString() + "' AND Available ='" + Available + "'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlocn);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
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
