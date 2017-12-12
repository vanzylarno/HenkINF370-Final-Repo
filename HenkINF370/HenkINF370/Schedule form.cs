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
    public partial class Schedule_form : MetroFramework.Forms.MetroForm
    {
        public Schedule_form()
        {
            InitializeComponent();
        }

        private void Schedule_form_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Monday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Tuesday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Wednesday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Thursday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Friday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Saturday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Day = 'Sunday' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            string TimeSlot;
            string AvailableSlots;

            this.dataGridView1.Rows.Clear();
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT TimeSlot, AvailableSlots FROM Shifts WHERE Date = '" + dtpDate.Text.ToString() + "' Order by TimeSlot";
            SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
            SqlDataReader dr = sqlcom.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    TimeSlot = (dr["TimeSlot"].ToString());
                    AvailableSlots = (dr["AvailableSlots"].ToString());

                    this.dataGridView1.Rows.Add(TimeSlot, AvailableSlots);
                }
            }
            dr.Close();
            sqlcon.Close();
        }
    }
}
