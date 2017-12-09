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
    public partial class Book_Shift : MetroFramework.Forms.MetroForm
    {
        public Book_Shift()
        {
            InitializeComponent();
        }
        string Search;
        int booked = 1;
        int Total;
        int available;
        int CheckZero;
        string no = "No";
        string Yes = "Yes";
        int AmountAvailable;

        private void Book_Shift_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
            sqlcon.Open();
            string cmd = "SELECT * FROM Shifts WHERE Available ='" + Yes + "'";
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
            string cmd = "SELECT * FROM Shifts WHERE Date ='" + Search + "' AND Available ='" + Yes + "'";
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
                    available = Convert.ToInt32((dr["AvailableSlots"]));
                }
            }
            dr.Close();
            sqlocn.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DialogResult d = MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to book this Shift?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                int Float = 0;
                SqlConnection sqlcon = new SqlConnection(Globals.ConnectionString);
                sqlcon.Open();
                string cmd = "Insert INTO ShiftLine(UserID, ShiftID, FloatAmountInTill) VALUES(@UserID, @ShiftID, @Float)";
                SqlCommand sqlcom = new SqlCommand(cmd, sqlcon);
                sqlcom.Parameters.Add(new SqlParameter("@UserID", Globals.UserID));
                sqlcom.Parameters.Add(new SqlParameter("@ShiftID", Globals.UpdateShiftID));
                sqlcom.Parameters.Add(new SqlParameter("@Float", Float));
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();

                lblDetails.Text = "Success!" +
                    "\n" +
                    "\n" +
                    "Shift booked Successfully!";

                Total = available - booked;

                SqlConnection sqlcon2 = new SqlConnection(Globals.ConnectionString);
                sqlcon2.Open();
                string cmd2 = "UPDATE Shifts SET AvailableSlots = @AvailableSlots WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                SqlCommand sqlcom2 = new SqlCommand(cmd2, sqlcon2);
                sqlcom2.Parameters.Add(new SqlParameter("@AvailableSlots", Total));
                sqlcom2.ExecuteNonQuery();
                sqlcon2.Close();

                SqlConnection sqlcon3 = new SqlConnection(Globals.ConnectionString);
                sqlcon3.Open();
                string cmd3 = "SELECT * FROM Shifts";
                SqlCommand sqlcom3 = new SqlCommand(cmd3, sqlcon3);
                SqlDataReader dr3 = sqlcom3.ExecuteReader();
                if (dr3.HasRows)
                {
                    while (dr3.Read())
                    {
                         AmountAvailable = Convert.ToInt32((dr3["AvailableSlots"]));

                    }

                }
                dr3.Close();
                sqlcon3.Close();

                if (AmountAvailable == 0)
                {
                    SqlConnection sqlcon4 = new SqlConnection(Globals.ConnectionString);
                    sqlcon4.Open();
                    string cmd4 = "UPDATE Shifts SET Available ='" + no + "' WHERE ShiftID ='" + Globals.UpdateShiftID.ToString() + "'";
                    SqlCommand sqlcom4 = new SqlCommand(cmd4, sqlcon4);
                    sqlcom4.ExecuteNonQuery();
                    sqlcon4.Close();
                }

                listBox1.Items.Clear();
                SqlConnection sqlcon5 = new SqlConnection(Globals.ConnectionString);
                sqlcon5.Open();
                string cmd5 = "SELECT * FROM Shifts WHERE Available ='" + Yes + "'";
                SqlCommand sqlcom5 = new SqlCommand(cmd5, sqlcon5);
                SqlDataReader dr5 = sqlcom5.ExecuteReader();
                if (dr5.HasRows)
                {
                    while (dr5.Read())
                    {
                        listBox1.Items.Add((dr5["ShiftID"].ToString()));
                    }

                }
                dr5.Close();
                sqlcon5.Close();
            }
        }
    }
}
