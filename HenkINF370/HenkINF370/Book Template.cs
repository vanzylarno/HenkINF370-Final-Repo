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
    public partial class Book_Template : MetroFramework.Forms.MetroForm
    {
        public Book_Template()
        {
            InitializeComponent();
        }
        int Selected;
        private void Book_Template_Load(object sender, EventArgs e)
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
            string cmd = "SELECT DISTINCT TimeSlot FROM Shifts WHERE Available = 'Yes'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to Book for this Shift?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                
                //Select ShiftID
                int i = this.dataGridView1.CurrentCell.RowIndex;

                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "SELECT * From Shifts WHERE Day ='" + this.dataGridView1.Rows[i].Cells["colDay"].Value.ToString() + "' AND TimeSlot ='" + this.dataGridView1.Rows[i].Cells["colTimeSlot"].Value.ToString() + "' AND Date ='" + this.dataGridView1.Rows[i].Cells["colDate"].Value.ToString() + "' AND AvailableSlots ='" + this.dataGridView1.Rows[i].Cells["colAvailableSlots"].Value.ToString() + "'";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                SqlDataReader dr = sqlcom.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int AvailableSlots;
                        Selected = Convert.ToInt32((dr["ShiftID"]));
                        Globals.TemplateID = Convert.ToInt32((dr["ShiftID"]));
                        AvailableSlots = Convert.ToInt32((dr["AvailableSlots"]));

                        int Total = AvailableSlots - 1;
                        //Update AvailableSlots
                        SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                        sqlcon2.Open();
                        string cmd2 = "UPDATE Shifts SET AvailableSlots = @AvailableSlots WHERE ShiftID ='" + Selected.ToString() + "'";
                        SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                        sqlcom2.Parameters.Add(new SqlParameter("@AvailableSlots", Total));
                        sqlcom2.ExecuteNonQuery();
                        sqlcon2.Close();

                        int Zero = 0;
                        //Insert Into ShiftLine
                        SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                        sqlcon3.Open();
                        string cmd3 = "INSERT INTO ShiftLine(UserID, ShiftID, FloatAmountInTill) VALUES(@UserID, @ShiftID, @FloatAmountInTill)";
                        SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                        sqlcom3.Parameters.Add(new SqlParameter("@UserID", Globals.UserID));
                        sqlcom3.Parameters.Add(new SqlParameter("@ShiftID", Selected));
                        sqlcom3.Parameters.Add(new SqlParameter("@FloatAmountInTill", Zero));
                        sqlcom3.ExecuteNonQuery();
                        sqlcon3.Close();
                    }
                }
                dr.Close();
                sqlcon.Close();
                this.dataGridView1.Rows.Clear();

                MetroFramework.MetroMessageBox.Show(this, "Booking Made Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
                this.Dispose(true);

            
            }
        }
    }
}
