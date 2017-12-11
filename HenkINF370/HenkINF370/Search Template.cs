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
    public partial class Search_Template : MetroFramework.Forms.MetroForm
    {
        public Search_Template()
        {
            InitializeComponent();
        }

        private void Search_Template_Load(object sender, EventArgs e)
        {
            PopulateTimeSlotCBX();
            string Day;
            string TimeSlot;
            string Date;
            string AvailableSlots;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Day, TimeSlot, Date, AvailableSlots FROM Shifts WHERE Available = 'Yes' ORDER BY Day";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Day = (dr["Day"].ToString());
                    TimeSlot = (dr["TimeSlot"].ToString());
                    Date = (dr["Date"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(Day, TimeSlot, Date, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void PopulateTimeSlotCBX()
        {
            cbxTimeSlots.Items.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT DISTINCT TimeSlot FROM Shifts";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbxTimeSlots.Items.Add((dr["TimeSlot"].ToString()));
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxTimeSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string Day;
            string TimeSlot;
            string Date;
            string AvailableSlots;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Day, TimeSlot, Date, AvailableSlots FROM Shifts WHERE TimeSlot ='" + cbxTimeSlots.SelectedItem.ToString() + "' AND Available = 'Yes'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Day = (dr["Day"].ToString());
                    TimeSlot = (dr["TimeSlot"].ToString());
                    Date = (dr["Date"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(Day, TimeSlot, Date, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void cbxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                this.dataGridView1.Rows.Clear();
                string Day;
                string TimeSlot;
                string Date;
                string AvailableSlots;

                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT Day, TimeSlot, Date, AvailableSlots FROM Shifts WHERE Day ='" + cbxDay.SelectedItem.ToString() + "' AND Available = 'Yes'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Day = (dr["Day"].ToString());
                        TimeSlot = (dr["TimeSlot"].ToString());
                        Date = (dr["Date"].ToString());
                        AvailableSlots = (dr["AvailableSlots"].ToString());

                        this.dataGridView1.Rows.Add(Day, TimeSlot, Date, AvailableSlots);
                    }
                }
                dr.Close();
                sqlcon.Close();
            
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string Day;
            string TimeSlot;
            string Date;
            string AvailableSlots;

            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Day, TimeSlot, Date, AvailableSlots FROM Shifts WHERE Date ='" + dtpDate.Text.ToString() + "' AND Available = 'Yes'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Day = (dr["Day"].ToString());
                    TimeSlot = (dr["TimeSlot"].ToString());
                    Date = (dr["Date"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(Day, TimeSlot, Date, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            string Day;
            string TimeSlot;
            string Date;
            string AvailableSlots;
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT Day, TimeSlot, Date, AvailableSlots FROM Shifts WHERE Available = 'Yes'";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Day = (dr["Day"].ToString());
                    TimeSlot = (dr["TimeSlot"].ToString());
                    Date = (dr["Date"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(Day, TimeSlot, Date, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
